using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace MoonScriptEditor
{
    public partial class MainForm : Form
    {
        private string CurrentFileName { get; set; }
        private string DefaultText = "* New MoonScript Script\r\n* Created by \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
        private string DefaultTitle = "MoonScript Editor - [new file]";
        private bool ChangesPending { get; set; }
        private bool ListenForChanges { get; set; }
        private AboutForm AboutDialog { get; }

        public MainForm()
        {
            this.DoubleBuffered = true;
            this.AboutDialog = new AboutForm();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainEditor.DescriptionFile = Path.Combine("config", "editor", "syntax.xml");
            mainEditor.InsertText(this.DefaultText);

            var reader = new DSList(Path.Combine("config", "editor", "mslist.ini"));

            mainEditor.TextChanged += (x, z) =>
            {
                if (this.ListenForChanges && !this.ChangesPending)
                {
                    this.Text += " *";
                    this.ChangesPending = true;
                }
            };

            mainEditor.SelectionChanged += (n, x) =>
            {
                mainEditor.CaretVisible = true;
                tsStatusLineColumn.Text = $"{mainEditor.Selection.End.iLine + 1}:{mainEditor.Selection.End.iChar + 1}";
                tsStatusLineCount.Text = $"{mainEditor.LinesCount} lines displayed.";
            };

            mainEditor.Selection.Start = new Place(mainEditor.Lines[1].Length, 1);

            this.ListenForChanges = true;

            lvCauses.OwnerDraw = true;
            lvCauses.DrawItem += this.DrawTriggerListViewItem;
            lvCauses.DoubleClick += this.DoubleClickTrigger;

            lvAdditionalConditions.OwnerDraw = true;
            lvAdditionalConditions.DrawItem += this.DrawTriggerListViewItem;
            lvAdditionalConditions.DoubleClick += this.DoubleClickTrigger;

            lvAreas.OwnerDraw = true;
            lvAreas.DrawItem += this.DrawTriggerListViewItem;
            lvAreas.DoubleClick += this.DoubleClickTrigger;

            lvFilters.OwnerDraw = true;
            lvFilters.DrawItem += this.DrawTriggerListViewItem;
            lvFilters.DoubleClick += this.DoubleClickTrigger;

            lvEffects.OwnerDraw = true;
            lvEffects.DrawItem += this.DrawTriggerListViewItem;
            lvEffects.DoubleClick += this.DoubleClickTrigger;

            foreach (var (category, id, description, hints) in reader.Triggers)
            {
                var item = new TriggerViewItem()
                {
                    Category = category,
                    Id = id,
                    Description = description,
                    Hints = hints
                };

                switch (category)
                {
                    case 0:
                        lvCauses.Items.Add(item);
                        break;

                    case 1:
                        lvAdditionalConditions.Items.Add(item);
                        break;

                    case 3:
                        lvAreas.Items.Add(item);
                        break;

                    case 4:
                        lvFilters.Items.Add(item);
                        break;

                    case 5:
                        lvEffects.Items.Add(item);
                        break;
                }
            }
        }

        private void DoubleClickTrigger(object sender, EventArgs e)
        {
            var lv = (ListViewWithoutHorizontalScrollBar)sender;

            if (lv.SelectedItems.Count > 0)
            {
                if (lv.SelectedItems[0] == null)
                    return;

                var si = lv.SelectedItems[0] as TriggerViewItem;
                var whitespace = new string(' ', si.Category == 0 ? 0 : si.Category == 1 ? 1 : si.Category - 1);

                if (mainEditor.Selection.Start.iChar > 1)
                {
                    var current_line = mainEditor.GetLine(mainEditor.Selection.Start.iLine);
                    mainEditor.Selection.Start = new Place(current_line.End.iChar, current_line.End.iLine);
                    mainEditor.InsertText("\n");
                }

                mainEditor.InsertText($"{whitespace}({si.Category}:{si.Id}) {si.Description}");
                mainEditor.CaretVisible = false;
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                e.Handled = true;

                switch (e.KeyCode)
                {
                    default:
                        e.Handled = false;
                        break;

                    case Keys.U:
                        mainEditor.Undo();
                        break;

                    case Keys.Y:
                        mainEditor.Redo();
                        break;

                    case Keys.C:
                        mainEditor.Copy();
                        break;

                    case Keys.X:
                        mainEditor.Cut();
                        break;

                    case Keys.V:
                        mainEditor.Paste();
                        break;

                    case Keys.A:
                        mainEditor.SelectAll();
                        break;

                    case Keys.F:
                        mainEditor.ShowFindDialog();
                        break;

                    case Keys.R:
                        mainEditor.ShowReplaceDialog();
                        break;

                    case Keys.S:
                        this.TryToSave();
                        break;
                }
            }
        }

        private void TryToSave()
        {
            if (string.IsNullOrEmpty(this.CurrentFileName))
                this.OpenSaveFileDialog();
            else
            {
                mainEditor.SaveToFile(this.CurrentFileName, Encoding.UTF8);
                this.ChangesPending = false;
                this.Text = $"MoonScript Editor - {this.CurrentFileName}";
            }
        }

        private void OpenSaveFileDialog()
        {
            var dialog = new SaveFileDialog() { Filter = "MoonScript Files (*.ms)|*.ds;*.ms" };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = dialog.FileName;

                if (string.IsNullOrWhiteSpace(fileName))
                    return;

                mainEditor.SaveToFile(fileName, Encoding.UTF8);
            }
        }

        private void OpenFileDialog()
        {
            if (this.ChangesPending)
            {
                var pending_message = MessageBox.Show(
                    "Current file has not been saved.\nDo you want to save it before opening another file?",
                    "Confirmation",
                    MessageBoxButtons.YesNoCancel);

                switch (pending_message)
                {
                    case DialogResult.Yes:
                        this.TryToSave();
                        break;

                    case DialogResult.Cancel:
                        return;
                }
            }

            var dialog = new OpenFileDialog() { Filter = "MoonScript Files (*.ms)|*.ds;*.ms" };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = dialog.FileName;

                if (string.IsNullOrWhiteSpace(fileName))
                    return;

                this.ChangesPending = false;
                this.ListenForChanges = false;
                this.Text = $"MoonScript Editor - {fileName}";
                mainEditor.Clear();
                mainEditor.Text = File.ReadAllText(fileName);
                this.CurrentFileName = fileName;
                this.ListenForChanges = true;
            }
        }

        private void DrawTriggerListViewItem(object lvSender, DrawListViewItemEventArgs lvEvent)
        {
            lvEvent.Graphics.FillRectangle(Brushes.White, lvEvent.Bounds);
            if ((lvEvent.State & ListViewItemStates.Selected) != 0)
                lvEvent.DrawFocusRectangle();

            var item = (lvEvent.Item as TriggerViewItem);
            var category = item.Category;
            var id = item.Id;
            var description = item.Description;
            var hints = item.Hints;

            string ReplaceFirst(string text, string search, string replace)
            {
                var pos = text.IndexOf(search);
                return pos < 0 ? text : text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
            }

            var highlights = new List<(int index, int range)>();

            foreach (var hint in hints)
            {
                var string_index = description.IndexOf("{...}");
                var variable_index = description.IndexOf("#");

                var variable_comparisons = new[] { string_index }.Where(t => t != -1);
                var string_comparisons = new[] { variable_index }.Where(t => t != -1);

                if (string_index != -1 && (!string_comparisons.Any() || string_index < string_comparisons.Min()))
                {
                    description = ReplaceFirst(description, "{...}", hint);
                    highlights.Add((string_index, hint.Length));
                }

                if (variable_index != -1 && (!variable_comparisons.Any() || variable_index < variable_comparisons.Min()))
                {
                    description = ReplaceFirst(description, "#", $" {hint} ");
                    highlights.Add((variable_index, $" {hint} ".Length));
                }
            }

            var location = new PointF(lvEvent.Bounds.Location.X, lvEvent.Bounds.Location.Y);

            using (var font = new Font("Arial", 9f, FontStyle.Regular))
            {
                var trigger_text = $" ({category}:{id})    ";
                var color = Color.FromArgb(0, 196, 132);

                for (var i = 0; i < trigger_text.Length; i++)
                {
                    var text = trigger_text[i].ToString();
                    var size = TextRenderer.MeasureText(text, font);

                    TextRenderer.DrawText(lvEvent.Graphics, text, font, new Point((int)location.X, (int)location.Y), color);
                    location.X += size.Width - 7.5f;
                }
            }

            using (var font = new Font("Tahoma", 8f, FontStyle.Regular))
            {
                for (var i = 0; i < description.Length; i++)
                {
                    var text = description[i].ToString();
                    var size = TextRenderer.MeasureText(text, font);
                    var color = highlights.Any(t => i >= t.index && i < t.index + t.range) ? Color.FromArgb(47, 139, 212) : Color.Black;

                    TextRenderer.DrawText(lvEvent.Graphics, text, font, new Point((int)location.X, (int)location.Y), color);
                    location.X += size.Width - 7;
                }
            }

            location.Y += 17;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
            => mainEditor.Undo();

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
            => mainEditor.Redo();

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
            => mainEditor.Copy();

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
            => mainEditor.Cut();

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
            => mainEditor.Paste();

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
            => mainEditor.SelectAll();

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
            => mainEditor.ShowFindDialog();

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
            => mainEditor.ShowReplaceDialog();

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
            => this.OpenSaveFileDialog();

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            => this.TryToSave();

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
            => this.OpenFileDialog();

        private void aboutMoonScriptEditorToolStripMenuItem_Click(object sender, EventArgs e)
            => this.AboutDialog.ShowDialog();

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ChangesPending)
            {
                var pending_message = MessageBox.Show(
                    "Current file has not been saved.\nDo you want to save it before opening another file?",
                    "Confirmation",
                    MessageBoxButtons.YesNoCancel);

                switch (pending_message)
                {
                    case DialogResult.Yes:
                        this.TryToSave();
                        break;

                    case DialogResult.Cancel:
                        return;
                }
            }

            this.CurrentFileName = "";
            this.ListenForChanges = false;
            this.ChangesPending = false;
            this.Text = this.DefaultTitle;
            mainEditor.Clear();
            mainEditor.InsertText(this.DefaultText);
            mainEditor.Selection.Start = new Place(mainEditor.Lines[1].Length, 1);
            mainEditor.CaretVisible = true;
            mainEditor.Focus();
            this.ListenForChanges = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ChangesPending)
            {
                var pending_message = MessageBox.Show(
                    "Current file has not been saved.\nDo you want to save it before closing?",
                    "Confirmation",
                    MessageBoxButtons.YesNoCancel);

                switch (pending_message)
                {
                    case DialogResult.Yes:
                        this.TryToSave();
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                }
            }
        }
    }
}