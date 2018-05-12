namespace Lab_12_JRL
{
    partial class FrmEmp_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmp_Login));
            this.TxtLName = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblID = new System.Windows.Forms.Label();
            this.LblLName = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.MnuLogin = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTestLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtLName
            // 
            this.TxtLName.Location = new System.Drawing.Point(107, 266);
            this.TxtLName.Name = "TxtLName";
            this.TxtLName.Size = new System.Drawing.Size(212, 30);
            this.TxtLName.TabIndex = 1;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(108, 156);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(212, 30);
            this.TxtID.TabIndex = 0;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(12, 344);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(117, 37);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(294, 344);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(117, 37);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(102, 109);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(157, 29);
            this.LblID.TabIndex = 10;
            this.LblID.Text = "Employee ID:";
            // 
            // LblLName
            // 
            this.LblLName.AutoSize = true;
            this.LblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLName.Location = new System.Drawing.Point(102, 218);
            this.LblLName.Name = "LblLName";
            this.LblLName.Size = new System.Drawing.Size(134, 29);
            this.LblLName.TabIndex = 9;
            this.LblLName.Text = "Last Name:";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(35, 48);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(94, 32);
            this.LblLogin.TabIndex = 8;
            this.LblLogin.Text = "Login:";
            // 
            // MnuLogin
            // 
            this.MnuLogin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.MnuLogin.Location = new System.Drawing.Point(0, 0);
            this.MnuLogin.Name = "MnuLogin";
            this.MnuLogin.Size = new System.Drawing.Size(423, 28);
            this.MnuLogin.TabIndex = 15;
            this.MnuLogin.Visible = false;
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuTestLogin});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // MnuTestLogin
            // 
            this.MnuTestLogin.Name = "MnuTestLogin";
            this.MnuTestLogin.Size = new System.Drawing.Size(276, 26);
            this.MnuTestLogin.Text = "Login with known credentials";
            this.MnuTestLogin.Click += new System.EventHandler(this.MnuTestLogin_Click);
            // 
            // FrmEmp_Login
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 395);
            this.Controls.Add(this.TxtLName);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblLName);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.MnuLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuLogin;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmp_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Login";
            this.Deactivate += new System.EventHandler(this.FrmEmp_Login_Deactivate);
            this.MnuLogin.ResumeLayout(false);
            this.MnuLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLName;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblLName;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.MenuStrip MnuLogin;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuTestLogin;
    }
}