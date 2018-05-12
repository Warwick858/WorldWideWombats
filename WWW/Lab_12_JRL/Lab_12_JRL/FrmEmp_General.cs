// File Prolog
// Name: James LoForti
// Course: CS 3260 Section: 001
// Instructor: Dr. Lynn Thackeray
// Project: Lab_12
// Date: 12/05/2016
// Purpose: To complete the WWW object-oriented database program
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab_12_JRL
{
    /// <summary>
    /// The general employee form
    /// </summary>
    public partial class FrmEmp_General : Form
    {
        //Declare & Initialize Constants:
        const string REQUEST_APPROVED_CAPTION = "Request Approved ";
        const string REQUEST_APPROVED_MSG = "Your request for education benefits has been approved. ";
        const string TYPE_CHANGE_CAPTION = "WARNING -Major Adjustment ";
        const string TYPE_CHANGE_MSG = "You are about to change the employee type, \n" + 
            "which results in a change of benefits and compensation. \n" + 
            "Are you sure you want to make this change? ";
        const string LITERAL_HOURLY = "Hourly";
        const string LITERAL_SALARY = "Salary";
        const string LITERAL_SALES = "Sales";
        const string LITERAL_CONTRACT = "Contract";
        const string LITERAL_NO = "No";
        const string LITERAL_YES = "Yes";
        const string LITERAL_SRY_RATE = "Commission Rate: ";
        const string LITERAL_CON_RATE = "Contract Wage: ";
        const string LITERAL_SAL_RATE = "Monthly Salary: ";
        const string LITERAL_HRY_RATE = "Hourly Rate: ";
        const string LITERAL_HOURS_WORKED = "Hours Worked: ";
        const string LITERAL_AGENCY = "Agency: ";
        const string LITERAL_LBL_SALES = "Sales: ";
        const string TAKEN_ID_CAPTION = "Unavailable Employee ID ";
        const string TAKEN_ID_MSG = "That employee ID is already taken. ";
        const string EMPTY_FIELD_CAPTION = "Empty Field ";
        const string EMPTY_FIELD_MSG = " field is required. ";
        const string INVALID_FIELD_CAPTION = "Invalid field ";
        const string INVALID_FIELD_MSG = " must be a number. ";
        const string INVALID_FIELD_CAPTION2 = "Invalid field ";
        const string INVALID_FIELD_MSG2 = " must be upper or lower case letters and spaces. ";
        const string INVALID_ID_CAPTION = "Invalid ID ";
        const string INVALID_ID_MSG = " ID must be an unsigned integer, that's less than 9999999999, and 5 digits long. ";
        const string INVALID_FNAME_CAPTION = "Invalid First Name ";
        const string INVALID_FNAME_MSG = "First name cannot contain anything but upper or lower case letters. ";
        const string INVALID_MNAME_CAPTION = "Invalid Middle Initial ";
        const string INVALID_MNAME_MSG = "Middle initial cannot contain anything but a single upper-case letter. ";
        const string INVALID_LNAME_CAPTION = "Invalid Last Name ";
        const string INVALID_LNAME_MSG = "Last name cannot contain anything but upper or lower case letters. ";
        const string INVALID_DEPT_CAPTION = "Invalid Department ";
        const string INVALID_DEPT_MSG = "Department cannot contain anything but upper or lower case letters and spaces. ";
        const string INVALID_TITLE_CAPTION = "Invalid Title ";
        const string INVALID_TITLE_MSG = "Title cannot contain anything but upper or lower case letters and spaces. ";
        const string GENERAL_CLOSE_CAPTION = "Close Without Saving ";
        const string GENERAL_CLOSE_MSG = "You are about to close the employee record without saving, are you sure? ";
        //Declare & init globals:
        bool userCloseFlag = false;
        //Define Class Properties:
        public Employee CurrEmp { get; set; }

        /// <summary>
        /// The default constructor
        /// </summary>
        public FrmEmp_General()
        {
            InitializeComponent();
        } // end constructor

        /// <summary>
        /// To emulate a request and approval process
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void BtnRequestApproval_Click(object sender, EventArgs e)
        {
            //Prompt user of request approval
            MessageBox.Show(REQUEST_APPROVED_MSG, REQUEST_APPROVED_CAPTION);

            //Hide request approval button
            BtnRequestApproval.Visible = false;
            //Show manage benefits button
            BtnEmpBenefits.Visible = true;

            //Set employee flag so approval is saved
            CurrEmp.EducationBenefitsApproved = true;
        } // end method BtnRequestApproval_Click()

        /// <summary>
        /// To show the benefits form populated with users data
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void BtnEmpBenefits_Click(object sender, EventArgs e)
        {
            //Create new instance of FrmEmp_Benefits
            FrmEmp_Benefits form = new FrmEmp_Benefits();

            //Set current employee & display in TxtBox
            form.CurrEmp = CurrEmp;
            form.TxtCurrentEmp.Text = CurrEmp.FirstName + " " + CurrEmp.LastName;

            //HOURLY grades
            if (CurrEmp.EmpType.Equals(EType.HOURLY))
            {
                //Configure Grades
                form.CBxGrade.Items.RemoveAt(8);
                form.CBxGrade.Items.RemoveAt(7);
                form.CBxGrade.Items.RemoveAt(6);
                form.CBxGrade.Items.RemoveAt(5);
                //Configure Edit Grades
                form.CBxEditGrade.Items.RemoveAt(8);
                form.CBxEditGrade.Items.RemoveAt(7);
                form.CBxEditGrade.Items.RemoveAt(6);
                form.CBxEditGrade.Items.RemoveAt(5);
            } // end if
            //SALARY grades
            if (CurrEmp.EmpType.Equals(EType.SALARY))
            {
                //Configure Grades
                form.CBxGrade.Items.RemoveAt(8);
                form.CBxGrade.Items.RemoveAt(7);
                form.CBxGrade.Items.RemoveAt(6);
                form.CBxGrade.Items.RemoveAt(5);
                form.CBxGrade.Items.RemoveAt(4);
                //Configure Edit Grades
                form.CBxEditGrade.Items.RemoveAt(8);
                form.CBxEditGrade.Items.RemoveAt(7);
                form.CBxEditGrade.Items.RemoveAt(6);
                form.CBxEditGrade.Items.RemoveAt(5);
                form.CBxEditGrade.Items.RemoveAt(4);
            } // end if
            //SALES grades
            if (CurrEmp.EmpType.Equals(EType.SALES))
            {
                //Configure Grades
                form.CBxGrade.Items.RemoveAt(8);
                form.CBxGrade.Items.RemoveAt(7);
                //Configure Edit Grades
                form.CBxEditGrade.Items.RemoveAt(8);
                form.CBxEditGrade.Items.RemoveAt(7);
            } // end if

            //Show form
            form.ShowDialog(this);
        } // end method BtnEmpBenefits_Click()

        /// <summary>
        /// To save the employees data
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //If fields are valid
            if (AuditFields())
            {
                //Set flag to inform OnFormClosing that user initiated close
                userCloseFlag = true;

                //Update the current employee
                UpdateCurrEmp();

                //Save current employee changes
                BusinessRules.Instance[uint.Parse(CurrEmp.EmpID)] = CurrEmp;

                //Get reference to admin form
                FrmAdmin form = Application.OpenForms["FrmAdmin"] as FrmAdmin;

                //Clear the employee list in the admin form
                form.ListAllEmp.Items.Clear();

                //Re-populate the employee list in the admin form
                form.PopulateEmployeeList();

                //Refresh the employee list in the admin form
                form.ListAllEmp.Refresh();

                //Close this form
                Close();
            } // end if
        } // end method BtnSave_Click()

        /// <summary>
        /// To update the current employee using the data from the form controls
        /// </summary>
        private void UpdateCurrEmp()
        {
            //Save curr emp approval and courses
            SortedDictionary<string, Course> tempCourses = CurrEmp.EducationCourses;
            bool eduApproval = CurrEmp.EducationBenefitsApproved;

            //If emp ID has changed
            if (!CurrEmp.EmpID.Equals(TxtID.Text))
            {
                BusinessRules.Instance.Remove(uint.Parse(CurrEmp.EmpID));
            } // end if

            //Update emp by type
            if (CBxType.Text.Equals(LITERAL_HOURLY))
            {
                Hourly hourly = new Hourly(EType.HOURLY, string.Empty, string.Empty, string.Empty, string.Empty,
                    string.Empty, string.Empty, string.Empty, string.Empty, DateTime.MinValue, 0.0);

                hourly.HourlyRate = double.Parse(Regex.Replace(TxtComp1.Text, @"[$|,]", ""));
                hourly.HoursWorked = (TxtComp2.Text.Equals(string.Empty)) ? 0 : double.Parse(TxtComp2.Text);

                CurrEmp = hourly;
            } // end if
            else if (CBxType.Text.Equals(LITERAL_SALARY))
            {
                Salary salary = new Salary(EType.SALARY, string.Empty, string.Empty, string.Empty, string.Empty,
                    string.Empty, string.Empty, string.Empty, string.Empty, DateTime.MinValue, 0.0);

                salary.MonthlySalary = double.Parse(Regex.Replace(TxtComp1.Text, @"[$|,]", ""));

                CurrEmp = salary;
            } // end else-if
            else if (CBxType.Text.Equals(LITERAL_SALES))
            {
                Sales sales = new Sales(EType.SALES, string.Empty, string.Empty, string.Empty, string.Empty,
                    string.Empty, string.Empty, string.Empty, string.Empty, DateTime.MinValue, 0.0, 0.0);

                sales.MonthlySalary = double.Parse(Regex.Replace(TxtComp1.Text, @"[$|,]", ""));
                sales.CommissionRate = (double.Parse(Regex.Replace(TxtComp2.Text, @"[$|,|%]", "")) / 100);
                sales.GrossSales = (TxtComp3.Text.Equals(string.Empty)) ? 0 : double.Parse(Regex.Replace(TxtComp3.Text, @"[$|,]", ""));

                CurrEmp = sales;
            } // end else-if
            else if (CBxType.Text.Equals(LITERAL_CONTRACT))
            {
                Contract contract = new Contract(EType.CONTRACT, string.Empty, string.Empty, string.Empty, string.Empty,
                    string.Empty, string.Empty, string.Empty, string.Empty, DateTime.MinValue, 0.0, string.Empty);

                contract.ContractWage = double.Parse(Regex.Replace(TxtComp1.Text, @"[$|,]", ""));
                contract.Agency = TxtComp2.Text;

                CurrEmp = contract;
            } // end else-if

            //Update emp
            CurrEmp.EmpID = TxtID.Text;
            CurrEmp.FirstName = TxtFirstName.Text;
            CurrEmp.MiddleInitial = TxtMiddle.Text;
            CurrEmp.LastName = TxtLastName.Text;
            CurrEmp.MaritalStatus = CBxMarital.Text;
            CurrEmp.FPTime = CBxFPTime.Text;
            CurrEmp.Department = TxtDepartment.Text;
            CurrEmp.Title = TxtTitle.Text;
            CurrEmp.StartDate = Convert.ToDateTime(DTPStart.Value);
            CurrEmp.Status = CBxStatus.Text;
            CurrEmp.EducationBenefitsApproved = eduApproval;
            CurrEmp.EducationCourses = tempCourses;
        } // end method UpdateCurrEmp()

        /// <summary>
        /// To change eligible fields & compensation types based on the selected emp type
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void CBxType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Show dialog prompting user that they are about to change the emp type
            //Results in a change of benefit & comp values
            DialogResult result = MessageBox.Show(TYPE_CHANGE_MSG, TYPE_CHANGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //If user does want to change the emp type
            if (result.Equals(DialogResult.Yes))
            {
                //Clear comp txt boxes
                TxtComp1.Clear();
                TxtComp2.Clear();
                TxtComp3.Clear();
                TxtDepartment.Clear();
                TxtTitle.Clear();

                //Determine selected emp type
                if (CBxType.Text.Equals(LITERAL_HOURLY))
                {
                    //Change eligible benefits
                    TxtOvertime.Text = LITERAL_YES;
                    TxtCommission.Text = LITERAL_NO;
                    TxtBenefits.Text = LITERAL_NO;
                    TxtEduBenefits.Text = LITERAL_YES;

                    //Change comp types
                    LblComp1.Text = LITERAL_HRY_RATE;
                    LblComp2.Visible = true;
                    TxtComp2.Visible = true;
                    LblComp2.Text = LITERAL_HOURS_WORKED;
                    LblComp3.Visible = false;
                    TxtComp3.Visible = false;
                } // end if
                if (CBxType.Text.Equals(LITERAL_SALARY))
                {
                    //Change eligible benefits
                    TxtOvertime.Text = LITERAL_NO;
                    TxtCommission.Text = LITERAL_NO;
                    TxtBenefits.Text = LITERAL_YES;
                    TxtEduBenefits.Text = LITERAL_YES;

                    //Change comp types
                    LblComp1.Text = LITERAL_SAL_RATE;
                    LblComp2.Visible = false;
                    TxtComp2.Visible = false;
                    LblComp3.Visible = false;
                    TxtComp3.Visible = false;
                } // end if
                if (CBxType.Text.Equals(LITERAL_SALES))
                {
                    //Change eligible benefits
                    TxtOvertime.Text = LITERAL_NO;
                    TxtCommission.Text = LITERAL_YES;
                    TxtBenefits.Text = LITERAL_YES;
                    TxtEduBenefits.Text = LITERAL_YES;

                    //Change comp types
                    LblComp1.Text = LITERAL_SAL_RATE;
                    LblComp2.Text = LITERAL_SRY_RATE;
                    LblComp2.Visible = true;
                    LblComp2.Text = LITERAL_SRY_RATE;
                    TxtComp2.Visible = true;
                    LblComp3.Visible = true;
                    LblComp3.Text = LITERAL_SALES;
                    TxtComp3.Visible = true;
                } // end if
                if (CBxType.Text.Equals(LITERAL_CONTRACT))
                {
                    //Change eligible benefits
                    TxtOvertime.Text = LITERAL_NO;
                    TxtCommission.Text = LITERAL_NO;
                    TxtBenefits.Text = LITERAL_NO;
                    TxtEduBenefits.Text = LITERAL_NO;

                    //Change comp types
                    LblComp1.Text = LITERAL_CON_RATE;
                    LblComp2.Visible = true;
                    LblComp2.Text = LITERAL_AGENCY;
                    TxtComp2.Visible = true;
                    LblComp3.Visible = false;
                    TxtComp3.Visible = false;
                } // end if

                //Show request approval btn based on eduBfts eligibility & prior approval
                //If the emp now has education benefits (whether value has changed or not)
                if (TxtEduBenefits.Text.Equals(LITERAL_YES))
                {
                    //If the current emp already obtained eduBft approval
                    if (CurrEmp.EducationBenefitsApproved)
                    {
                        BtnEmpBenefits.Visible = true;
                    } // end if
                    else // emp still needs approval
                    {
                        //Show approval request btn
                        BtnRequestApproval.Visible = true;
                    } // end else
                } // end if
            } // end if - DialogResult
        } // end method CBxType_SelectionChangeCommitted()

        /// <summary>
        /// To authenticate user input
        /// </summary>
        /// <returns>A boolean representing the authenticity of the user input</returns>
        private bool AuditFields()
        {
            //Initialize method vars:
            Control prevControl = null;
            Employee emp = null;
            bool validID = true;

            //Iterate through GBxGeneral controls
            foreach (Control control in GBxGeneral.Controls)
            {
                //If control is a textbox
                if (control is TextBox)
                {
                    //If control text null or white space
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        //If emp is salary or hourly, ignore empty field
                        if (!CBxType.Text.Equals(LITERAL_SALARY) && (!CBxType.Text.Equals(LITERAL_HOURLY)))
                        {
                            //If control is not comp2
                            if (!control.Name.Equals(TxtComp2.Name))
                            {
                                //Get label of current control
                                prevControl = GetNextControl(control, false); // false gets previous control

                                //Show MessageBox prompting user of empty field
                                MessageBox.Show(prevControl.Text + EMPTY_FIELD_MSG, EMPTY_FIELD_CAPTION);

                                return false;
                            } // end if
                        } // end if
                    } // end if
                } // end if

                //If control is TxtFirstName field
                if (control.Name.Equals(TxtFirstName.Name))
                {
                    //If FirstName field is not valid
                    if (!Validator.Name(TxtFirstName.Text))
                    {
                        //Show MessageBox prompting user of invalid field
                        MessageBox.Show(INVALID_FNAME_MSG, INVALID_FNAME_CAPTION);

                        return false;
                    } // end if
                } // end if

                //If control is TxtMiddle field
                if (control.Name.Equals(TxtMiddle.Name))
                {
                    //If middle initial field is not valid
                    if (!Validator.MiddleInitial(TxtMiddle.Text))
                    {
                        //Show MessageBox prompting user of invalid field
                        MessageBox.Show(INVALID_MNAME_MSG, INVALID_MNAME_CAPTION);

                        return false;
                    } // end if
                } // end if

                //If control is TxtLastName field
                if (control.Name.Equals(TxtLastName.Name))
                {
                    //If LastName field is not valid
                    if (!Validator.Name(TxtLastName.Text))
                    {
                        //Show MessageBox prompting user of invalid field
                        MessageBox.Show(INVALID_LNAME_MSG, INVALID_LNAME_CAPTION);

                        return false;
                    } // end if
                } // end if

                //If control is TxtComp1 field
                if (control.Name.Equals(TxtComp1.Name))
                {
                    //If Comp1 field is not valid
                    if (!Validator.Compensation(Regex.Replace(TxtComp1.Text, @"[$|,]", "")))
                    {
                        //Get label of current control
                        prevControl = GetNextControl(control, false);

                        //Show MessageBox prompting user of invalid field
                        MessageBox.Show(prevControl.Text + INVALID_FIELD_MSG, INVALID_FIELD_CAPTION);

                        return false;
                    } // end if
                } // end if

                //If control is TxtComp2 field
                if (control.Name.Equals(TxtComp2.Name))
                {
                    //If current emp type is sales
                    if (CBxType.Text.Equals(LITERAL_SALES))
                    {
                        //If Comp2 is not a number
                        if (!Validator.Compensation(Regex.Replace(TxtComp2.Text, @"[$|,|%]", "")))
                        {
                            //Get label of current control
                            prevControl = GetNextControl(control, false);

                            //Show MessageBox prompting user of invalid field
                            MessageBox.Show(prevControl.Text + INVALID_FIELD_MSG, INVALID_FIELD_CAPTION);

                            return false;
                        } // end if
                    } // end if

                    //If current emp type is contract
                    if (CBxType.Text.Equals(LITERAL_CONTRACT))
                    {
                        //If Comp2 is not upper/lower alpha w/ spaces
                        if (!Validator.DeptTitle(TxtComp2.Text))
                        {
                            //Get label of current control
                            prevControl = GetNextControl(control, false);

                            //Show MessageBox prompting user of invalid field
                            MessageBox.Show(prevControl.Text + INVALID_FIELD_MSG2, INVALID_FIELD_CAPTION2);

                            return false;
                        } // end if
                    } // end if

                    //If current emp type is salary
                    if (CBxType.Text.Equals(LITERAL_SALARY))
                    {
                        //If the comp2 field is not empty
                        if (!control.Text.Equals(string.Empty))
                        {
                            //If Comp2 is not a number
                            if (!Validator.Compensation(Regex.Replace(TxtComp2.Text, @"[$|,]", "")))
                            {
                                //Get label of current control
                                prevControl = GetNextControl(control, false);

                                //Show MessageBox prompting user of invalid field
                                MessageBox.Show(prevControl.Text + INVALID_FIELD_MSG, INVALID_FIELD_CAPTION);

                                return false;
                            } // end if
                        } // end if
                    } // end if

                    //If current emp type is hourly
                    if (CBxType.Text.Equals(LITERAL_HOURLY))
                    {
                        //If the comp2 field is not empty
                        if (!control.Text.Equals(string.Empty))
                        {
                            //If Comp2 is not a number
                            if (!Validator.Compensation(Regex.Replace(TxtComp2.Text, @"[$|,]", "")))
                            {
                                //Get label of current control
                                prevControl = GetNextControl(control, false);

                                //Show MessageBox prompting user of invalid field
                                MessageBox.Show(prevControl.Text + INVALID_FIELD_MSG, INVALID_FIELD_CAPTION);

                                return false;
                            } // end if
                        } // end if
                    } // end if
                } // end if

                //If control is TxtID field
                if (control.Name.Equals(TxtID.Name))
                {
                    //If ID field is not a uint
                    if (!Validator.EmpID(TxtID.Text))
                    {
                        //Get label of current control
                        prevControl = GetNextControl(control, false);

                        //Show MessageBox prompting user of invalid field
                        MessageBox.Show(prevControl.Text + INVALID_ID_MSG, INVALID_ID_CAPTION);

                        return false;
                    } // end if
                    else
                    {
                        try
                        {
                            //Try to get employee using given empID (key)
                            emp = BusinessRules.Instance[uint.Parse(TxtID.Text)];

                            //If emp is NOT null, the given empID is taken
                            if (!emp.Equals(null) && !TxtID.Text.Equals(CurrEmp.EmpID))
                            {
                                //Set flag
                                validID = false;
                            } // end if
                        } // end try
                        catch (NullReferenceException)
                        {
                            //Try block accessing emp with key failed, so the empID is available
                            validID = true;
                        } // end catch

                        //If empID is taken
                        if (!validID)
                        {
                            //Get label of current control
                            prevControl = GetNextControl(control, false);

                            //Show MessageBox prompting user of invalid field
                            MessageBox.Show(prevControl.Text + TAKEN_ID_MSG, TAKEN_ID_CAPTION);

                            return false;
                        } // end if
                    } // end else
                } // end if
            } // end foreach

            //Iterate through GBxSpecific controls
            foreach (Control control in GBxSpecific.Controls)
            {
                //If control is visible & a textbox
                if (control.Visible == true && control is TextBox)
                {
                    //If control text null or white space
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        //Get label of current control
                        prevControl = GetNextControl(control, false);

                        //Show MessageBox prompting user of empty field
                        MessageBox.Show(prevControl.Text + EMPTY_FIELD_MSG, EMPTY_FIELD_CAPTION);

                        return false;
                    } // end for

                    //If control is TxtComp3 field
                    if (control.Name.Equals(TxtComp3.Name))
                    {
                        //If Comp1 field is not valid
                        if (!Validator.Compensation(Regex.Replace(TxtComp3.Text, @"[$|,]", "")))
                        {
                            //Get label of current control
                            prevControl = GetNextControl(control, false);

                            //Show MessageBox prompting user of invalid field
                            MessageBox.Show(prevControl.Text + INVALID_FIELD_MSG, INVALID_FIELD_CAPTION);

                            return false;
                        } // end if
                    } // end if

                    //If control is TxtDepartment field
                    if (control.Name.Equals(TxtDepartment.Name))
                    {
                        //If Department field is not valid
                        if (!Validator.DeptTitle(TxtDepartment.Text))
                        {
                            //Show MessageBox prompting user of invalid field
                            MessageBox.Show(INVALID_DEPT_MSG, INVALID_DEPT_CAPTION);

                            return false;
                        } // end if
                    } // end if

                    //If control is TxtTitle field
                    if (control.Name.Equals(TxtTitle.Name))
                    {
                        //If Title field is not valid
                        if (!Validator.DeptTitle(TxtTitle.Text))
                        {
                            //Show MessageBox prompting user of invalid field
                            MessageBox.Show(INVALID_TITLE_MSG, INVALID_TITLE_CAPTION);

                            return false;
                        } // end if
                    } // end if
                } // end for
            } // end foreach

            return true;
        } // end method AuditFields()

        /// <summary>
        /// To prompt the user to confirm form closing
        /// </summary>
        /// <param name="e">The event args</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Get reference to admin form
            FrmEmp_Login form = Application.OpenForms["FrmEmp_Login"] as FrmEmp_Login;

            //If this general form was initiated by the login form
            if (!Owner.Equals(form))
            {
                //If user did not initiate close
                if (!userCloseFlag)
                {
                    //Prompt user - form is closing
                    DialogResult result = MessageBox.Show(GENERAL_CLOSE_MSG, GENERAL_CLOSE_CAPTION, MessageBoxButtons.YesNo);

                    //If user does want to close
                    if (result.Equals(DialogResult.No))
                    {
                        //Cancel the event
                        e.Cancel = true;

                        //Pass event changes to base method
                        base.OnFormClosing(e);
                    } // end else
                } // end if

                userCloseFlag = false;
            } // end if
        } // end method FrmEmp_General_FormClosing()
    } // end class FrmEmp_General
} // end namespace Lab_12_JRL
