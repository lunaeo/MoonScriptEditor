using System.Windows.Forms;

namespace MoonScriptEditor
{
    public class TriggerViewItem : ListViewItem
    {
        public int Category { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string[] Hints { get; set; }
    }
}