namespace Lab_12_JRL
{
    partial class FrmAdd_Emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdd_Emp));
            this.GBxTypeDetails = new System.Windows.Forms.GroupBox();
            this.LblAgency = new System.Windows.Forms.Label();
            this.LblHourlyRate = new System.Windows.Forms.Label();
            this.TxtAgency = new System.Windows.Forms.TextBox();
            this.LblMonthlySalary = new System.Windows.Forms.Label();
            this.LblCommissionRate = new System.Windows.Forms.Label();
            this.TxtHourlyRate = new System.Windows.Forms.TextBox();
            this.TxtMonthlySalary = new System.Windows.Forms.TextBox();
            this.TxtCommissionRate = new System.Windows.Forms.TextBox();
            this.LblContractWage = new System.Windows.Forms.Label();
            this.TxtContractWage = new System.Windows.Forms.TextBox();
            this.GBxEmpDetails = new System.Windows.Forms.GroupBox();
            this.CBxFPTime = new System.Windows.Forms.ComboBox();
            this.CBxMarital = new System.Windows.Forms.ComboBox();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.CldrStartDate = new System.Windows.Forms.MonthCalendar();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.TxtDepartment = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblMarital = new System.Windows.Forms.Label();
            this.LblFPTime = new System.Windows.Forms.Label();
            this.LblMiddle = new System.Windows.Forms.Label();
            this.TxtMiddle = new System.Windows.Forms.TextBox();
            this.PBxEmpIDState = new System.Windows.Forms.PictureBox();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.GBxEmpType = new System.Windows.Forms.GroupBox();
            this.RBtnContract = new System.Windows.Forms.RadioButton();
            this.RBtnSales = new System.Windows.Forms.RadioButton();
            this.RBtnSalary = new System.Windows.Forms.RadioButton();
            this.RBtnHourly = new System.Windows.Forms.RadioButton();
            this.MnuAddEmp = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEmptyEmpField = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEmptyTypeField = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUnavailableEmpID = new System.Windows.Forms.ToolStripMenuItem();
            this.PBxArt1 = new System.Windows.Forms.PictureBox();
            this.GBxTypeDetails.SuspendLayout();
            this.GBxEmpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxEmpIDState)).BeginInit();
            this.GBxEmpType.SuspendLayout();
            this.MnuAddEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxArt1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBxTypeDetails
            // 
            this.GBxTypeDetails.BackColor = System.Drawing.Color.AliceBlue;
            this.GBxTypeDetails.Controls.Add(this.LblAgency);
            this.GBxTypeDetails.Controls.Add(this.LblHourlyRate);
            this.GBxTypeDetails.Controls.Add(this.TxtAgency);
            this.GBxTypeDetails.Controls.Add(this.LblMonthlySalary);
            this.GBxTypeDetails.Controls.Add(this.LblCommissionRate);
            this.GBxTypeDetails.Controls.Add(this.TxtHourlyRate);
            this.GBxTypeDetails.Controls.Add(this.TxtMonthlySalary);
            this.GBxTypeDetails.Controls.Add(this.TxtCommissionRate);
            this.GBxTypeDetails.Controls.Add(this.LblContractWage);
            this.GBxTypeDetails.Controls.Add(this.TxtContractWage);
            this.GBxTypeDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GBxTypeDetails.Location = new System.Drawing.Point(45, 329);
            this.GBxTypeDetails.Name = "GBxTypeDetails";
            this.GBxTypeDetails.Size = new System.Drawing.Size(238, 207);
            this.GBxTypeDetails.TabIndex = 49;
            this.GBxTypeDetails.TabStop = false;
            this.GBxTypeDetails.Text = "Type Details";
            // 
            // LblAgency
            // 
            this.LblAgency.AutoSize = true;
            this.LblAgency.Location = new System.Drawing.Point(31, 121);
            this.LblAgency.Name = "LblAgency";
            this.LblAgency.Size = new System.Drawing.Size(90, 25);
            this.LblAgency.TabIndex = 17;
            this.LblAgency.Text = "Agency: ";
            this.LblAgency.Visible = false;
            // 
            // LblHourlyRate
            // 
            this.LblHourlyRate.AutoSize = true;
            this.LblHourlyRate.Location = new System.Drawing.Point(31, 51);
            this.LblHourlyRate.Name = "LblHourlyRate";
            this.LblHourlyRate.Size = new System.Drawing.Size(124, 25);
            this.LblHourlyRate.TabIndex = 13;
            this.LblHourlyRate.Text = "Hourly Rate: ";
            this.LblHourlyRate.Visible = false;
            // 
            // TxtAgency
            // 
            this.TxtAgency.Location = new System.Drawing.Point(36, 149);
            this.TxtAgency.Name = "TxtAgency";
            this.TxtAgency.Size = new System.Drawing.Size(167, 30);
            this.TxtAgency.TabIndex = 18;
            this.TxtAgency.Visible = false;
            // 
            // LblMonthlySalary
            // 
            this.LblMonthlySalary.AutoSize = true;
            this.LblMonthlySalary.Location = new System.Drawing.Point(31, 51);
            this.LblMonthlySalary.Name = "LblMonthlySalary";
            this.LblMonthlySalary.Size = new System.Drawing.Size(153, 25);
            this.LblMonthlySalary.TabIndex = 9;
            this.LblMonthlySalary.Text = "Monthly Salary: ";
            this.LblMonthlySalary.Visible = false;
            // 
            // LblCommissionRate
            // 
            this.LblCommissionRate.AutoSize = true;
            this.LblCommissionRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCommissionRate.Location = new System.Drawing.Point(34, 110);
            this.LblCommissionRate.Name = "LblCommissionRate";
            this.LblCommissionRate.Size = new System.Drawing.Size(152, 40);
            this.LblCommissionRate.TabIndex = 11;
            this.LblCommissionRate.Text = "Commission Rate: \r\n(Example:   .10)";
            this.LblCommissionRate.Visible = false;
            // 
            // TxtHourlyRate
            // 
            this.TxtHourlyRate.Location = new System.Drawing.Point(36, 79);
            this.TxtHourlyRate.Name = "TxtHourlyRate";
            this.TxtHourlyRate.Size = new System.Drawing.Size(167, 30);
            this.TxtHourlyRate.TabIndex = 14;
            this.TxtHourlyRate.Visible = false;
            // 
            // TxtMonthlySalary
            // 
            this.TxtMonthlySalary.Location = new System.Drawing.Point(36, 79);
            this.TxtMonthlySalary.Name = "TxtMonthlySalary";
            this.TxtMonthlySalary.Size = new System.Drawing.Size(167, 30);
            this.TxtMonthlySalary.TabIndex = 10;
            this.TxtMonthlySalary.Visible = false;
            // 
            // TxtCommissionRate
            // 
            this.TxtCommissionRate.Location = new System.Drawing.Point(36, 149);
            this.TxtCommissionRate.Name = "TxtCommissionRate";
            this.TxtCommissionRate.Size = new System.Drawing.Size(167, 30);
            this.TxtCommissionRate.TabIndex = 12;
            this.TxtCommissionRate.Visible = false;
            // 
            // LblContractWage
            // 
            this.LblContractWage.AutoSize = true;
            this.LblContractWage.Location = new System.Drawing.Point(31, 51);
            this.LblContractWage.Name = "LblContractWage";
            this.LblContractWage.Size = new System.Drawing.Size(155, 25);
            this.LblContractWage.TabIndex = 7;
            this.LblContractWage.Text = "Contract Wage: ";
            this.LblContractWage.Visible = false;
            // 
            // TxtContractWage
            // 
            this.TxtContractWage.Location = new System.Drawing.Point(36, 79);
            this.TxtContractWage.Name = "TxtContractWage";
            this.TxtContractWage.Size = new System.Drawing.Size(167, 30);
            this.TxtContractWage.TabIndex = 8;
            this.TxtContractWage.Visible = false;
            // 
            // GBxEmpDetails
            // 
            this.GBxEmpDetails.BackColor = System.Drawing.Color.AliceBlue;
            this.GBxEmpDetails.Controls.Add(this.CBxFPTime);
            this.GBxEmpDetails.Controls.Add(this.CBxMarital);
            this.GBxEmpDetails.Controls.Add(this.LblStartDate);
            this.GBxEmpDetails.Controls.Add(this.CldrStartDate);
            this.GBxEmpDetails.Controls.Add(this.LblDepartment);
            this.GBxEmpDetails.Controls.Add(this.TxtDepartment);
            this.GBxEmpDetails.Controls.Add(this.LblTitle);
            this.GBxEmpDetails.Controls.Add(this.TxtTitle);
            this.GBxEmpDetails.Controls.Add(this.LblMarital);
            this.GBxEmpDetails.Controls.Add(this.LblFPTime);
            this.GBxEmpDetails.Controls.Add(this.LblMiddle);
            this.GBxEmpDetails.Controls.Add(this.TxtMiddle);
            this.GBxEmpDetails.Controls.Add(this.PBxEmpIDState);
            this.GBxEmpDetails.Controls.Add(this.LblID);
            this.GBxEmpDetails.Controls.Add(this.TxtID);
            this.GBxEmpDetails.Controls.Add(this.LblLastName);
            this.GBxEmpDetails.Controls.Add(this.LblFirstName);
            this.GBxEmpDetails.Controls.Add(this.TxtLastName);
            this.GBxEmpDetails.Controls.Add(this.TxtFirstName);
            this.GBxEmpDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GBxEmpDetails.Location = new System.Drawing.Point(473, 49);
            this.GBxEmpDetails.Name = "GBxEmpDetails";
            this.GBxEmpDetails.Size = new System.Drawing.Size(630, 487);
            this.GBxEmpDetails.TabIndex = 48;
            this.GBxEmpDetails.TabStop = false;
            this.GBxEmpDetails.Text = "Employee Details";
            // 
            // CBxFPTime
            // 
            this.CBxFPTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBxFPTime.FormattingEnabled = true;
            this.CBxFPTime.Items.AddRange(new object[] {
            "Part-time",
            "Full-time"});
            this.CBxFPTime.Location = new System.Drawing.Point(45, 423);
            this.CBxFPTime.Name = "CBxFPTime";
            this.CBxFPTime.Size = new System.Drawing.Size(182, 33);
            this.CBxFPTime.TabIndex = 30;
            // 
            // CBxMarital
            // 
            this.CBxMarital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBxMarital.FormattingEnabled = true;
            this.CBxMarital.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Separated",
            "Divorced",
            "Widowed"});
            this.CBxMarital.Location = new System.Drawing.Point(45, 348);
            this.CBxMarital.Name = "CBxMarital";
            this.CBxMarital.Size = new System.Drawing.Size(182, 33);
            this.CBxMarital.TabIndex = 28;
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Location = new System.Drawing.Point(427, 218);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(110, 25);
            this.LblStartDate.TabIndex = 35;
            this.LblStartDate.Text = "Start Date: ";
            // 
            // CldrStartDate
            // 
            this.CldrStartDate.Location = new System.Drawing.Point(352, 249);
            this.CldrStartDate.Name = "CldrStartDate";
            this.CldrStartDate.TabIndex = 36;
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Location = new System.Drawing.Point(389, 32);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(124, 25);
            this.LblDepartment.TabIndex = 31;
            this.LblDepartment.Text = "Department: ";
            // 
            // TxtDepartment
            // 
            this.TxtDepartment.Location = new System.Drawing.Point(394, 60);
            this.TxtDepartment.Name = "TxtDepartment";
            this.TxtDepartment.Size = new System.Drawing.Size(182, 30);
            this.TxtDepartment.TabIndex = 32;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(389, 104);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(60, 25);
            this.LblTitle.TabIndex = 33;
            this.LblTitle.Text = "Title: ";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(394, 132);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(182, 30);
            this.TxtTitle.TabIndex = 34;
            // 
            // LblMarital
            // 
            this.LblMarital.AutoSize = true;
            this.LblMarital.Location = new System.Drawing.Point(40, 320);
            this.LblMarital.Name = "LblMarital";
            this.LblMarital.Size = new System.Drawing.Size(142, 25);
            this.LblMarital.TabIndex = 27;
            this.LblMarital.Text = "Marital Status: ";
            // 
            // LblFPTime
            // 
            this.LblFPTime.AutoSize = true;
            this.LblFPTime.Location = new System.Drawing.Point(40, 395);
            this.LblFPTime.Name = "LblFPTime";
            this.LblFPTime.Size = new System.Drawing.Size(138, 25);
            this.LblFPTime.TabIndex = 29;
            this.LblFPTime.Text = "Full/Part-time: ";
            // 
            // LblMiddle
            // 
            this.LblMiddle.AutoSize = true;
            this.LblMiddle.Location = new System.Drawing.Point(40, 176);
            this.LblMiddle.Name = "LblMiddle";
            this.LblMiddle.Size = new System.Drawing.Size(125, 25);
            this.LblMiddle.TabIndex = 23;
            this.LblMiddle.Text = "Middle Initial:";
            // 
            // TxtMiddle
            // 
            this.TxtMiddle.Location = new System.Drawing.Point(45, 204);
            this.TxtMiddle.Name = "TxtMiddle";
            this.TxtMiddle.Size = new System.Drawing.Size(182, 30);
            this.TxtMiddle.TabIndex = 24;
            // 
            // PBxEmpIDState
            // 
            this.PBxEmpIDState.BackgroundImage = global::Lab_12_JRL.Properties.Resources.sad;
            this.PBxEmpIDState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBxEmpIDState.Location = new System.Drawing.Point(243, 39);
            this.PBxEmpIDState.Name = "PBxEmpIDState";
            this.PBxEmpIDState.Padding = new System.Windows.Forms.Padding(5);
            this.PBxEmpIDState.Size = new System.Drawing.Size(84, 70);
            this.PBxEmpIDState.TabIndex = 40;
            this.PBxEmpIDState.TabStop = false;
            this.PBxEmpIDState.Visible = false;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(40, 31);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(42, 25);
            this.LblID.TabIndex = 19;
            this.LblID.Text = "ID: ";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(45, 60);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(182, 30);
            this.TxtID.TabIndex = 20;
            this.TxtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            this.TxtID.Enter += new System.EventHandler(this.TxtID_Enter);
            this.TxtID.Leave += new System.EventHandler(this.TxtID_Leave);
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(40, 248);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(117, 25);
            this.LblLastName.TabIndex = 25;
            this.LblLastName.Text = "Last Name: ";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(40, 104);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(117, 25);
            this.LblFirstName.TabIndex = 21;
            this.LblFirstName.Text = "First Name: ";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(45, 276);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(182, 30);
            this.TxtLastName.TabIndex = 26;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(45, 132);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(182, 30);
            this.TxtFirstName.TabIndex = 22;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(984, 553);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(119, 46);
            this.BtnSave.TabIndex = 50;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // GBxEmpType
            // 
            this.GBxEmpType.BackColor = System.Drawing.Color.AliceBlue;
            this.GBxEmpType.Controls.Add(this.RBtnContract);
            this.GBxEmpType.Controls.Add(this.RBtnSales);
            this.GBxEmpType.Controls.Add(this.RBtnSalary);
            this.GBxEmpType.Controls.Add(this.RBtnHourly);
            this.GBxEmpType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GBxEmpType.Location = new System.Drawing.Point(45, 49);
            this.GBxEmpType.Name = "GBxEmpType";
            this.GBxEmpType.Size = new System.Drawing.Size(238, 216);
            this.GBxEmpType.TabIndex = 47;
            this.GBxEmpType.TabStop = false;
            this.GBxEmpType.Text = "Employee Type";
            // 
            // RBtnContract
            // 
            this.RBtnContract.AutoSize = true;
            this.RBtnContract.Location = new System.Drawing.Point(36, 153);
            this.RBtnContract.Name = "RBtnContract";
            this.RBtnContract.Size = new System.Drawing.Size(107, 29);
            this.RBtnContract.TabIndex = 6;
            this.RBtnContract.TabStop = true;
            this.RBtnContract.Text = "Contract";
            this.RBtnContract.UseVisualStyleBackColor = true;
            // 
            // RBtnSales
            // 
            this.RBtnSales.AutoSize = true;
            this.RBtnSales.Location = new System.Drawing.Point(36, 118);
            this.RBtnSales.Name = "RBtnSales";
            this.RBtnSales.Size = new System.Drawing.Size(83, 29);
            this.RBtnSales.TabIndex = 5;
            this.RBtnSales.TabStop = true;
            this.RBtnSales.Text = "Sales";
            this.RBtnSales.UseVisualStyleBackColor = true;
            // 
            // RBtnSalary
            // 
            this.RBtnSalary.AutoSize = true;
            this.RBtnSalary.Location = new System.Drawing.Point(36, 83);
            this.RBtnSalary.Name = "RBtnSalary";
            this.RBtnSalary.Size = new System.Drawing.Size(89, 29);
            this.RBtnSalary.TabIndex = 4;
            this.RBtnSalary.TabStop = true;
            this.RBtnSalary.Text = "Salary";
            this.RBtnSalary.UseVisualStyleBackColor = true;
            // 
            // RBtnHourly
            // 
            this.RBtnHourly.AutoSize = true;
            this.RBtnHourly.Location = new System.Drawing.Point(36, 48);
            this.RBtnHourly.Name = "RBtnHourly";
            this.RBtnHourly.Size = new System.Drawing.Size(89, 29);
            this.RBtnHourly.TabIndex = 3;
            this.RBtnHourly.TabStop = true;
            this.RBtnHourly.Text = "Hourly";
            this.RBtnHourly.UseVisualStyleBackColor = true;
            // 
            // MnuAddEmp
            // 
            this.MnuAddEmp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuAddEmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.MnuAddEmp.Location = new System.Drawing.Point(0, 0);
            this.MnuAddEmp.Name = "MnuAddEmp";
            this.MnuAddEmp.Size = new System.Drawing.Size(1147, 28);
            this.MnuAddEmp.TabIndex = 46;
            this.MnuAddEmp.Text = "menuStrip1";
            this.MnuAddEmp.Visible = false;
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuEmptyEmpField,
            this.MnuEmptyTypeField,
            this.MnuUnavailableEmpID});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // MnuEmptyEmpField
            // 
            this.MnuEmptyEmpField.Name = "MnuEmptyEmpField";
            this.MnuEmptyEmpField.Size = new System.Drawing.Size(251, 26);
            this.MnuEmptyEmpField.Text = "Empty Employee Field";
            this.MnuEmptyEmpField.Click += new System.EventHandler(this.MnuEmptyEmpField_Click);
            // 
            // MnuEmptyTypeField
            // 
            this.MnuEmptyTypeField.Name = "MnuEmptyTypeField";
            this.MnuEmptyTypeField.Size = new System.Drawing.Size(251, 26);
            this.MnuEmptyTypeField.Text = "Empty Type Field";
            this.MnuEmptyTypeField.Click += new System.EventHandler(this.MnuEmptyTypeField_Click);
            // 
            // MnuUnavailableEmpID
            // 
            this.MnuUnavailableEmpID.Name = "MnuUnavailableEmpID";
            this.MnuUnavailableEmpID.Size = new System.Drawing.Size(251, 26);
            this.MnuUnavailableEmpID.Text = "Unavailable Employee ID";
            this.MnuUnavailableEmpID.Click += new System.EventHandler(this.MnuUnavailableEmpID_Click);
            // 
            // PBxArt1
            // 
            this.PBxArt1.BackgroundImage = global::Lab_12_JRL.Properties.Resources.www;
            this.PBxArt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBxArt1.Location = new System.Drawing.Point(303, 175);
            this.PBxArt1.Name = "PBxArt1";
            this.PBxArt1.Size = new System.Drawing.Size(152, 242);
            this.PBxArt1.TabIndex = 51;
            this.PBxArt1.TabStop = false;
            // 
            // FrmAdd_Emp
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 617);
            this.Controls.Add(this.PBxArt1);
            this.Controls.Add(this.GBxTypeDetails);
            this.Controls.Add(this.GBxEmpDetails);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GBxEmpType);
            this.Controls.Add(this.MnuAddEmp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuAddEmp;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdd_Emp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.GBxTypeDetails.ResumeLayout(false);
            this.GBxTypeDetails.PerformLayout();
            this.GBxEmpDetails.ResumeLayout(false);
            this.GBxEmpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxEmpIDState)).EndInit();
            this.GBxEmpType.ResumeLayout(false);
            this.GBxEmpType.PerformLayout();
            this.MnuAddEmp.ResumeLayout(false);
            this.MnuAddEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxArt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBxArt1;
        private System.Windows.Forms.GroupBox GBxTypeDetails;
        private System.Windows.Forms.Label LblHourlyRate;
        private System.Windows.Forms.Label LblMonthlySalary;
        private System.Windows.Forms.Label LblCommissionRate;
        private System.Windows.Forms.TextBox TxtHourlyRate;
        private System.Windows.Forms.TextBox TxtMonthlySalary;
        private System.Windows.Forms.TextBox TxtCommissionRate;
        private System.Windows.Forms.Label LblContractWage;
        private System.Windows.Forms.TextBox TxtContractWage;
        private System.Windows.Forms.GroupBox GBxEmpDetails;
        private System.Windows.Forms.PictureBox PBxEmpIDState;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox GBxEmpType;
        private System.Windows.Forms.RadioButton RBtnContract;
        private System.Windows.Forms.RadioButton RBtnSales;
        private System.Windows.Forms.RadioButton RBtnSalary;
        private System.Windows.Forms.RadioButton RBtnHourly;
        private System.Windows.Forms.MenuStrip MnuAddEmp;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuEmptyEmpField;
        private System.Windows.Forms.ToolStripMenuItem MnuEmptyTypeField;
        private System.Windows.Forms.ToolStripMenuItem MnuUnavailableEmpID;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.MonthCalendar CldrStartDate;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.TextBox TxtDepartment;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LblMarital;
        private System.Windows.Forms.Label LblFPTime;
        private System.Windows.Forms.Label LblMiddle;
        private System.Windows.Forms.TextBox TxtMiddle;
        private System.Windows.Forms.ComboBox CBxFPTime;
        private System.Windows.Forms.ComboBox CBxMarital;
        private System.Windows.Forms.Label LblAgency;
        private System.Windows.Forms.TextBox TxtAgency;
    }
}