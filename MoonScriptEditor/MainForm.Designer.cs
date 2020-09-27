namespace MoonScriptEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMoonScriptEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsStatusLineCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabTriggers = new System.Windows.Forms.TabControl();
            this.tabCauses = new System.Windows.Forms.TabPage();
            this.tabAdditionalConditions = new System.Windows.Forms.TabPage();
            this.tabAreas = new System.Windows.Forms.TabPage();
            this.tabFilters = new System.Windows.Forms.TabPage();
            this.tabEffects = new System.Windows.Forms.TabPage();
            this.tsStatusLineColumn = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.lvCauses = new MoonScriptEditor.ListViewWithoutHorizontalScrollBar();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAdditionalConditions = new MoonScriptEditor.ListViewWithoutHorizontalScrollBar();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAreas = new MoonScriptEditor.ListViewWithoutHorizontalScrollBar();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFilters = new MoonScriptEditor.ListViewWithoutHorizontalScrollBar();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEffects = new MoonScriptEditor.ListViewWithoutHorizontalScrollBar();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabTriggers.SuspendLayout();
            this.tabCauses.SuspendLayout();
            this.tabAdditionalConditions.SuspendLayout();
            this.tabAreas.SuspendLayout();
            this.tabFilters.SuspendLayout();
            this.tabEffects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(764, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator2,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Enabled = false;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Enabled = false;
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMoonScriptEditorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMoonScriptEditorToolStripMenuItem
            // 
            this.aboutMoonScriptEditorToolStripMenuItem.Name = "aboutMoonScriptEditorToolStripMenuItem";
            this.aboutMoonScriptEditorToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutMoonScriptEditorToolStripMenuItem.Text = "About...";
            this.aboutMoonScriptEditorToolStripMenuItem.Click += new System.EventHandler(this.aboutMoonScriptEditorToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLineColumn,
            this.tsStatusLineCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 464);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(764, 22);
            this.statusStrip.TabIndex = 1;
            // 
            // tsStatusLineCount
            // 
            this.tsStatusLineCount.Name = "tsStatusLineCount";
            this.tsStatusLineCount.Size = new System.Drawing.Size(93, 17);
            this.tsStatusLineCount.Text = "0 lines displayed";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.splitContainer1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(764, 440);
            this.mainPanel.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainEditor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabTriggers);
            this.splitContainer1.Size = new System.Drawing.Size(764, 440);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabTriggers
            // 
            this.tabTriggers.Controls.Add(this.tabCauses);
            this.tabTriggers.Controls.Add(this.tabAdditionalConditions);
            this.tabTriggers.Controls.Add(this.tabAreas);
            this.tabTriggers.Controls.Add(this.tabFilters);
            this.tabTriggers.Controls.Add(this.tabEffects);
            this.tabTriggers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTriggers.Location = new System.Drawing.Point(0, 0);
            this.tabTriggers.Name = "tabTriggers";
            this.tabTriggers.SelectedIndex = 0;
            this.tabTriggers.Size = new System.Drawing.Size(764, 171);
            this.tabTriggers.TabIndex = 0;
            // 
            // tabCauses
            // 
            this.tabCauses.Controls.Add(this.lvCauses);
            this.tabCauses.Location = new System.Drawing.Point(4, 22);
            this.tabCauses.Name = "tabCauses";
            this.tabCauses.Padding = new System.Windows.Forms.Padding(3);
            this.tabCauses.Size = new System.Drawing.Size(756, 145);
            this.tabCauses.TabIndex = 0;
            this.tabCauses.Text = "Causes";
            this.tabCauses.UseVisualStyleBackColor = true;
            // 
            // tabAdditionalConditions
            // 
            this.tabAdditionalConditions.Controls.Add(this.lvAdditionalConditions);
            this.tabAdditionalConditions.Location = new System.Drawing.Point(4, 22);
            this.tabAdditionalConditions.Name = "tabAdditionalConditions";
            this.tabAdditionalConditions.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdditionalConditions.Size = new System.Drawing.Size(756, 145);
            this.tabAdditionalConditions.TabIndex = 1;
            this.tabAdditionalConditions.Text = "Additional Conditions";
            this.tabAdditionalConditions.UseVisualStyleBackColor = true;
            // 
            // tabAreas
            // 
            this.tabAreas.Controls.Add(this.lvAreas);
            this.tabAreas.Location = new System.Drawing.Point(4, 22);
            this.tabAreas.Name = "tabAreas";
            this.tabAreas.Size = new System.Drawing.Size(756, 145);
            this.tabAreas.TabIndex = 2;
            this.tabAreas.Text = "Areas";
            this.tabAreas.UseVisualStyleBackColor = true;
            // 
            // tabFilters
            // 
            this.tabFilters.Controls.Add(this.lvFilters);
            this.tabFilters.Location = new System.Drawing.Point(4, 22);
            this.tabFilters.Name = "tabFilters";
            this.tabFilters.Size = new System.Drawing.Size(756, 145);
            this.tabFilters.TabIndex = 3;
            this.tabFilters.Text = "Filters";
            this.tabFilters.UseVisualStyleBackColor = true;
            // 
            // tabEffects
            // 
            this.tabEffects.Controls.Add(this.lvEffects);
            this.tabEffects.Location = new System.Drawing.Point(4, 22);
            this.tabEffects.Name = "tabEffects";
            this.tabEffects.Size = new System.Drawing.Size(756, 145);
            this.tabEffects.TabIndex = 4;
            this.tabEffects.Text = "Effects";
            this.tabEffects.UseVisualStyleBackColor = true;
            // 
            // tsStatusLineColumn
            // 
            this.tsStatusLineColumn.Name = "tsStatusLineColumn";
            this.tsStatusLineColumn.Size = new System.Drawing.Size(22, 17);
            this.tsStatusLineColumn.Text = "0:0";
            // 
            // mainEditor
            // 
            this.mainEditor.AllowMacroRecording = false;
            this.mainEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.mainEditor.AutoIndent = false;
            this.mainEditor.AutoIndentChars = false;
            this.mainEditor.AutoIndentExistingLines = false;
            this.mainEditor.AutoScrollMinSize = new System.Drawing.Size(219, 168);
            this.mainEditor.BackBrush = null;
            this.mainEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainEditor.CharHeight = 14;
            this.mainEditor.CharWidth = 8;
            this.mainEditor.CommentPrefix = "*";
            this.mainEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mainEditor.DescriptionFile = "C:\\Users\\atilla\\Desktop\\Projects\\local\\MoonScriptEditor\\MoonScriptEditor\\config\\s" +
    "yntax.xml";
            this.mainEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.mainEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainEditor.FindEndOfFoldingBlockStrategy = FastColoredTextBoxNS.FindEndOfFoldingBlockStrategy.Strategy2;
            this.mainEditor.IsReplaceMode = false;
            this.mainEditor.Location = new System.Drawing.Point(0, 0);
            this.mainEditor.Name = "mainEditor";
            this.mainEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.mainEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.mainEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("mainEditor.ServiceColors")));
            this.mainEditor.Size = new System.Drawing.Size(764, 265);
            this.mainEditor.TabIndex = 0;
            this.mainEditor.Text = "* New MoonScript Script\r\n* Created by \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.mainEditor.WordWrapAutoIndent = false;
            this.mainEditor.Zoom = 100;
            // 
            // lvCauses
            // 
            this.lvCauses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader});
            this.lvCauses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCauses.FullRowSelect = true;
            this.lvCauses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvCauses.HideSelection = false;
            this.lvCauses.LabelWrap = false;
            this.lvCauses.Location = new System.Drawing.Point(3, 3);
            this.lvCauses.MultiSelect = false;
            this.lvCauses.Name = "lvCauses";
            this.lvCauses.ShowGroups = false;
            this.lvCauses.Size = new System.Drawing.Size(750, 139);
            this.lvCauses.TabIndex = 0;
            this.lvCauses.UseCompatibleStateImageBehavior = false;
            this.lvCauses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader
            // 
            this.columnHeader.Width = 730;
            // 
            // lvAdditionalConditions
            // 
            this.lvAdditionalConditions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAdditionalConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAdditionalConditions.FullRowSelect = true;
            this.lvAdditionalConditions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvAdditionalConditions.HideSelection = false;
            this.lvAdditionalConditions.LabelWrap = false;
            this.lvAdditionalConditions.Location = new System.Drawing.Point(3, 3);
            this.lvAdditionalConditions.MultiSelect = false;
            this.lvAdditionalConditions.Name = "lvAdditionalConditions";
            this.lvAdditionalConditions.ShowGroups = false;
            this.lvAdditionalConditions.Size = new System.Drawing.Size(750, 139);
            this.lvAdditionalConditions.TabIndex = 1;
            this.lvAdditionalConditions.UseCompatibleStateImageBehavior = false;
            this.lvAdditionalConditions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 730;
            // 
            // lvAreas
            // 
            this.lvAreas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvAreas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAreas.FullRowSelect = true;
            this.lvAreas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvAreas.HideSelection = false;
            this.lvAreas.LabelWrap = false;
            this.lvAreas.Location = new System.Drawing.Point(0, 0);
            this.lvAreas.MultiSelect = false;
            this.lvAreas.Name = "lvAreas";
            this.lvAreas.ShowGroups = false;
            this.lvAreas.Size = new System.Drawing.Size(756, 145);
            this.lvAreas.TabIndex = 1;
            this.lvAreas.UseCompatibleStateImageBehavior = false;
            this.lvAreas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 730;
            // 
            // lvFilters
            // 
            this.lvFilters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lvFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFilters.FullRowSelect = true;
            this.lvFilters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvFilters.HideSelection = false;
            this.lvFilters.LabelWrap = false;
            this.lvFilters.Location = new System.Drawing.Point(0, 0);
            this.lvFilters.MultiSelect = false;
            this.lvFilters.Name = "lvFilters";
            this.lvFilters.ShowGroups = false;
            this.lvFilters.Size = new System.Drawing.Size(756, 145);
            this.lvFilters.TabIndex = 1;
            this.lvFilters.UseCompatibleStateImageBehavior = false;
            this.lvFilters.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 730;
            // 
            // lvEffects
            // 
            this.lvEffects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.lvEffects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEffects.FullRowSelect = true;
            this.lvEffects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvEffects.HideSelection = false;
            this.lvEffects.LabelWrap = false;
            this.lvEffects.Location = new System.Drawing.Point(0, 0);
            this.lvEffects.MultiSelect = false;
            this.lvEffects.Name = "lvEffects";
            this.lvEffects.ShowGroups = false;
            this.lvEffects.Size = new System.Drawing.Size(756, 145);
            this.lvEffects.TabIndex = 1;
            this.lvEffects.UseCompatibleStateImageBehavior = false;
            this.lvEffects.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 730;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 486);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(256, 164);
            this.Name = "MainForm";
            this.Text = "MoonScript Editor - [new file] ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabTriggers.ResumeLayout(false);
            this.tabCauses.ResumeLayout(false);
            this.tabAdditionalConditions.ResumeLayout(false);
            this.tabAreas.ResumeLayout(false);
            this.tabFilters.ResumeLayout(false);
            this.tabEffects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FastColoredTextBoxNS.FastColoredTextBox mainEditor;
        private System.Windows.Forms.TabControl tabTriggers;
        private System.Windows.Forms.TabPage tabCauses;
        private ListViewWithoutHorizontalScrollBar lvCauses;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.TabPage tabAdditionalConditions;
        private System.Windows.Forms.TabPage tabAreas;
        private System.Windows.Forms.TabPage tabFilters;
        private System.Windows.Forms.TabPage tabEffects;
        private ListViewWithoutHorizontalScrollBar lvAdditionalConditions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private ListViewWithoutHorizontalScrollBar lvAreas;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private ListViewWithoutHorizontalScrollBar lvFilters;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private ListViewWithoutHorizontalScrollBar lvEffects;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMoonScriptEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLineCount;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLineColumn;
    }
}

