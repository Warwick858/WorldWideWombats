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
using System.Windows.Forms;

namespace Lab_12_JRL
{
    /// <summary>
    /// Add Employee Form
    /// Intended to allow the user to create a new employee object and 
    /// add it to the business rules data structure.
    /// </summary>
    public partial class FrmAdd_Emp : Form
    {
        //Declare & Initialize Constants:
        const string HOURLY = "Hourly";
        const string SALARY = "Salary";
        const string SALES = "Sales";
        const string CONTRACT = "Contract";
        const string EMPTY_FIELD_CAPTION = "Empty Field ";
        const string EMPTY_FIELD_MSG = " field is required. ";
        const string INVALID_FIELD_CAPTION = "Invalid field ";
        const string INVALID_FIELD_MSG = " type details must be a number. ";
        const string INVALID_FIELD_CAPTION2 = "Invalid field ";
        const string INVALID_FIELD_MSG2 = " must be upper or lower case letters and spaces. ";
        const string INVALID_ID_CAPTION = "Invalid ID ";
        const string INVALID_ID_MSG = " ID must be an unsigned integer, that's less than 9999999999, and 5 digits long. ";
        const string TAKEN_ID_CAPTION = "Unavailable Employee ID ";
        const string TAKEN_ID_MSG = "That employee ID is already taken. ";
        const string SUCCESS_CAPTION = "Employee Created ";
        const string SUCCESS_MSG = "Employee created successfully. \nGo to Administration to view current employees. ";
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
        const string PERCENT = "%";
        //Test Case Strings
        const string TEST_ID = "999999999";
        const string TEST_FNAME = "Mark";
        const string TEST_LNAME = "Ryan";
        const string TEST_WAGE = "18.00";

        //Declare & Initialize Class Vars:
        RadioButton selectedRBtn = new RadioButton();

        /// <summary>
        /// Constructor - initializes data members and components
        /// </summary>
        public FrmAdd_Emp()
        {
            InitializeComponent();

            //Send all CheckChanged events for radio buttons in GBxEmpType to same event handler
            RBtnHourly.CheckedChanged += new EventHandler(RBtns_CheckChanged);
            RBtnSalary.CheckedChanged += new EventHandler(RBtns_CheckChanged);
            RBtnSales.CheckedChanged += new EventHandler(RBtns_CheckChanged);
            RBtnContract.CheckedChanged += new EventHandler(RBtns_CheckChanged);
        } // end constructor

        /// <summary>
        /// To find checked EmpType radioBtn, and make corresponding controls in GBxTypeDetails visible
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void RBtns_CheckChanged(object sender, EventArgs e)
        {
            //Initialize method vars:
            RadioButton rBtn = sender as RadioButton;

            //Iterate through GBxEmpType controls and make invisible
            foreach (Control control in GBxTypeDetails.Controls)
            {
                control.Visible = false;
            } // end foreach

            //If sender is checked
            if (rBtn.Checked)
            {
                //Save Selected rBtn
                selectedRBtn = rBtn;

                //If statements to determine which rBtn is checked
                if (rBtn.Text == HOURLY)
                {
                    //Make related controls visible
                    LblHourlyRate.Visible = true;
                    TxtHourlyRate.Visible = true;
                } // end if
                else if (rBtn.Text == SALARY)
                {
                    //Make related controls visible
                    LblMonthlySalary.Visible = true;
                    TxtMonthlySalary.Visible = true;
                } // end else if
                else if (rBtn.Text == SALES)
                {
                    //Make related controls visible
                    LblCommissionRate.Visible = true;
                    TxtCommissionRate.Visible = true;
                    LblMonthlySalary.Visible = true;
                    TxtMonthlySalary.Visible = true;
                } // end else if
                else if (rBtn.Text == CONTRACT)
                {
                    //Make related controls visible
                    LblContractWage.Visible = true;
                    TxtContractWage.Visible = true;
                    LblAgency.Visible = true;
                    TxtAgency.Visible = true;
                } // end else if
            } // end if
        } // end method RBtns_CheckChanged()

        /// <summary>
        /// To call methods which authenticate user input, create employee objects, then close the form
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //If fields are valid
            if (AuditFields())
            {
                //Create Employee
                CreateEmployee();

                //Prompt user - employee created successfully
                MessageBox.Show(SUCCESS_MSG, SUCCESS_CAPTION);

                //Close FrmAdd_Emp
                Close();
            } // end for
        } // end method BtnSave_Clicked()

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

            //Iterate through GBxEmpDetails controls
            foreach (Control control in GBxEmpDetails.Controls)
            {
                //If control is a textbox
                if (control is TextBox)
                {
                    //If control text null or white space
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        //Get label of current control
                        prevControl = GetNextControl(control, false); // false gets previous control

                        //Show MessageBox prompting user of empty field
                        MessageBox.Show(prevControl.Text + EMPTY_FIELD_MSG, EMPTY_FIELD_CAPTION);

                        return false;
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
                            if (!emp.Equals(null))
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

            //Iterate through GBxTypeDetails controls
            foreach (Control control in GBxTypeDetails.Controls)
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

                    //If emp will be a contractor
                    if (selectedRBtn.Text.Equals(CONTRACT))
                    {
                        //If current control is contract wage
                        if (control.Name.Equals(TxtContractWage.Name))
                        {
                            //If contract wage is invalid
                            if (!Validator.Compensation(TxtContractWage.Text))
                            {
                                //Get label of current control
                                prevControl = GetNextControl(control, false);

                                //Show MessageBox prompting user of invalid field
                                MessageBox.Show(prevControl.Text + INVALID_FIELD_MSG, INVALID_FIELD_CAPTION);

                                return false;
                            } // end if
                        } // end if
                         //If current control is agency
                        if (control.Name.Equals(TxtAgency.Name))
                        {
                            //If agency is invalid
                            if (!Validator.DeptTitle(TxtAgency.Text))
                            {
                                //Get label of current control
                                prevControl = GetNextControl(control, false);

                                //Show MessageBox prompting user of invalid field
                                MessageBox.Show(prevControl.Text + INVALID_FIELD_MSG2, INVALID_FIELD_CAPTION2);

                                return false;
                            } // end if
                        } // end if
                    } // end if
                    //If type details field is not a double
                    else if (!Validator.Compensation(control.Text))
                    {
                        //Get label of current control
                        prevControl = GetNextControl(control, false);

                        //Show MessageBox prompting user of invalid field
                        MessageBox.Show(prevControl.Text + INVALID_FIELD_MSG, INVALID_FIELD_CAPTION);

                        return false;
                    } // end if
                } // end for
            } // end foreach

            return true;
        } // end method AuditFields()

        /// <summary>
        /// To create the employee object based on the selected employee type
        /// </summary>
        private void CreateEmployee()
        {
            //Create employee & add to BusinesssRules
            //HOURLY EMP
            if (selectedRBtn.Text == HOURLY)
            {
                Hourly hourlyEmp = new Hourly(EType.HOURLY, TxtID.Text, TxtFirstName.Text, TxtMiddle.Text, TxtLastName.Text, 
                    CBxMarital.Text,  CBxFPTime.Text, TxtDepartment.Text, TxtTitle.Text, CldrStartDate.SelectionStart, Convert.ToDouble(TxtHourlyRate.Text));
                BusinessRules.Instance.Add(uint.Parse(hourlyEmp.EmpID), hourlyEmp);
            } // end if
            //SALARY EMP
            if (selectedRBtn.Text == SALARY)
            {
                Salary salaryEmp = new Salary(EType.SALARY, TxtID.Text, TxtFirstName.Text, TxtMiddle.Text, TxtLastName.Text,
                    CBxMarital.Text, CBxFPTime.Text, TxtDepartment.Text, TxtTitle.Text, CldrStartDate.SelectionStart, Convert.ToDouble(TxtMonthlySalary.Text));
                BusinessRules.Instance.Add(uint.Parse(salaryEmp.EmpID), salaryEmp);
            } // end if
            //SALES EMP
            if (selectedRBtn.Text == SALES)
            {
                Sales salesEmp = new Sales(EType.SALES, TxtID.Text, TxtFirstName.Text, TxtMiddle.Text, TxtLastName.Text,
                    CBxMarital.Text, CBxFPTime.Text, TxtDepartment.Text, TxtTitle.Text, CldrStartDate.SelectionStart, Convert.ToDouble(TxtMonthlySalary.Text), Convert.ToDouble(TxtCommissionRate.Text));
                BusinessRules.Instance.Add(uint.Parse(salesEmp.EmpID), salesEmp);
            } // end if
            //CONTRACT EMP
            if (selectedRBtn.Text == CONTRACT)
            {
                Contract contractEmp = new Contract(EType.CONTRACT, TxtID.Text, TxtFirstName.Text, TxtMiddle.Text, TxtLastName.Text,
                    CBxMarital.Text, CBxFPTime.Text, TxtDepartment.Text, TxtTitle.Text, CldrStartDate.SelectionStart, 
                    Convert.ToDouble(TxtContractWage.Text), TxtAgency.Text);
                BusinessRules.Instance.Add(uint.Parse(contractEmp.EmpID), contractEmp);
            } // end if
        } // end method CreateEmployee()

        /// <summary>
        /// To update the PBxEmpIDState image to reflect whether the given empID is good or bad
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            //Declare vars:
            Employee emp;

            //Ensure the given empID is an uint
            //if (uint.TryParse(TxtID.Text, out testUInt))
            //If ID field is not a uint
            if (Validator.EmpID(TxtID.Text))
            {
                try
                {
                    //Try to get employee using given empID (key)
                    emp = BusinessRules.Instance[uint.Parse(TxtID.Text)];

                    //If emp is NOT null, the given empID is taken
                    if (!emp.Equals(null))
                    {
                        //Key is taken, set frowny image
                        PBxEmpIDState.BackgroundImage = Properties.Resources.sad;
                    } // end if
                } // end try
                catch (NullReferenceException)
                {
                    //Key is available, set smiley image
                    PBxEmpIDState.BackgroundImage = Properties.Resources.happy;
                } // end catch
            } // end if
            else // empID is not an unisigned int in string form
            {
                //Key is bad, set frowny
                PBxEmpIDState.BackgroundImage = Properties.Resources.sad;
            } // end else
        } // end method TxtID_TextChanged()

        /// <summary>
        /// To show the PBxEmpIDState image if it isnt already visible
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void TxtID_Enter(object sender, EventArgs e)
        {
            PBxEmpIDState.Visible = true;
        } // end method TxtID_Enter()

        /// <summary>
        /// To hide the PBxEmpIDState if the TxtEmpID box is empty
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void TxtID_Leave(object sender, EventArgs e)
        {
            //If the TxtEmpID box is empty
            if (string.IsNullOrWhiteSpace(TxtID.Text))
            {
                PBxEmpIDState.Visible = false;
            } // end if
        } // end method TxtID_Leave()

        /// <summary>
        /// To reset all controls on the add_emp form to their defaults
        /// </summary>
        private void ResetFields()
        {
            //Clear all txtboxes and reset radioBtns to HOURLY
            TxtID.Clear();
            TxtFirstName.Clear();
            TxtLastName.Clear();
            TxtHourlyRate.Clear();
            TxtMonthlySalary.Clear();
            TxtCommissionRate.Clear();
            TxtContractWage.Clear();
            RBtnHourly.Checked = true;
        } // end method ResetFields()

        //************************************************************FORM TEST METHODS*************************************************

        /// <summary>
        /// To test methods AuditFields() and BtnSave_Click()
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void MnuEmptyEmpField_Click(object sender, EventArgs e)
        {
            ResetFields();

            //Fill text boxes with data
            TxtID.Text = TEST_ID;
            TxtFirstName.Text = TEST_FNAME;
            TxtHourlyRate.Text = TEST_WAGE;

            //Attempt to save new employee
            BtnSave_Click(BtnSave, EventArgs.Empty);

            ResetFields();
        } // end method MnuEmptyEmpField_Click()

        /// <summary>
        /// To test methods AuditFields() and BtnSave_Click()
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void MnuEmptyTypeField_Click(object sender, EventArgs e)
        {
            //Fill text boxes with data
            TxtID.Text = TEST_ID;
            TxtFirstName.Text = TEST_FNAME;
            TxtLastName.Text = TEST_LNAME;

            //Attempt to save new employee
            BtnSave_Click(BtnSave, EventArgs.Empty);

            ResetFields();
        } // end method MnuEmptyTypeField_Click()

        /// <summary>
        /// To test methods AuditFields() and BtnSave_Click()
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void MnuUnavailableEmpID_Click(object sender, EventArgs e)
        {
            ResetFields();

            //Fill text boxes with data
            TxtID.Text = 0.ToString();
            TxtFirstName.Text = TEST_FNAME;
            TxtLastName.Text = TEST_LNAME;
            TxtHourlyRate.Text = TEST_WAGE;

            //Attempt to save new employee
            BtnSave_Click(BtnSave, EventArgs.Empty);

            ResetFields();
        } // end method MnuUnavailableEmpID_Click()
    } // end class FrmAdd_Emp
} // end namespace Lab_12_JRL
