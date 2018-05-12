namespace Lab_12_JRL
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTest = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTestBenefits = new System.Windows.Forms.ToolStripMenuItem();
            this.PBxArt2 = new System.Windows.Forms.PictureBox();
            this.PBxArt1 = new System.Windows.Forms.PictureBox();
            this.PBxAdmin = new System.Windows.Forms.PictureBox();
            this.PBxEmpPort = new System.Windows.Forms.PictureBox();
            this.MnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxArt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxArt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxEmpPort)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuMain
            // 
            this.MnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile,
            this.MnuTest});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Padding = new System.Windows.Forms.Padding(18, 7, 0, 7);
            this.MnuMain.Size = new System.Drawing.Size(1556, 38);
            this.MnuMain.TabIndex = 25;
            // 
            // MnuFile
            // 
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuOpen,
            this.MnuSave,
            this.MnuAbout,
            this.MnuExit});
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(44, 24);
            this.MnuFile.Text = "File";
            // 
            // MnuOpen
            // 
            this.MnuOpen.Name = "MnuOpen";
            this.MnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.MnuOpen.Size = new System.Drawing.Size(217, 26);
            this.MnuOpen.Text = "Open";
            this.MnuOpen.Click += new System.EventHandler(this.MnuOpen_Click);
            // 
            // MnuSave
            // 
            this.MnuSave.Name = "MnuSave";
            this.MnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MnuSave.Size = new System.Drawing.Size(217, 26);
            this.MnuSave.Text = "Save";
            this.MnuSave.Click += new System.EventHandler(this.MnuSave_Click);
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.MnuAbout.Size = new System.Drawing.Size(217, 26);
            this.MnuAbout.Text = "About";
            this.MnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.MnuExit.Size = new System.Drawing.Size(217, 26);
            this.MnuExit.Text = "Exit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // MnuTest
            // 
            this.MnuTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuTestBenefits});
            this.MnuTest.Name = "MnuTest";
            this.MnuTest.Size = new System.Drawing.Size(47, 24);
            this.MnuTest.Text = "Test";
            this.MnuTest.Visible = false;
            // 
            // MnuTestBenefits
            // 
            this.MnuTestBenefits.Name = "MnuTestBenefits";
            this.MnuTestBenefits.Size = new System.Drawing.Size(205, 26);
            this.MnuTestBenefits.Text = "Test Benefits Form";
            this.MnuTestBenefits.Click += new System.EventHandler(this.MnuTestBenefits_Click);
            // 
            // PBxArt2
            // 
            this.PBxArt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBxArt2.BackgroundImage = global::Lab_12_JRL.Properties.Resources.www;
            this.PBxArt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBxArt2.Location = new System.Drawing.Point(1291, 95);
            this.PBxArt2.Name = "PBxArt2";
            this.PBxArt2.Size = new System.Drawing.Size(187, 300);
            this.PBxArt2.TabIndex = 29;
            this.PBxArt2.TabStop = false;
            // 
            // PBxArt1
            // 
            this.PBxArt1.BackgroundImage = global::Lab_12_JRL.Properties.Resources.www;
            this.PBxArt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBxArt1.Location = new System.Drawing.Point(79, 95);
            this.PBxArt1.Name = "PBxArt1";
            this.PBxArt1.Size = new System.Drawing.Size(187, 300);
            this.PBxArt1.TabIndex = 28;
            this.PBxArt1.TabStop = false;
            // 
            // PBxAdmin
            // 
            this.PBxAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBxAdmin.BackgroundImage = global::Lab_12_JRL.Properties.Resources.admin;
            this.PBxAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBxAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBxAdmin.Location = new System.Drawing.Point(348, 134);
            this.PBxAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.PBxAdmin.Name = "PBxAdmin";
            this.PBxAdmin.Size = new System.Drawing.Size(857, 215);
            this.PBxAdmin.TabIndex = 27;
            this.PBxAdmin.TabStop = false;
            this.PBxAdmin.Click += new System.EventHandler(this.PBxAdmin_Click);
            // 
            // PBxEmpPort
            // 
            this.PBxEmpPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBxEmpPort.BackgroundImage = global::Lab_12_JRL.Properties.Resources.portal;
            this.PBxEmpPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBxEmpPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBxEmpPort.Location = new System.Drawing.Point(348, 450);
            this.PBxEmpPort.Margin = new System.Windows.Forms.Padding(5);
            this.PBxEmpPort.Name = "PBxEmpPort";
            this.PBxEmpPort.Size = new System.Drawing.Size(857, 215);
            this.PBxEmpPort.TabIndex = 26;
            this.PBxEmpPort.TabStop = false;
            this.PBxEmpPort.Click += new System.EventHandler(this.PBxEmpPort_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1556, 1146);
            this.Controls.Add(this.PBxArt2);
            this.Controls.Add(this.PBxArt1);
            this.Controls.Add(this.PBxAdmin);
            this.Controls.Add(this.PBxEmpPort);
            this.Controls.Add(this.MnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuMain;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMain";
            this.Text = "World-Wide Wombats: Employee Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxArt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxArt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxEmpPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBxArt2;
        private System.Windows.Forms.PictureBox PBxArt1;
        private System.Windows.Forms.PictureBox PBxAdmin;
        private System.Windows.Forms.PictureBox PBxEmpPort;
        private System.Windows.Forms.MenuStrip MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MnuFile;
        private System.Windows.Forms.ToolStripMenuItem MnuOpen;
        private System.Windows.Forms.ToolStripMenuItem MnuSave;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem MnuTest;
        private System.Windows.Forms.ToolStripMenuItem MnuTestBenefits;
    }
}

