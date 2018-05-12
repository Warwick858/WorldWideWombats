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
    /// Administration Form
    /// Intended for the user to view existing employees
    /// </summary>
    public partial class FrmAdmin : Form
    {
        //Declare & Initialize Constants:
        const string TEST_ID = "3";
        const string TEST_LNAME = "Doe";
        const string INVALID_ID_CAPTION = "Invalid ID ";
        const string INVALID_ID_MSG = " ID must be an unsigned integer, that's less than 9999999999. ";
        const string INVALID_LNAME_CAPTION = "Invalid Last Name ";
        const string INVALID_LNAME_MSG = "Last name cannot contain anything but upper or lower case letters. ";
        const string INVALID_SEARCH_CAPTION = "Invalid Search ";
        const string INVALID_SEARCH_MSG = "The given search values could not be found. ";
        const string LITERAL_SRY_RATE = "Commission Rate: ";
        const string LITERAL_CON_RATE = "Contract Wage: ";
        const string LITERAL_SAL_RATE = "Monthly Salary: ";
        const string LITERAL_HRY_RATE = "Hourly Rate: ";
        const string LITERAL_HOURS_WORKED = "Hours Worked: ";
        const string LITERAL_AGENCY = "Agency: ";
        const string LITERAL_SALES = "Sales: ";

        /// <summary>
        /// FrmAdmin Constructor - initializes data members and components
        /// </summary>
        public FrmAdmin()
        {
            InitializeComponent();

            //Fill the ListView with data from all employees
            PopulateEmployeeList();

            //Clear selected indices from listview whenever it loses focus
            ListAllEmp.LostFocus += (o, e) => ListAllEmp.SelectedIndices.Clear();
        } // end constructor

        /// <summary>
        /// To populate the ListAllEmp list view with all employee data
        /// </summary>
        public void PopulateEmployeeList()
        {
            //Get all employee keys
            var bizKeys = BusinessRules.Instance.Keys;

            //Foreach key in employees
            foreach (uint key in bizKeys)
            {
                //Save the current employee
                Employee tempEmp = BusinessRules.Instance[key];

                //Save primary data members to a string array
                string[] rowDetails = { tempEmp.EmpID, tempEmp.FirstName, tempEmp.LastName, tempEmp.EmpType.ToString(),
                    tempEmp.OvertimeEligible ? "Yes" : "No", tempEmp.CommissionEligible ? "Yes" : "No",
                    tempEmp.BenefitsEligible ? "Yes" : "No", tempEmp.EducationBenefitsEligible ? "Yes" : "No", };

                //Save rowDetails as a ListViewItem
                var row = new ListViewItem(rowDetails);

                //Add row to ListView
                ListAllEmp.Items.Add(row);
            } // end foreach
        } // end method PopulateEmployeeList()

        /// <summary>
        /// To sort the column subitems in alphanumeric-ascending
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The column click event args</param>
        private void ListAllEmp_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            ListAllEmp.ListViewItemSorter = new ListViewSort(e.Column);

            // Call the sort method to manually sort.
            ListAllEmp.Sort();
        } // end method ListAllEmp_ColumnClick()

        /// <summary>
        /// To call helper function Search()
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        } // end method BtnSearch_Click()

        /// <summary>
        /// To find the search terms in the list
        /// </summary>
        private void Search()
        {
            //Declare & Init vars:
            ListViewItem item1 = null;
            ListViewItem item2 = null;

            //If an ID is given
            if (!String.IsNullOrWhiteSpace(TxtID.Text))
            {
                //Validate given empID
                if (Validator.EmpID(TxtID.Text))
                {
                    item1 = ListAllEmp.FindItemWithText(TxtID.Text, true, 0);

                    try
                    {
                        ListAllEmp.Items[item1.Index].Focused = true;
                        ListAllEmp.Items[item1.Index].Selected = true;
                        ListAllEmp.Select();
                    } // end try
                    catch (NullReferenceException)
                    {
                        //Prompt user, search values not found
                        MessageBox.Show(INVALID_SEARCH_MSG, INVALID_SEARCH_CAPTION);
                    } // end catch

                } // end if
                else // empID is invalid
                {
                    //Show MessageBox prompting user of invalid field
                    MessageBox.Show(INVALID_ID_MSG, INVALID_ID_CAPTION);
                } // end else
            } // end if

            //If a last name is given
            if (!String.IsNullOrWhiteSpace(TxtLName.Text))
            {
                //Validate given last name
                if (Validator.Name(TxtLName.Text))
                {
                    item2 = ListAllEmp.FindItemWithText(TxtLName.Text, true, 0);

                    try
                    {
                        ListAllEmp.Items[item2.Index].Focused = true;
                        ListAllEmp.Items[item2.Index].Selected = true;
                        ListAllEmp.Select();
                    } // end try
                    catch (NullReferenceException)
                    {
                        //Prompt user, search values not found
                        MessageBox.Show(INVALID_SEARCH_MSG, INVALID_SEARCH_CAPTION);
                    } // end catch
                } // end if
                else // last name is invalid
                {
                    //Show MessageBox prompting user of invalid field
                    MessageBox.Show(INVALID_LNAME_MSG, INVALID_LNAME_CAPTION);
                } // end else
            } // end if
        } // end method Search()

        /// <summary>
        /// To clear the ID and last name search fields
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            //Clear search fields
            TxtID.Clear();
            TxtLName.Clear();
        } // end method BtnClear_Click()

        /// <summary>
        /// To find the item that was clicked on, then show a general employee form with item's data
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void ListAllEmp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Create new Employee
            Employee emp = null;

            //Cast sender object to ListView
            ListView list = (ListView)sender;

            //Use hit test to find coordinates and item of mouse double click
            ListViewItem item = list.HitTest(e.Location).Item;

            try
            {
                //Get the employee object of the selected item
                emp = BusinessRules.Instance[uint.Parse(item.Text)];

                //Create new instance of the form
                FrmEmp_General form = new FrmEmp_General();

                //Set form's CurrEmp
                form.CurrEmp = emp;

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
                    form.TxtComp2.Text = hourly.HoursWorked.ToString();
                    form.LblComp2.Text = LITERAL_HOURS_WORKED;
                    form.LblComp3.Visible = false;
                    form.TxtComp3.Visible = false;
                } // end else if
                else if (emp.EmpType.Equals(EType.SALARY))
                {
                    Salary salary = (Salary)emp;
                    form.TxtComp1.Text = salary.MonthlySalary.ToString("c", CultureInfo.CreateSpecificCulture("en-US"));
                    form.LblComp1.Text = LITERAL_SAL_RATE;
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

                //Show request approval btn based on eduBfts eligibility & prior approval
                if (emp.EducationBenefitsEligible && emp.EducationBenefitsApproved)
                {
                    form.BtnEmpBenefits.Visible = true;
                } // end if

                //Enable all controls for admin editing
                foreach (Control control in form.GBxGeneral.Controls)
                {
                    control.Enabled = true;
                } // end foreach
                foreach (Control control in form.GBxSpecific.Controls)
                {
                    control.Enabled = true;
                } // end foreach

                //Show save btn
                form.BtnSave.Visible = true;

                //Show form
                form.ShowDialog(this);
            } // end try
            catch (NullReferenceException)
            {
                //do nothing
            } // end catch
        } // end method ListAllEmp_MouseDoubleClick()

        /// <summary>
        /// To show the add employee form
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void PBxAddEmp_Click(object sender, EventArgs e)
        {
            //Create new instance of FrmAdd_Emp
            FrmAdd_Emp addForm = new FrmAdd_Emp();

            //Show form
            addForm.ShowDialog(this);

            //Clear the employee list
            ListAllEmp.Items.Clear();

            //Re-populate the employee list
            PopulateEmployeeList();
        } // end method PBxAddEmp_Click()

        /// <summary>
        /// To populate the search fields with test data and execute search
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void MnuTestSearch_Click(object sender, EventArgs e)
        {
            //Fill text boxes
            TxtID.Text = TEST_ID;
            TxtLName.Text = TEST_LNAME;

            //Initiate Search
            Search();
        } // end method MnuTestSearch_Click()
    } // end class FrmAdmin
} // end namespace Lab_12_JRL
