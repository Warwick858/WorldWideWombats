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
    /// Main-form Class
    /// </summary>
    public partial class FrmMain : Form
    {
        //Declare & Initialize Constants:
        const string PROGRAM_ABOUT = "Name: James LoForti \nCourse: CS3260-001 \nInstructor: Thackeray \nProject: Lab_12 ";
        const string ABOUT_TEXT = "About ";
        const string CLOSING_CAPTION = "Closing Application ";
        const string CLOSING_MSG = "Are you sure you want to close WWW Employee Manager? ";
        const string CLOSING_YES = "YES ";
        const string CLOSING_NO = "NO ";

        /// <summary>
        /// FrmMain Constructor - initializes data members and components
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        } // end constructor

        /// <summary>
        /// To call OpenFileDB in FileIO class
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void MnuOpen_Click(object sender, EventArgs e)
        {
            FileIO.Instance.OpenFileDB();
        } // end method MnuOpen_Click()

        /// <summary>
        /// To call WriteFileDB in FileIO class
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void MnuSave_Click(object sender, EventArgs e)
        {
            FileIO.Instance.WriteFileDB();
        } // end method MnuSave_Click()

        /// <summary>
        /// To show a MessageBox which contains the program author and details
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void MnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PROGRAM_ABOUT, ABOUT_TEXT);
        } // end method MnuAbout_Click()

        /// <summary>
        /// To terminate the application and close the program
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void MnuExit_Click(object sender, EventArgs e)
        {
            Close();
        } // end method MnuExit_Click()

        /// <summary>
        /// To show FrmAdmin form
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void PBxAdmin_Click(object sender, EventArgs e)
        {
            //Create new instance of FrmAdmin
            FrmAdmin form = new FrmAdmin();

            //Show form
            form.ShowDialog(this);
        } // end method PBxAdmin_Click()

        /// <summary>
        /// To show the employee login form
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void PBxEmpPort_Click(object sender, EventArgs e)
        {
            //Create new instance of FrmEmp_Login
            FrmEmp_Login form = new FrmEmp_Login();

            //Show form
            form.ShowDialog(this);
        } // end method PBxEmpPort_Click()

        /// <summary>
        /// To prompt the user that program is closing, and to confirm event
        /// </summary>
        /// <param name="e">FormClosing event args</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Initialize method vars:
            DialogResult result = DialogResult.No;

            //Prompt user of closing application, and confirm
            result = MessageBox.Show(CLOSING_MSG, CLOSING_CAPTION, MessageBoxButtons.YesNo);

            //If user confirms NO
            if (result == DialogResult.No)
            {
                //Cancel the event
                e.Cancel = true;

                //Pass event changes to base method
                base.OnFormClosing(e);
            } // end if
        } // end method OnFormClosing()

        /// <summary>
        /// To show an Employee Benefits form, loaded with an employee object's data
        /// </summary>
        /// <param name="sender">the object generating the event</param>
        /// <param name="e">the event args</param>
        private void MnuTestBenefits_Click(object sender, EventArgs e)
        {
            //Create new instance of FrmEmp_Benefits
            FrmEmp_Benefits form = new FrmEmp_Benefits();

            //Try to get employee using given empID (key)
            Employee emp = BusinessRules.Instance[3];

            //Set the new form's current employee object
            form.CurrEmp = emp;

            //Set the new form's current employee
            form.TxtCurrentEmp.Text = emp.FirstName + " " + emp.LastName;

            //Show form
            form.ShowDialog(this);
        } // end method MnuTestBenefits_Click()
    } // end class FrmMain
} // end namespace Lab_12_JRL
