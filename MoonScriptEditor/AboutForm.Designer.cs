namespace MoonScriptEditor
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBoxAboutIcon = new System.Windows.Forms.PictureBox();
            this.aboutLink = new System.Windows.Forms.LinkLabel();
            this.labelAboutSubHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAboutIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAboutIcon
            // 
            this.pictureBoxAboutIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAboutIcon.BackgroundImage = global::MoonScriptEditor.Properties.Resources.LunaIconScript;
            this.pictureBoxAboutIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAboutIcon.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAboutIcon.Name = "pictureBoxAboutIcon";
            this.pictureBoxAboutIcon.Size = new System.Drawing.Size(515, 249);
            this.pictureBoxAboutIcon.TabIndex = 0;
            this.pictureBoxAboutIcon.TabStop = false;
            this.pictureBoxAboutIcon.Click += new System.EventHandler(this.pictureBoxAboutIcon_Click);
            // 
            // aboutLink
            // 
            this.aboutLink.AutoSize = true;
            this.aboutLink.LinkColor = System.Drawing.Color.MediumSeaGreen;
            this.aboutLink.Location = new System.Drawing.Point(154, 280);
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.Size = new System.Drawing.Size(225, 13);
            this.aboutLink.TabIndex = 1;
            this.aboutLink.TabStop = true;
            this.aboutLink.Text = "https://github.com/LunaEO/MoonScriptEditor";
            this.aboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLink_LinkClicked);
            // 
            // labelAboutSubHeader
            // 
            this.labelAboutSubHeader.AutoSize = true;
            this.labelAboutSubHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelAboutSubHeader.Location = new System.Drawing.Point(236, 302);
            this.labelAboutSubHeader.Name = "labelAboutSubHeader";
            this.labelAboutSubHeader.Size = new System.Drawing.Size(81, 13);
            this.labelAboutSubHeader.TabIndex = 2;
            this.labelAboutSubHeader.Text = "BunnySnuggles";
            this.labelAboutSubHeader.Click += new System.EventHandler(this.labelAboutSubHeader_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(539, 327);
            this.ControlBox = false;
            this.Controls.Add(this.labelAboutSubHeader);
            this.Controls.Add(this.aboutLink);
            this.Controls.Add(this.pictureBoxAboutIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "                                 About MoonScript Editor (click to close)";
            this.TopMost = true;
            this.Click += new System.EventHandler(this.AboutForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAboutIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAboutIcon;
        private System.Windows.Forms.LinkLabel aboutLink;
        private System.Windows.Forms.Label labelAboutSubHeader;
    }
}