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
using System.Globalization;
using System.Windows.Forms;

namespace Lab_12_JRL
{
    /// <summary>
    /// The Employee Login form
    /// </summary>
    public partial class FrmEmp_Login : Form
    {
        //Declare & Initialize Constants:
        const string INVALID_EMPLOYEE_CAPTION = "Employee Not Found ";
        const string INVALID_EMPLOYEE_MSG = "The given employee was not found. ";
        const string FORMER_EMPLOYEE_CAPTION = "Former Employee ";
        const string FORMER_EMPLOYEE_MSG = "Those credentials are associated with a former employee. \nAccess Denied. ";
        const string INVALID_ID_CAPTION = "Invalid ID ";
        const string INVALID_ID_MSG = " ID must be an unsigned integer, that's less than 9999999999. ";
        const string INVALID_LNAME_CAPTION = "Invalid Last Name ";
        const string INVALID_LNAME_MSG = "Last name cannot contain anything but upper or lower case letters. ";
        const string LITERAL_SRY_RATE = "Commission Rate: ";
        const string LITERAL_CON_RATE = "Contract Wage: ";
        const string LITERAL_SAL_RATE = "Monthly Salary: ";
        const string LITERAL_HRY_RATE = "Hourly Rate: ";
        const string LITERAL_HOURS_WORKED = "Hours Worked: ";
        const string LITERAL_AGENCY = "Agency: ";
        const string LITERAL_SALES = "Sales: ";
        const string FORMER = "Former";
        //Test Case Strings
        const string TEST_ID = "00004";
        const string TEST_LNAME = "Wombat";

        /// <summary>
        /// The default constructor
        /// </summary>
        public FrmEmp_Login()
        {
            InitializeComponent();
        } // end constructor

        /// <summary>
        /// To fill the fields and execute login
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void MnuTestLogin_Click(object sender, EventArgs e)
        {
            //Fill text boxes
            TxtID.Text = TEST_ID;
            TxtLName.Text = TEST_LNAME;

            //Authenticate employee
            AuthEmp();
        } // end method MnuTestLogin()

        /// <summary>
        /// To call helper function AuthEmp()
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //Authenticate employee
            AuthEmp();
        } // end method BtnLogin_Click()

        /// <summary>
        /// To validate the credentials, if good, general employee form is generated with users data
        /// </summary>
        private void AuthEmp()
        {
            //Declare & init vars:
            Employee emp = null;

            //COMMENTED OUT B/C LOGIN SHOULD ONLY BE VALIDATED FOR AUTHENTICITY
            ////Validate empID
            //if (!Validator.EmpID(TxtID.Text))
            //{
            //    //Prompt user, EmpID was invalid
            //    MessageBox.Show(INVALID_ID_MSG, INVALID_ID_CAPTION);

            //    return;
            //} // end if
            //if (!Validator.Name(TxtLName.Text))
            //{
            //    //Prompt user, invalid last name
            //    MessageBox.Show(INVALID_LNAME_MSG, INVALID_LNAME_CAPTION);

            //    return;
            //} // end else if

            try
            {
                //Try to get employee using given empID (key)
                emp = BusinessRules.Instance[uint.Parse(TxtID.Text)];

                //If emp is NOT null - throws exception if null
                if (!emp.Equals(null))
                {
                    //If employee is a former one
                    if (emp.Status.Equals(FORMER))
                    {
                        //Prompt user, credentials are those of a former emp
                        MessageBox.Show(FORMER_EMPLOYEE_MSG, FORMER_EMPLOYEE_CAPTION);
                        return;
                    } // end if

                    //If the given last name did NOT match that of the ID
                    if (!emp.LastName.Equals(TxtLName.Text))
                    {
                        //Prompt user - provided employee credentials were invalid
                        MessageBox.Show(INVALID_EMPLOYEE_MSG, INVALID_EMPLOYEE_CAPTION);
                    } // end if
                    else // ID & last name correspond
                    {
                        //Create new instance of FrmEmp_General form
                        FrmEmp_General form = new FrmEmp_General();

                        //Set values in form
                        form.CurrEmp = emp;
                        form.TxtID.Text = emp.EmpID;
                        form.TxtFirstName.Text = emp.FirstName;
                        form.TxtMiddle.Text = emp.MiddleInitial;
                        form.TxtLastName.Text = emp.LastName;
                        form.CBxType.Text = emp.EmpType.ToString();
                        form.CBxMarital.Text = emp.MaritalStatus;
                        form.CBxFPTime.Text = emp.FPTime;
                        form.TxtDepartment.Text = emp.Department;
                        form.TxtTitle.Text = emp.Title;
                        form.DTPStart.Value = emp.StartDate;
                        form.CBxStatus.Text = emp.Status;
                        form.TxtOvertime.Text = (emp.OvertimeEligible == true) ? "Yes" : "No";
                        form.TxtCommission.Text = (emp.CommissionEligible == true) ? "Yes" : "No";
                        form.TxtBenefits.Text = (emp.BenefitsEligible == true) ? "Yes" : "No";
                        form.TxtEduBenefits.Text = (emp.EducationBenefitsEligible == true) ? "Yes" : "No";

                        //Set form emp compensation type
                        if (emp.EmpType.Equals(EType.HOURLY))
                        {
                            Hourly hourly = (Hourly)emp;
                            form.TxtComp1.Text = hourly.HourlyRate.ToString("c", CultureInfo.CreateSpecificCulture("en-US"));
                            form.LblComp1.Text = LITERAL_HRY_RATE;
                            form.LblComp2.Visible = true;
                            form.TxtComp2.Visible = true;
                            form.LblComp2.Text = LITERAL_HOURS_WORKED;
                            form.LblComp3.Visible = false;
                            form.TxtComp3.Visible = false;
                        } // end else if
                        else if (emp.EmpType.Equals(EType.SALARY))
                        {
                            Salary salary = (Salary)emp;
                            form.TxtComp1.Text = salary.MonthlySalary.ToString("c", CultureInfo.CreateSpecificCulture("en-US"));
                            form.LblComp1.Text = LITERAL_SRY_RATE;
                            form.LblComp2.Visible = false;
                            form.TxtComp2.Visible = false;
                            form.LblComp3.Visible = false;
                            form.TxtComp3.Visible = false;
                        } // end else if
                        else if (emp.EmpType.Equals(EType.SALES))
                        {
                            Sales sales = (Sales)emp;
                            form.TxtComp1.Text = sales.MonthlySalary.ToString("c", CultureInfo.CreateSpecificCulture("en-US"));
                            form.TxtComp2.Text = ((sales.CommissionRate * 100).ToString() + "%");
                            form.LblComp1.Text = LITERAL_SAL_RATE;
                            form.LblComp2.Text = LITERAL_SRY_RATE;
                            form.LblComp2.Visible = true;
                            form.TxtComp2.Visible = true;
                            form.LblComp3.Text = LITERAL_SALES;
                            form.LblComp3.Visible = true;
                            form.TxtComp3.Visible = true;
                            form.TxtComp3.Text = sales.GrossSales.ToString("c", CultureInfo.CreateSpecificCulture("en-US"));
                        } // end else if
                        else if (emp.EmpType.Equals(EType.CONTRACT))
                        {
                            Contract contract = (Contract)emp;
                            form.TxtComp1.Text = contract.ContractWage.ToString("c", CultureInfo.CreateSpecificCulture("en-US"));
                            form.LblComp1.Text = LITERAL_CON_RATE;
                            form.LblComp2.Visible = true;
                            form.TxtComp2.Visible = true;
                            form.LblComp2.Text = LITERAL_AGENCY;
                            form.TxtComp2.Text = contract.Agency;
                            form.LblComp3.Visible = false;
                            form.TxtComp3.Visible = false;
                        } // end else if

                        //If employee is eligible for benefits
                        if (emp.EducationBenefitsEligible)
                        {
                            //Show the approval request btn
                            form.BtnRequestApproval.Visible = true;

                            //If the employee is eligible, but has already obtained approval
                            if (emp.EducationBenefitsApproved)
                            {
                                //Hide BtnRequestApproval
                                form.BtnRequestApproval.Visible = false;
                                //Show BtnEmpBenefits
                                form.BtnEmpBenefits.Visible = true;
                            } // end if
                        } // end if

                        //Show form
                        form.ShowDialog(this);
                        form.Activate();
                    } // end else
                } // end if
            } // end try
            catch // employee INVALID
            {
                //Prompt user - provided employee credentials were invalid
                MessageBox.Show(INVALID_EMPLOYEE_MSG, INVALID_EMPLOYEE_CAPTION);
            } // end catch
        } // end method AuthEmp()

        /// <summary>
        /// To close this form
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        } // end method BtnCancel_Click()

        /// <summary>
        /// To close the login form once the user closes the emp_general form
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void FrmEmp_Login_Deactivate(object sender, EventArgs e)
        {
            Close();
        } // end method FrmEmp_Login_Deactivate()
    } // end class FrmEmp_Login
} // end namespace Lab_12_JRL
