namespace Lab_12_JRL
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.LblInfo = new System.Windows.Forms.Label();
            this.LblAllEmp = new System.Windows.Forms.Label();
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtLName = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblLName = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblSearch = new System.Windows.Forms.Label();
            this.ListAllEmp = new System.Windows.Forms.ListView();
            this.ClmHdrID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmHdrFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmHdrLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmHdrType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmHdrOvertime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmHdrComm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmHdrBfts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmHdrEduBfts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MnuAdmin = new System.Windows.Forms.MenuStrip();
            this.MnuTest = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTestSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.PBxAddEmp = new System.Windows.Forms.PictureBox();
            this.PBxArt1 = new System.Windows.Forms.PictureBox();
            this.PnlSearch.SuspendLayout();
            this.MnuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAddEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxArt1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(276, 99);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(278, 25);
            this.LblInfo.TabIndex = 21;
            this.LblInfo.Text = "Double-click an employee...";
            // 
            // LblAllEmp
            // 
            this.LblAllEmp.AutoSize = true;
            this.LblAllEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAllEmp.Location = new System.Drawing.Point(534, 51);
            this.LblAllEmp.Name = "LblAllEmp";
            this.LblAllEmp.Size = new System.Drawing.Size(458, 61);
            this.LblAllEmp.TabIndex = 18;
            this.LblAllEmp.Text = "ALL EMPLOYEES";
            // 
            // PnlSearch
            // 
            this.PnlSearch.BackColor = System.Drawing.Color.White;
            this.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlSearch.Controls.Add(this.BtnClear);
            this.PnlSearch.Controls.Add(this.BtnSearch);
            this.PnlSearch.Controls.Add(this.TxtLName);
            this.PnlSearch.Controls.Add(this.TxtID);
            this.PnlSearch.Controls.Add(this.LblLName);
            this.PnlSearch.Controls.Add(this.LblID);
            this.PnlSearch.Controls.Add(this.LblSearch);
            this.PnlSearch.Location = new System.Drawing.Point(10, 295);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Size = new System.Drawing.Size(255, 424);
            this.PnlSearch.TabIndex = 17;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(76, 355);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(104, 36);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(67, 288);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(122, 40);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtLName
            // 
            this.TxtLName.Location = new System.Drawing.Point(33, 218);
            this.TxtLName.Name = "TxtLName";
            this.TxtLName.Size = new System.Drawing.Size(191, 30);
            this.TxtLName.TabIndex = 2;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(33, 120);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(191, 30);
            this.TxtID.TabIndex = 1;
            // 
            // LblLName
            // 
            this.LblLName.AutoSize = true;
            this.LblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLName.Location = new System.Drawing.Point(29, 183);
            this.LblLName.Name = "LblLName";
            this.LblLName.Size = new System.Drawing.Size(159, 32);
            this.LblLName.TabIndex = 3;
            this.LblLName.Text = "Last Name:";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(29, 85);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(50, 32);
            this.LblID.TabIndex = 2;
            this.LblID.Text = "ID:";
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(70, 20);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(146, 44);
            this.LblSearch.TabIndex = 0;
            this.LblSearch.Text = "Search";
            // 
            // ListAllEmp
            // 
            this.ListAllEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListAllEmp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmHdrID,
            this.ClmHdrFName,
            this.ClmHdrLName,
            this.ClmHdrType,
            this.ClmHdrOvertime,
            this.ClmHdrComm,
            this.ClmHdrBfts,
            this.ClmHdrEduBfts});
            this.ListAllEmp.FullRowSelect = true;
            this.ListAllEmp.GridLines = true;
            this.ListAllEmp.HideSelection = false;
            this.ListAllEmp.Location = new System.Drawing.Point(274, 133);
            this.ListAllEmp.Name = "ListAllEmp";
            this.ListAllEmp.Size = new System.Drawing.Size(990, 586);
            this.ListAllEmp.TabIndex = 16;
            this.ListAllEmp.UseCompatibleStateImageBehavior = false;
            this.ListAllEmp.View = System.Windows.Forms.View.Details;
            this.ListAllEmp.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListAllEmp_ColumnClick);
            this.ListAllEmp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListAllEmp_MouseDoubleClick);
            // 
            // ClmHdrID
            // 
            this.ClmHdrID.Text = "ID";
            this.ClmHdrID.Width = 86;
            // 
            // ClmHdrFName
            // 
            this.ClmHdrFName.Text = "First Name";
            this.ClmHdrFName.Width = 142;
            // 
            // ClmHdrLName
            // 
            this.ClmHdrLName.Text = "Last Name";
            this.ClmHdrLName.Width = 136;
            // 
            // ClmHdrType
            // 
            this.ClmHdrType.Text = "Type";
            this.ClmHdrType.Width = 107;
            // 
            // ClmHdrOvertime
            // 
            this.ClmHdrOvertime.Text = "Overtime";
            this.ClmHdrOvertime.Width = 98;
            // 
            // ClmHdrComm
            // 
            this.ClmHdrComm.Text = "Commission";
            this.ClmHdrComm.Width = 125;
            // 
            // ClmHdrBfts
            // 
            this.ClmHdrBfts.Text = "Benefits";
            this.ClmHdrBfts.Width = 108;
            // 
            // ClmHdrEduBfts
            // 
            this.ClmHdrEduBfts.Text = "Education Benefits";
            this.ClmHdrEduBfts.Width = 183;
            // 
            // MnuAdmin
            // 
            this.MnuAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuTest});
            this.MnuAdmin.Location = new System.Drawing.Point(0, 0);
            this.MnuAdmin.Name = "MnuAdmin";
            this.MnuAdmin.Size = new System.Drawing.Size(1275, 28);
            this.MnuAdmin.TabIndex = 19;
            this.MnuAdmin.Visible = false;
            // 
            // MnuTest
            // 
            this.MnuTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuTestSearch});
            this.MnuTest.Name = "MnuTest";
            this.MnuTest.Size = new System.Drawing.Size(47, 24);
            this.MnuTest.Text = "Test";
            // 
            // MnuTestSearch
            // 
            this.MnuTestSearch.Name = "MnuTestSearch";
            this.MnuTestSearch.Size = new System.Drawing.Size(158, 26);
            this.MnuTestSearch.Text = "Test Search";
            this.MnuTestSearch.Click += new System.EventHandler(this.MnuTestSearch_Click);
            // 
            // PBxAddEmp
            // 
            this.PBxAddEmp.BackgroundImage = global::Lab_12_JRL.Properties.Resources.addemp;
            this.PBxAddEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBxAddEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBxAddEmp.Location = new System.Drawing.Point(1139, 53);
            this.PBxAddEmp.Name = "PBxAddEmp";
            this.PBxAddEmp.Size = new System.Drawing.Size(125, 50);
            this.PBxAddEmp.TabIndex = 20;
            this.PBxAddEmp.TabStop = false;
            this.PBxAddEmp.Click += new System.EventHandler(this.PBxAddEmp_Click);
            // 
            // PBxArt1
            // 
            this.PBxArt1.BackgroundImage = global::Lab_12_JRL.Properties.Resources.www;
            this.PBxArt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBxArt1.Location = new System.Drawing.Point(55, 23);
            this.PBxArt1.Name = "PBxArt1";
            this.PBxArt1.Size = new System.Drawing.Size(161, 248);
            this.PBxArt1.TabIndex = 5;
            this.PBxArt1.TabStop = false;
            // 
            // FrmAdmin
            // 
            this.AcceptButton = this.BtnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1275, 739);
            this.Controls.Add(this.PBxArt1);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.PBxAddEmp);
            this.Controls.Add(this.LblAllEmp);
            this.Controls.Add(this.PnlSearch);
            this.Controls.Add(this.ListAllEmp);
            this.Controls.Add(this.MnuAdmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuAdmin;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListAllEmp_MouseDoubleClick);
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            this.MnuAdmin.ResumeLayout(false);
            this.MnuAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAddEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxArt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.PictureBox PBxAddEmp;
        private System.Windows.Forms.Label LblAllEmp;
        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtLName;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblLName;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.ColumnHeader ClmHdrID;
        private System.Windows.Forms.ColumnHeader ClmHdrFName;
        private System.Windows.Forms.ColumnHeader ClmHdrLName;
        private System.Windows.Forms.ColumnHeader ClmHdrType;
        private System.Windows.Forms.ColumnHeader ClmHdrOvertime;
        private System.Windows.Forms.ColumnHeader ClmHdrComm;
        private System.Windows.Forms.ColumnHeader ClmHdrBfts;
        private System.Windows.Forms.ColumnHeader ClmHdrEduBfts;
        private System.Windows.Forms.MenuStrip MnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem MnuTest;
        private System.Windows.Forms.ToolStripMenuItem MnuTestSearch;
        public System.Windows.Forms.ListView ListAllEmp;
        private System.Windows.Forms.PictureBox PBxArt1;
    }
}