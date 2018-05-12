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
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab_12_JRL
{
    /// <summary>
    /// The Employee Benefits Form
    /// </summary>
    public partial class FrmEmp_Benefits : Form
    {
        //Declare & Initialize Constants:
        const string COURSE_SAVED_CAPTION = "Course Saved ";
        const string COURSE_SAVED_MSG = "Course save successful. ";
        const string COURSE_DELETED_CAPTION = "Course Deleted ";
        const string COURSE_DELETED_MSG = "Course deleted. ";
        const string COURSE_SUBMIT_CAPTION = "CAUTION ";
        const string COURSE_SUBMIT_MSG = "";
        const string INVALID_INSTITUTION_CAPTION = "Invalid Institution ";
        const string INVALID_INSTITUTION_MSG = "Institution field required. ";
        const string INVALID_GRADE_CAPTION = "Invalid Course Grade ";
        const string INVALID_GRADE_MSG = "Course Grade field required. ";
        const string INVALID_CREDITS_CAPTION = "Invalid Credit Amount ";
        const string INVALID_CREDITS_MSG = "Credits field required. ";
        const string INVALID_EDIT_CAPTION = "No Course Selected ";
        const string INVALID_EDIT_MSG = "Please select a course to edit from the list of pending courses. ";
        const string INVALID_DELETE_CAPTION = "Invalid Course Delete ";
        const string INVALID_DELETE_MSG = "Please select a course to delete from the list of pending courses. ";
        const string COURSES_COMPED_CAPTION = "Courses Compensated ";
        const string COURSES_COMPED_MSG = "Courses evauluated successfully, any comped courses have been moved to 'Compensated Courses' . ";
        const string COMP_EXCEEDED_CAPTION = "Compensation Limit Reached ";
        const string COMP_EXCEEDED_MSG = "No courses have been compensated, \nyou have reached your course compensation limit this semester. ";
        const string PENDING_EXCEEDS_CAPTION = "Pending Courses Exception ";
        const string PENDING_EXCEEDS_MSG = " compensation credits remain this semester, " + 
            "\nbut all pending courses contain credits which exceed this amount. \n" + 
            "No courses have been comped. ";
        const string NO_PENDING_CAPTION = "No Pending Courses ";
        const string NO_PENDING_MSG = "There are no courses pending to submit. ";
        const string COURSE_ADDED_CAPTION = "Course Added ";
        const string COURSE_ADDED_MSG = "The course was added successfully and has been moved to pending courses. ";
        const string INVALID_COURSE_CAPTION = "Course ID Taken ";
        const string INVALID_COURSE_MSG = "The course ID you entered is already present in your list of courses. ";
        const string INVALID_COURSE_ID_CAPTION = "Invalid Course ID ";
        const string INVALID_COURSE_ID_MSG = "Course ID can only contain numbers and letters. ";
        const string INVALID_COURSE_DESC_CAPTION = "Invalid Course Description ";
        const string INVALID_COURSE_DESC_MSG = "Course description can only contain letters and special characters: _.#+,/)( ";
        const string COURSE_ID_REQ_CAPTION = "Course ID Required ";
        const string COURSE_ID_REQ_MSG = "Please enter a course ID. ";
        const string COURSE_DESC_REQ_CAPTION = "Course Description Required ";
        const string COURSE_DESC_REQ_MSG = "Please enter a course description. ";
        const string FULL_CREDIT = "FULL";
        const int THREE = 3;
        //Test Data
        const string TEST_UVU = "Utah Valley University";
        const string TEST_ID = "CS3260";
        const string TEST_DESC = "Advanced C#";
        const string TEST_GRADE = "A";
        const string TEST_CREDITS = "3";
        //Define Class Properties:
        public Employee CurrEmp { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public FrmEmp_Benefits()
        {
            InitializeComponent();
        } // end constructor

        /// <summary>
        /// To call the helper function AddCourse()
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            AddCourse();
        } // end method BtnAddCourse_Click()

        /// <summary>
        /// Helper function for BtnAddCourse_Click() to support testing
        /// </summary>
        private void AddCourse()
        {
            //If institution is not selected, prompt user
            if (string.IsNullOrWhiteSpace(CBxInstitution.Text))
            {
                MessageBox.Show(INVALID_INSTITUTION_MSG, INVALID_INSTITUTION_CAPTION);

                return;
            } // end if
            //If ID is not given, prompt user
            if (string.IsNullOrWhiteSpace(TxtID.Text))
            {
                MessageBox.Show(COURSE_ID_REQ_MSG, COURSE_ID_REQ_CAPTION);

                return;
            } // end if
              //If description is not given, prompt user
            if (string.IsNullOrWhiteSpace(TxtDescription.Text))
            {
                MessageBox.Show(COURSE_DESC_REQ_MSG, COURSE_DESC_REQ_CAPTION);

                return;
            } // end if
            //If grade is not selected, prompt user
            if (string.IsNullOrWhiteSpace(CBxGrade.Text))
            {
                MessageBox.Show(INVALID_GRADE_MSG, INVALID_GRADE_CAPTION);

                return;
            } // end if
            //If credits are not selected, prompt user
            if (string.IsNullOrWhiteSpace(CBxCredits.Text))
            {
                MessageBox.Show(INVALID_CREDITS_MSG, INVALID_CREDITS_CAPTION);

                return;
            } // end if
            //If course ID is invalid
            if (!Validator.CourseID(TxtID.Text))
            {
                //Prompt user, invalid course ID
                MessageBox.Show(INVALID_COURSE_ID_MSG, INVALID_COURSE_ID_CAPTION);

                return;
            } // end if
            //If course desc is invalid
            if (!Validator.CourseDesc(TxtDescription.Text))
            {
                //Prompt user, invalid course desc
                MessageBox.Show(INVALID_COURSE_DESC_MSG, INVALID_COURSE_DESC_CAPTION);

                return;
            } // end if

            //Check to ensure course isn't already present
            //Try to get course using given CourseID (key)
            if (BusinessRules.Instance[uint.Parse(CurrEmp.EmpID)].EducationCourses.ContainsKey(TxtID.Text))
            {
                //Prompt user, the course ID already exists
                MessageBox.Show(INVALID_COURSE_MSG, INVALID_COURSE_CAPTION);
            } // end if
            else
            {
                //Create course and add to employees courses
                CurrEmp.EducationCourses.Add(TxtID.Text,
                    new Course(TxtID.Text, TxtDescription.Text, CBxGrade.Text, int.Parse(CBxCredits.Text)));

                //Prompt user, course added
                MessageBox.Show(COURSE_ADDED_MSG, COURSE_ADDED_CAPTION);

                AddClear();
            } // end else
        } // end method AddCourse()

        /// <summary>
        /// To call the AddClear() helper function
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void BtnAddClear_Click(object sender, EventArgs e)
        {
            AddClear();
        } // end method BtnAddClear_Click()

        /// <summary>
        /// To clear the add course fields
        /// </summary>
        private void AddClear()
        {
            //Clear all Add fields
            CBxInstitution.ResetText();
            TxtID.Clear();
            TxtDescription.Clear();
            CBxGrade.SelectedIndex = -1;
            CBxGrade.Text = string.Empty;
            CBxCredits.SelectedIndex = -1;
            CBxCredits.Text = string.Empty;
        } // end method AddClear()

        /// <summary>
        /// To call the helper function Edit()
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        } // end method BtnEdit_Click()

        /// <summary>
        /// Helper function for BtnEdit_Click() to support testing
        /// </summary>
        private void Edit()
        {
            //Get selected course from list
            ListViewItem item = ListPendingCourses.FocusedItem;

            try
            {
                //Set the selected courses data in edit boxes
                TxtEditID.Text = item.SubItems[1].Text;
                TxtEditDesc.Text = item.SubItems[2].Text;
                CBxEditGrade.Text = item.SubItems[3].Text;
                CBxEditCredits.Text = item.SubItems[4].Text;

                //Show edit control buttons
                BtnEditClear.Visible = true;
                BtnSave.Visible = true;
            }
            catch (NullReferenceException) // no item selected
            {
                MessageBox.Show(INVALID_EDIT_MSG, INVALID_EDIT_CAPTION);
            } // end else
        } // end method Edit()

        /// <summary>
        /// To call the helper method Clear()
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void BtnEditClear_Click(object sender, EventArgs e)
        {
            EditClear();
        } // end method BtnEditClear_Click()

        /// <summary>
        /// To clear the edit text boxes
        /// </summary>
        private void EditClear()
        {
            //Clear edit text boxes
            TxtEditID.Clear();
            TxtEditDesc.Clear();
            CBxEditGrade.SelectedIndex = -1;
            CBxEditGrade.Text = string.Empty;
            CBxEditCredits.SelectedIndex = -1;
            CBxEditCredits.Text = string.Empty;

            //Hide edit control buttons
            BtnEditClear.Visible = false;
            BtnSave.Visible = false;
        } // end method EditClear()

        /// <summary>
        /// To save the changed emp course values
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //If ID is not given, prompt user
            if (string.IsNullOrWhiteSpace(TxtEditID.Text))
            {
                MessageBox.Show(COURSE_ID_REQ_MSG, COURSE_ID_REQ_CAPTION);

                return;
            } // end if
              //If description is not given, prompt user
            if (string.IsNullOrWhiteSpace(TxtEditDesc.Text))
            {
                MessageBox.Show(COURSE_DESC_REQ_MSG, COURSE_DESC_REQ_CAPTION);

                return;
            } // end if
            //If grade is not selected, prompt user
            if (string.IsNullOrWhiteSpace(CBxEditGrade.Text))
            {
                MessageBox.Show(INVALID_GRADE_MSG, INVALID_GRADE_CAPTION);

                return;
            } // end if
            //If credits are not selected, prompt user
            if (string.IsNullOrWhiteSpace(CBxEditCredits.Text))
            {
                MessageBox.Show(INVALID_CREDITS_MSG, INVALID_CREDITS_CAPTION);

                return;
            } // end if
            //If course ID is invalid
            if (!Validator.CourseID(TxtEditID.Text))
            {
                //Prompt user, invalid course ID
                MessageBox.Show(INVALID_COURSE_ID_MSG, INVALID_COURSE_ID_CAPTION);

                return;
            } // end if
            //If course desc is invalid
            if (!Validator.CourseDesc(TxtEditDesc.Text))
            {
                //Prompt user, invalid course desc
                MessageBox.Show(INVALID_COURSE_DESC_MSG, INVALID_COURSE_DESC_CAPTION);
                
                return;
            } // end if

            //Create new Course with edit data
            Course tempCourse = new Course(TxtEditID.Text, TxtEditDesc.Text, CBxEditGrade.Text, int.Parse(CBxEditCredits.Text));

            //Save the employee being edited as a listview item
            ListViewItem item = ListPendingCourses.FocusedItem;

            //If item is selected
            if (!item.Equals(null))
            {
                //Save the original course ID using the items courseID
                var eduCourseKey = CurrEmp.EducationCourses.Where(x => x.Key.Equals(item.SubItems[1].Text)).First();

                //Save updated version of education course to dictionary
                BusinessRules.Instance[uint.Parse(CurrEmp.EmpID)].EducationCourses[eduCourseKey.Key] = tempCourse;

                //Re-populate the list of courses
                PopulatePendingCourses();

                //Clear edit text boxes
                EditClear();

                //Prompt user course was saved
                MessageBox.Show(COURSE_SAVED_MSG, COURSE_SAVED_CAPTION);
            } // end if
            else // no item selected
            {
                MessageBox.Show(INVALID_EDIT_MSG, INVALID_EDIT_CAPTION);
            } // end else
        } // end method BtnSave_Click()

        /// <summary>
        /// To call the helper function Delete()
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        } // end method BtnDelete_Click()

        /// <summary>
        /// Helper function for BtnDelete() to support testing
        /// </summary>
        private void Delete()
        {
            //Save the employee being edited as a listview item
            ListViewItem item = ListPendingCourses.FocusedItem;

            try
            {
                //Use the items text as the key for BR dictionary, then get the education course entry using the items courseID
                var eduCourseKey = BusinessRules.Instance[uint.Parse(item.Text)].EducationCourses.Keys.Where(x => x.Equals(item.SubItems[1].Text)).First();
                //var eduCourseKey = BusinessRules.Instance[uint.Parse(item.Text)].EducationCourses.Keys.Where(x => x.Key.Equals(item.SubItems[1].Text)).First();

                //Save updated version of education course to dictionary
                BusinessRules.Instance[uint.Parse(item.Text)].EducationCourses.Remove(eduCourseKey.ToString()); // Remove(eduCourseKey.Key.ToString());

                //Re-populate the list of courses
                PopulatePendingCourses();

                //Clear edit text boxes
                EditClear();

                //Prompt user course was deleted
                MessageBox.Show(COURSE_DELETED_MSG, COURSE_DELETED_CAPTION);
            } // end if
            catch (NullReferenceException) // no item selected
            {
                MessageBox.Show(INVALID_DELETE_MSG, INVALID_DELETE_CAPTION);
            } // end else
        } // end method Delete()

        /// <summary>
        /// To call the helper function Submit()
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Submit();
        } // end method BtnSubmit_Click()

        /// <summary>
        /// Helper function for BtnSubmit_Click() to support testing
        /// </summary>
        private void Submit()
        {
            //Declare & init vars:
            int sum = 0;
            int creditSum = 0;
            int remainingCredits = 0;
            List<int> compedIndices = new List<int>();

            //If no courses are pending
            if (ListPendingCourses.Items.Count.Equals(0))
            {
                //Prompt user, no pending courses
                MessageBox.Show(NO_PENDING_MSG, NO_PENDING_CAPTION);
                return;
            } // end if

            //Get all courses comped this semester
            var totalCompedCredits =
                from c in CurrEmp.EducationCourses
                where !c.Value.ApprovalDate.Equals(DateTime.MinValue)
                where c.Value.ApprovalDate < DateTime.Now.AddMonths(THREE) || c.Value.ApprovalDate > DateTime.Now.AddMonths(-THREE)
                select c;

            //Add up all comped credits
            creditSum = totalCompedCredits.AsEnumerable().Sum(x => x.Value.Credits);

            //If the employee has already used all their comped course credits
            if (creditSum >= CurrEmp.MaxCredits)
            {
                //Prompt user, no more comp credits available
                MessageBox.Show(COMP_EXCEEDED_MSG, COMP_EXCEEDED_CAPTION);
            } // end if
            else // emp still has comp credits available
            {
                //Determine remaining comp credits
                remainingCredits = CurrEmp.MaxCredits - creditSum;

                //Get pending courses within remainingCredits limit
                var validCourses = CurrEmp.EducationCourses.OrderBy(x => x.Value.Credits).TakeWhile(x =>
                {
                    var temp = sum;
                    sum += x.Value.Credits;
                    return !temp.Equals(remainingCredits); // CurrEmp.MaxCredits
                }).ToList();

                //If courses valid for compensation exist
                if (validCourses.Count > 0)
                {
                    //Set course approval date & credit amount
                    validCourses.ForEach(x => { x.Value.ApprovalDate = DateTime.Now; x.Value.CreditAmount = FULL_CREDIT; });

                    //Prompt user courses were comped
                    MessageBox.Show(COURSES_COMPED_MSG, COURSES_COMPED_CAPTION);

                    //Save current employee changes
                    BusinessRules.Instance[uint.Parse(CurrEmp.EmpID)] = CurrEmp;

                    //Re-populate pending courses
                    PopulatePendingCourses();
                } // end if
                else // emp has comp credits, but all pending courses exceed them
                {
                    //Prompt user, pending courses exceed max credits
                    MessageBox.Show(PENDING_EXCEEDS_MSG, PENDING_EXCEEDS_CAPTION);
                } // end else
            } // end else
        } // end method Submit()

        /// <summary>
        /// To change emp course data for the approved courses
        /// </summary>
        /// <param name="compedIndices"></param>
        /// <param name="creditAmount"></param>
        private void ReconcileCourses(List<int> compedIndices, string creditAmount)
        {
            //Iterate through pending courses
            for (int i = 0; i < ListPendingCourses.Items.Count; i++)
            {
                //Save the current item
                var item = ListPendingCourses.Items[i];

                //Iterate through comped indices
                for (int j = 0; j < compedIndices.Count; j++)
                {
                    //If the current item shares an index with the current compedIndices
                    if (i.Equals(compedIndices[j]))
                    {
                        //Update this course's ApprovalDate for the current employee
                        BusinessRules.Instance[uint.Parse(CurrEmp.EmpID)].EducationCourses[item.SubItems[1].Text].ApprovalDate = DateTime.Now;

                        //Update this course's CreditAmount for the current employee
                        BusinessRules.Instance[uint.Parse(CurrEmp.EmpID)].EducationCourses[item.SubItems[1].Text].CreditAmount = (creditAmount.Equals(FULL_CREDIT)) ? FULL_CREDIT : creditAmount;
                    } // end if
                } // end for
            } // end for
        } // end method ReconcileCourses()

        /// <summary>
        /// To call helper function PopulatePendingCourses()
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void TabPending_Enter(object sender, EventArgs e)
        {
            PopulatePendingCourses();
        } // end method TabPending_Enter

        /// <summary>
        /// To populate the pending courses list
        /// </summary>
        private void PopulatePendingCourses()
        {
            //Clear the List
            ListPendingCourses.Items.Clear();

            //Add courses to ListView
            foreach (Course course in CurrEmp.EducationCourses.Values)
            {
                //If course has no approval date
                if (course.ApprovalDate.Equals(DateTime.MinValue))
                {
                    //Save primary data members to a string array
                    string[] rowDetails = { CBxInstitution.Items[0].ToString(), course.ID,
                    course.Description, course.Grade, course.Credits.ToString() };

                    //Save rowDetails as a ListViewItem
                    var row = new ListViewItem(rowDetails);

                    ListPendingCourses.Items.Add(row);
                } // end if
            } // end foreach
        } // end method PopulatePendingCourses()

        /// <summary>
        /// To call the helper function PopulateCompedCourses()
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void TabCompedCourses_Enter(object sender, EventArgs e)
        {
            PopulateCompedCourses();
        } // end method TabCompedCourses_Enter()

        /// <summary>
        /// To populate the comped courses list
        /// </summary>
        private void PopulateCompedCourses()
        {
            //Clear the List
            ListCompedCourses.Items.Clear();

            //Add courses to ListView
            foreach (Course course in CurrEmp.EducationCourses.Values)
            {
                //If course has approval date
                if (!course.ApprovalDate.Equals(DateTime.MinValue))
                {
                    //Save primary data members to a string array
                    string[] rowDetails = { course.ID, course.Description, course.Grade,
                        course.Credits.ToString(), course.CreditAmount, course.ApprovalDate.ToShortDateString() };

                    //Save rowDetails as a ListViewItem
                    var row = new ListViewItem(rowDetails);

                    ListCompedCourses.Items.Add(row);
                } // end if
            } // end foreach
        } // end method PopulateCompedCourses()

        /// <summary>
        /// To fill the fields with test data
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void MnuTestData_Click(object sender, EventArgs e)
        {
            //Bring tab page into focus
            TabEduBfts.SelectedIndex = 1;

            //Fill fields with test data
            CBxInstitution.Text = TEST_UVU;
            TxtID.Text = TEST_ID;
            TxtDescription.Text = TEST_DESC;
            CBxGrade.Text = TEST_GRADE;
            CBxCredits.Text = TEST_CREDITS;
        } // end method MnuTestData_Click()

        /// <summary>
        /// To save the current emp data when the form is closed
        /// </summary>
        /// <param name="sender">The object generating the event</param>
        /// <param name="e">The event args</param>
        private void FrmEmp_Benefits_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save current employee changes
            BusinessRules.Instance[uint.Parse(CurrEmp.EmpID)] = CurrEmp;
        } // end method FrmEmp_Benefits_FormClosing()
    } // end class FrmEmp_Benefits
} // end namespace Lab_12_JRL
