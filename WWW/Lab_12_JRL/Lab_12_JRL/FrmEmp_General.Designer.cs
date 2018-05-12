namespace Lab_12_JRL
{
    partial class FrmEmp_General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmp_General));
            this.GBxEligibles = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnEmpBenefits = new System.Windows.Forms.Button();
            this.BtnRequestApproval = new System.Windows.Forms.Button();
            this.LblEduBenefits = new System.Windows.Forms.Label();
            this.TxtEduBenefits = new System.Windows.Forms.TextBox();
            this.LblOvertime = new System.Windows.Forms.Label();
            this.TxtOvertime = new System.Windows.Forms.TextBox();
            this.LblBenefits = new System.Windows.Forms.Label();
            this.LblCommission = new System.Windows.Forms.Label();
            this.TxtBenefits = new System.Windows.Forms.TextBox();
            this.TxtCommission = new System.Windows.Forms.TextBox();
            this.LblEmpInfo = new System.Windows.Forms.Label();
            this.GBxGeneral = new System.Windows.Forms.GroupBox();
            this.CBxType = new System.Windows.Forms.ComboBox();
            this.LblMiddle = new System.Windows.Forms.Label();
            this.TxtMiddle = new System.Windows.Forms.TextBox();
            this.LblComp1 = new System.Windows.Forms.Label();
            this.TxtComp1 = new System.Windows.Forms.TextBox();
            this.LblType = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblComp2 = new System.Windows.Forms.Label();
            this.TxtComp2 = new System.Windows.Forms.TextBox();
            this.GBxSpecific = new System.Windows.Forms.GroupBox();
            this.CBxStatus = new System.Windows.Forms.ComboBox();
            this.LblComp3 = new System.Windows.Forms.Label();
            this.TxtComp3 = new System.Windows.Forms.TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.DTPStart = new System.Windows.Forms.DateTimePicker();
            this.CBxFPTime = new System.Windows.Forms.ComboBox();
            this.CBxMarital = new System.Windows.Forms.ComboBox();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.TxtDepartment = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblMarital = new System.Windows.Forms.Label();
            this.LblFPTime = new System.Windows.Forms.Label();
            this.PBxArt2 = new System.Windows.Forms.PictureBox();
            this.PBxArt1 = new System.Windows.Forms.PictureBox();
            this.GBxEligibles.SuspendLayout();
            this.GBxGeneral.SuspendLayout();
            this.GBxSpecific.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxArt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxArt1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBxEligibles
            // 
            this.GBxEligibles.BackColor = System.Drawing.Color.AliceBlue;
            this.GBxEligibles.Controls.Add(this.BtnSave);
            this.GBxEligibles.Controls.Add(this.BtnEmpBenefits);
            this.GBxEligibles.Controls.Add(this.BtnRequestApproval);
            this.GBxEligibles.Controls.Add(this.LblEduBenefits);
            this.GBxEligibles.Controls.Add(this.TxtEduBenefits);
            this.GBxEligibles.Controls.Add(this.LblOvertime);
            this.GBxEligibles.Controls.Add(this.TxtOvertime);
            this.GBxEligibles.Controls.Add(this.LblBenefits);
            this.GBxEligibles.Controls.Add(this.LblCommission);
            this.GBxEligibles.Controls.Add(this.TxtBenefits);
            this.GBxEligibles.Controls.Add(this.TxtCommission);
            this.GBxEligibles.Location = new System.Drawing.Point(1026, 105);
            this.GBxEligibles.Name = "GBxEligibles";
            this.GBxEligibles.Size = new System.Drawing.Size(394, 548);
            this.GBxEligibles.TabIndex = 3;
            this.GBxEligibles.TabStop = false;
            this.GBxEligibles.Text = "Eligibles";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(262, 476);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(111, 45);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnEmpBenefits
            // 
            this.BtnEmpBenefits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpBenefits.Location = new System.Drawing.Point(58, 378);
            this.BtnEmpBenefits.Name = "BtnEmpBenefits";
            this.BtnEmpBenefits.Size = new System.Drawing.Size(182, 61);
            this.BtnEmpBenefits.TabIndex = 9;
            this.BtnEmpBenefits.Text = "View/Manage Employee Benefits";
            this.BtnEmpBenefits.UseVisualStyleBackColor = true;
            this.BtnEmpBenefits.Visible = false;
            this.BtnEmpBenefits.Click += new System.EventHandler(this.BtnEmpBenefits_Click);
            // 
            // BtnRequestApproval
            // 
            this.BtnRequestApproval.Location = new System.Drawing.Point(262, 377);
            this.BtnRequestApproval.Name = "BtnRequestApproval";
            this.BtnRequestApproval.Size = new System.Drawing.Size(111, 60);
            this.BtnRequestApproval.TabIndex = 8;
            this.BtnRequestApproval.Text = "Request Approval";
            this.BtnRequestApproval.UseVisualStyleBackColor = true;
            this.BtnRequestApproval.Visible = false;
            this.BtnRequestApproval.Click += new System.EventHandler(this.BtnRequestApproval_Click);
            // 
            // LblEduBenefits
            // 
            this.LblEduBenefits.AutoSize = true;
            this.LblEduBenefits.Location = new System.Drawing.Point(53, 296);
            this.LblEduBenefits.Name = "LblEduBenefits";
            this.LblEduBenefits.Size = new System.Drawing.Size(180, 25);
            this.LblEduBenefits.TabIndex = 6;
            this.LblEduBenefits.Text = "Education Benefits:";
            // 
            // TxtEduBenefits
            // 
            this.TxtEduBenefits.Enabled = false;
            this.TxtEduBenefits.Location = new System.Drawing.Point(58, 325);
            this.TxtEduBenefits.Name = "TxtEduBenefits";
            this.TxtEduBenefits.Size = new System.Drawing.Size(182, 30);
            this.TxtEduBenefits.TabIndex = 7;
            // 
            // LblOvertime
            // 
            this.LblOvertime.AutoSize = true;
            this.LblOvertime.Location = new System.Drawing.Point(53, 39);
            this.LblOvertime.Name = "LblOvertime";
            this.LblOvertime.Size = new System.Drawing.Size(97, 25);
            this.LblOvertime.TabIndex = 0;
            this.LblOvertime.Text = "Overtime:";
            // 
            // TxtOvertime
            // 
            this.TxtOvertime.Enabled = false;
            this.TxtOvertime.Location = new System.Drawing.Point(58, 67);
            this.TxtOvertime.Name = "TxtOvertime";
            this.TxtOvertime.Size = new System.Drawing.Size(182, 30);
            this.TxtOvertime.TabIndex = 1;
            // 
            // LblBenefits
            // 
            this.LblBenefits.AutoSize = true;
            this.LblBenefits.Location = new System.Drawing.Point(53, 210);
            this.LblBenefits.Name = "LblBenefits";
            this.LblBenefits.Size = new System.Drawing.Size(88, 25);
            this.LblBenefits.TabIndex = 4;
            this.LblBenefits.Text = "Benefits:";
            // 
            // LblCommission
            // 
            this.LblCommission.AutoSize = true;
            this.LblCommission.Location = new System.Drawing.Point(53, 125);
            this.LblCommission.Name = "LblCommission";
            this.LblCommission.Size = new System.Drawing.Size(126, 25);
            this.LblCommission.TabIndex = 2;
            this.LblCommission.Text = "Commission:";
            // 
            // TxtBenefits
            // 
            this.TxtBenefits.Enabled = false;
            this.TxtBenefits.Location = new System.Drawing.Point(58, 239);
            this.TxtBenefits.Name = "TxtBenefits";
            this.TxtBenefits.Size = new System.Drawing.Size(182, 30);
            this.TxtBenefits.TabIndex = 5;
            // 
            // TxtCommission
            // 
            this.TxtCommission.Enabled = false;
            this.TxtCommission.Location = new System.Drawing.Point(58, 153);
            this.TxtCommission.Name = "TxtCommission";
            this.TxtCommission.Size = new System.Drawing.Size(182, 30);
            this.TxtCommission.TabIndex = 3;
            // 
            // LblEmpInfo
            // 
            this.LblEmpInfo.AutoSize = true;
            this.LblEmpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpInfo.Location = new System.Drawing.Point(551, 27);
            this.LblEmpInfo.Name = "LblEmpInfo";
            this.LblEmpInfo.Size = new System.Drawing.Size(462, 51);
            this.LblEmpInfo.TabIndex = 0;
            this.LblEmpInfo.Text = "Employee Information";
            // 
            // GBxGeneral
            // 
            this.GBxGeneral.BackColor = System.Drawing.Color.AliceBlue;
            this.GBxGeneral.Controls.Add(this.CBxType);
            this.GBxGeneral.Controls.Add(this.LblMiddle);
            this.GBxGeneral.Controls.Add(this.TxtMiddle);
            this.GBxGeneral.Controls.Add(this.LblComp1);
            this.GBxGeneral.Controls.Add(this.TxtComp1);
            this.GBxGeneral.Controls.Add(this.LblType);
            this.GBxGeneral.Controls.Add(this.LblID);
            this.GBxGeneral.Controls.Add(this.TxtID);
            this.GBxGeneral.Controls.Add(this.LblLastName);
            this.GBxGeneral.Controls.Add(this.LblFirstName);
            this.GBxGeneral.Controls.Add(this.TxtLastName);
            this.GBxGeneral.Controls.Add(this.TxtFirstName);
            this.GBxGeneral.Controls.Add(this.LblComp2);
            this.GBxGeneral.Controls.Add(this.TxtComp2);
            this.GBxGeneral.Location = new System.Drawing.Point(52, 105);
            this.GBxGeneral.Name = "GBxGeneral";
            this.GBxGeneral.Size = new System.Drawing.Size(394, 548);
            this.GBxGeneral.TabIndex = 1;
            this.GBxGeneral.TabStop = false;
            this.GBxGeneral.Text = "General";
            // 
            // CBxType
            // 
            this.CBxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBxType.Enabled = false;
            this.CBxType.FormattingEnabled = true;
            this.CBxType.Items.AddRange(new object[] {
            "Hourly",
            "Salary",
            "Sales",
            "Contract"});
            this.CBxType.Location = new System.Drawing.Point(58, 339);
            this.CBxType.Name = "CBxType";
            this.CBxType.Size = new System.Drawing.Size(182, 33);
            this.CBxType.TabIndex = 9;
            this.CBxType.SelectionChangeCommitted += new System.EventHandler(this.CBxType_SelectionChangeCommitted);
            // 
            // LblMiddle
            // 
            this.LblMiddle.AutoSize = true;
            this.LblMiddle.Location = new System.Drawing.Point(53, 175);
            this.LblMiddle.Name = "LblMiddle";
            this.LblMiddle.Size = new System.Drawing.Size(125, 25);
            this.LblMiddle.TabIndex = 4;
            this.LblMiddle.Text = "Middle Initial:";
            // 
            // TxtMiddle
            // 
            this.TxtMiddle.Enabled = false;
            this.TxtMiddle.Location = new System.Drawing.Point(58, 203);
            this.TxtMiddle.Name = "TxtMiddle";
            this.TxtMiddle.Size = new System.Drawing.Size(182, 30);
            this.TxtMiddle.TabIndex = 5;
            // 
            // LblComp1
            // 
            this.LblComp1.AutoSize = true;
            this.LblComp1.Location = new System.Drawing.Point(53, 377);
            this.LblComp1.Name = "LblComp1";
            this.LblComp1.Size = new System.Drawing.Size(145, 25);
            this.LblComp1.TabIndex = 10;
            this.LblComp1.Text = "Compensation:";
            // 
            // TxtComp1
            // 
            this.TxtComp1.Enabled = false;
            this.TxtComp1.Location = new System.Drawing.Point(58, 407);
            this.TxtComp1.Name = "TxtComp1";
            this.TxtComp1.Size = new System.Drawing.Size(182, 30);
            this.TxtComp1.TabIndex = 11;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(53, 311);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(63, 25);
            this.LblType.TabIndex = 8;
            this.LblType.Text = "Type:";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(53, 38);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(42, 25);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID: ";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(58, 67);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(182, 30);
            this.TxtID.TabIndex = 1;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(53, 243);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(117, 25);
            this.LblLastName.TabIndex = 6;
            this.LblLastName.Text = "Last Name: ";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(53, 106);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(117, 25);
            this.LblFirstName.TabIndex = 2;
            this.LblFirstName.Text = "First Name: ";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Enabled = false;
            this.TxtLastName.Location = new System.Drawing.Point(58, 271);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(182, 30);
            this.TxtLastName.TabIndex = 7;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Enabled = false;
            this.TxtFirstName.Location = new System.Drawing.Point(58, 135);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(182, 30);
            this.TxtFirstName.TabIndex = 3;
            // 
            // LblComp2
            // 
            this.LblComp2.AutoSize = true;
            this.LblComp2.Location = new System.Drawing.Point(53, 448);
            this.LblComp2.Name = "LblComp2";
            this.LblComp2.Size = new System.Drawing.Size(82, 25);
            this.LblComp2.TabIndex = 12;
            this.LblComp2.Text = "Comp2:";
            // 
            // TxtComp2
            // 
            this.TxtComp2.Enabled = false;
            this.TxtComp2.Location = new System.Drawing.Point(58, 477);
            this.TxtComp2.Name = "TxtComp2";
            this.TxtComp2.Size = new System.Drawing.Size(182, 30);
            this.TxtComp2.TabIndex = 13;
            // 
            // GBxSpecific
            // 
            this.GBxSpecific.BackColor = System.Drawing.Color.AliceBlue;
            this.GBxSpecific.Controls.Add(this.CBxStatus);
            this.GBxSpecific.Controls.Add(this.LblComp3);
            this.GBxSpecific.Controls.Add(this.TxtComp3);
            this.GBxSpecific.Controls.Add(this.LblStatus);
            this.GBxSpecific.Controls.Add(this.DTPStart);
            this.GBxSpecific.Controls.Add(this.CBxFPTime);
            this.GBxSpecific.Controls.Add(this.CBxMarital);
            this.GBxSpecific.Controls.Add(this.LblStartDate);
            this.GBxSpecific.Controls.Add(this.LblDepartment);
            this.GBxSpecific.Controls.Add(this.TxtDepartment);
            this.GBxSpecific.Controls.Add(this.LblTitle);
            this.GBxSpecific.Controls.Add(this.TxtTitle);
            this.GBxSpecific.Controls.Add(this.LblMarital);
            this.GBxSpecific.Controls.Add(this.LblFPTime);
            this.GBxSpecific.Location = new System.Drawing.Point(539, 107);
            this.GBxSpecific.Name = "GBxSpecific";
            this.GBxSpecific.Size = new System.Drawing.Size(394, 546);
            this.GBxSpecific.TabIndex = 2;
            this.GBxSpecific.TabStop = false;
            this.GBxSpecific.Text = "Specific";
            // 
            // CBxStatus
            // 
            this.CBxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBxStatus.Enabled = false;
            this.CBxStatus.FormattingEnabled = true;
            this.CBxStatus.Items.AddRange(new object[] {
            "Current",
            "Former"});
            this.CBxStatus.Location = new System.Drawing.Point(58, 474);
            this.CBxStatus.Name = "CBxStatus";
            this.CBxStatus.Size = new System.Drawing.Size(182, 33);
            this.CBxStatus.TabIndex = 13;
            // 
            // LblComp3
            // 
            this.LblComp3.AutoSize = true;
            this.LblComp3.Location = new System.Drawing.Point(53, 36);
            this.LblComp3.Name = "LblComp3";
            this.LblComp3.Size = new System.Drawing.Size(82, 25);
            this.LblComp3.TabIndex = 0;
            this.LblComp3.Text = "Comp3:";
            // 
            // TxtComp3
            // 
            this.TxtComp3.Enabled = false;
            this.TxtComp3.Location = new System.Drawing.Point(58, 65);
            this.TxtComp3.Name = "TxtComp3";
            this.TxtComp3.Size = new System.Drawing.Size(182, 30);
            this.TxtComp3.TabIndex = 1;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(53, 447);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(79, 25);
            this.LblStatus.TabIndex = 12;
            this.LblStatus.Text = "Status: ";
            // 
            // DTPStart
            // 
            this.DTPStart.Enabled = false;
            this.DTPStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPStart.Location = new System.Drawing.Point(58, 414);
            this.DTPStart.Name = "DTPStart";
            this.DTPStart.Size = new System.Drawing.Size(182, 22);
            this.DTPStart.TabIndex = 11;
            // 
            // CBxFPTime
            // 
            this.CBxFPTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBxFPTime.Enabled = false;
            this.CBxFPTime.FormattingEnabled = true;
            this.CBxFPTime.Items.AddRange(new object[] {
            "Part-time",
            "Full-time"});
            this.CBxFPTime.Location = new System.Drawing.Point(58, 204);
            this.CBxFPTime.Name = "CBxFPTime";
            this.CBxFPTime.Size = new System.Drawing.Size(182, 33);
            this.CBxFPTime.TabIndex = 5;
            // 
            // CBxMarital
            // 
            this.CBxMarital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBxMarital.Enabled = false;
            this.CBxMarital.FormattingEnabled = true;
            this.CBxMarital.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Separated",
            "Divorced",
            "Widowed"});
            this.CBxMarital.Location = new System.Drawing.Point(58, 133);
            this.CBxMarital.Name = "CBxMarital";
            this.CBxMarital.Size = new System.Drawing.Size(182, 33);
            this.CBxMarital.TabIndex = 3;
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Location = new System.Drawing.Point(53, 385);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(110, 25);
            this.LblStartDate.TabIndex = 10;
            this.LblStartDate.Text = "Start Date: ";
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Location = new System.Drawing.Point(53, 247);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(124, 25);
            this.LblDepartment.TabIndex = 6;
            this.LblDepartment.Text = "Department: ";
            // 
            // TxtDepartment
            // 
            this.TxtDepartment.Enabled = false;
            this.TxtDepartment.Location = new System.Drawing.Point(58, 275);
            this.TxtDepartment.Name = "TxtDepartment";
            this.TxtDepartment.Size = new System.Drawing.Size(182, 30);
            this.TxtDepartment.TabIndex = 7;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(53, 316);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(60, 25);
            this.LblTitle.TabIndex = 8;
            this.LblTitle.Text = "Title: ";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Enabled = false;
            this.TxtTitle.Location = new System.Drawing.Point(58, 344);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(182, 30);
            this.TxtTitle.TabIndex = 9;
            // 
            // LblMarital
            // 
            this.LblMarital.AutoSize = true;
            this.LblMarital.Location = new System.Drawing.Point(53, 105);
            this.LblMarital.Name = "LblMarital";
            this.LblMarital.Size = new System.Drawing.Size(142, 25);
            this.LblMarital.TabIndex = 2;
            this.LblMarital.Text = "Marital Status: ";
            // 
            // LblFPTime
            // 
            this.LblFPTime.AutoSize = true;
            this.LblFPTime.Location = new System.Drawing.Point(53, 176);
            this.LblFPTime.Name = "LblFPTime";
            this.LblFPTime.Size = new System.Drawing.Size(138, 25);
            this.LblFPTime.TabIndex = 4;
            this.LblFPTime.Text = "Full/Part-time: ";
            // 
            // PBxArt2
            // 
            this.PBxArt2.BackgroundImage = global::Lab_12_JRL.Properties.Resources.wwwicon;
            this.PBxArt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBxArt2.Location = new System.Drawing.Point(1175, 12);
            this.PBxArt2.Name = "PBxArt2";
            this.PBxArt2.Size = new System.Drawing.Size(96, 78);
            this.PBxArt2.TabIndex = 31;
            this.PBxArt2.TabStop = false;
            // 
            // PBxArt1
            // 
            this.PBxArt1.BackgroundImage = global::Lab_12_JRL.Properties.Resources.wwwicon;
            this.PBxArt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBxArt1.Location = new System.Drawing.Point(201, 12);
            this.PBxArt1.Name = "PBxArt1";
            this.PBxArt1.Size = new System.Drawing.Size(96, 78);
            this.PBxArt1.TabIndex = 28;
            this.PBxArt1.TabStop = false;
            // 
            // FrmEmp_General
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1473, 677);
            this.Controls.Add(this.PBxArt2);
            this.Controls.Add(this.GBxSpecific);
            this.Controls.Add(this.PBxArt1);
            this.Controls.Add(this.GBxEligibles);
            this.Controls.Add(this.LblEmpInfo);
            this.Controls.Add(this.GBxGeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmp_General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Portal - General";
            this.GBxEligibles.ResumeLayout(false);
            this.GBxEligibles.PerformLayout();
            this.GBxGeneral.ResumeLayout(false);
            this.GBxGeneral.PerformLayout();
            this.GBxSpecific.ResumeLayout(false);
            this.GBxSpecific.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxArt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxArt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBxArt1;
        public System.Windows.Forms.Button BtnEmpBenefits;
        public System.Windows.Forms.Button BtnRequestApproval;
        private System.Windows.Forms.Label LblEduBenefits;
        public System.Windows.Forms.TextBox TxtEduBenefits;
        private System.Windows.Forms.Label LblOvertime;
        public System.Windows.Forms.TextBox TxtOvertime;
        private System.Windows.Forms.Label LblBenefits;
        private System.Windows.Forms.Label LblCommission;
        public System.Windows.Forms.TextBox TxtBenefits;
        public System.Windows.Forms.TextBox TxtCommission;
        private System.Windows.Forms.Label LblEmpInfo;
        public System.Windows.Forms.Label LblComp2;
        public System.Windows.Forms.TextBox TxtComp2;
        public System.Windows.Forms.Label LblComp1;
        public System.Windows.Forms.TextBox TxtComp1;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblID;
        public System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblFirstName;
        public System.Windows.Forms.TextBox TxtLastName;
        public System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label LblMiddle;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblMarital;
        private System.Windows.Forms.Label LblFPTime;
        private System.Windows.Forms.PictureBox PBxArt2;
        public System.Windows.Forms.TextBox TxtMiddle;
        public System.Windows.Forms.DateTimePicker DTPStart;
        public System.Windows.Forms.ComboBox CBxFPTime;
        public System.Windows.Forms.ComboBox CBxMarital;
        public System.Windows.Forms.TextBox TxtDepartment;
        public System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LblStatus;
        public System.Windows.Forms.Label LblComp3;
        public System.Windows.Forms.TextBox TxtComp3;
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.GroupBox GBxEligibles;
        public System.Windows.Forms.GroupBox GBxGeneral;
        public System.Windows.Forms.GroupBox GBxSpecific;
        public System.Windows.Forms.ComboBox CBxType;
        public System.Windows.Forms.ComboBox CBxStatus;
    }
}