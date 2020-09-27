using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MoonScriptEditor
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void aboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(aboutLink.Text);
        }

        private void pictureBoxAboutIcon_Click(object sender, EventArgs e) => 
            this.Close();

        private void AboutForm_Click(object sender, EventArgs e) => 
            this.Close();

        private void labelAboutSubHeader_Click(object sender, EventArgs e) => 
            this.Close();
    }
}
