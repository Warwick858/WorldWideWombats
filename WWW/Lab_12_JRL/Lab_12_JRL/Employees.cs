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

namespace Lab_12_JRL
{
    /// <summary>
    /// This class models an abstract Employee.
    /// It acts as the base class for the Hourly, Contract, and Salary clases.
    /// </summary>
    [Serializable]
    public abstract class Employee
    {
        //Declare & Initialize Constants:
        const int MAX_CREDITS_HOURLY = 1;
        const int MAX_CREDITS_SALARY = 6;
        const int MAX_CREDITS_SALES = 3;
        const string MIN_GRADE_HOURLY = "B";
        const string MIN_GRADE_SALARY = "B+";
        const string MIN_GRADE_SALES = "C+";
        const string CURRENT = "Current";

        //Define Class Properties:
        public EType EmpType { get; set; }
        public string EmpID { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string MaritalStatus { get; set; }
        public string FPTime { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public string Status { get; set; }
        public bool OvertimeEligible { get; set; }
        public bool CommissionEligible { get; set; }
        public bool BenefitsEligible { get; set; }
        public bool EducationBenefitsEligible { get; set; }
        public bool EducationBenefitsApproved { get; set; }
        public int MaxCredits { get; set; }
        public string MinGrade { get; set; }
        public SortedDictionary<string, Course> EducationCourses { get; set; }

        /// <summary>
        /// Constructor - To initialize data members to default values
        /// </summary>
        public Employee()
        {
            EmpType = EType.NONE;
            EmpID = string.Empty;
            FirstName = string.Empty;
            MiddleInitial = string.Empty;
            LastName = string.Empty;
            MaritalStatus = string.Empty;
            FPTime = string.Empty;
            Department = string.Empty;
            Title = string.Empty;
            StartDate = DateTime.MinValue;
            Status = string.Empty;
            OvertimeEligible = false;
            CommissionEligible = false;
            BenefitsEligible = false;
            EducationBenefitsEligible = false;
            EducationBenefitsApproved = false;
            EducationCourses = new SortedDictionary<string, Course>();
            MaxCredits = GetCredits();
            MinGrade = GetGrade();
        } // end default constructor

        /// <summary>
        /// To initialize data members to given values
        /// </summary>
        /// <param name="empType">enum of type EType</param>
        /// <param name="empID">string</param>
        /// <param name="firstName">string</param>
        /// <param name="middle">string</param>
        /// <param name="lastName">string</param>
        /// <param name="marital">string</param>
        /// <param name="fPTime">string</param>
        /// <param name="department">string</param>
        /// <param name="title">string</param>
        /// <param name="startDate">DateTime</param>
        public Employee(EType empType, string empID, string firstName, string middle, string lastName, string marital, string fPTime,
            string department, string title, DateTime startDate)
        {
            EmpType = empType;
            EmpID = empID;
            FirstName = firstName;
            MiddleInitial = middle;
            LastName = lastName;
            MaritalStatus = marital;
            FPTime = fPTime;
            Department = department;
            Title = title;
            StartDate = startDate;
            Status = CURRENT;
            OvertimeEligible = (empType == EType.HOURLY) ? true : false;
            CommissionEligible = (empType == EType.SALES) ? true : false;
            BenefitsEligible = (empType == EType.SALARY || empType == EType.SALES) ? true : false;
            EducationBenefitsEligible = (empType == EType.CONTRACT) ? false : true;
            EducationBenefitsApproved = false;
            EducationCourses = new SortedDictionary<string, Course>();
            MaxCredits = GetCredits();
            MinGrade = GetGrade();
        } // end Parameterized constructor

        /// <summary>
        /// To overload the equals method so it compares object values,
        /// rather than the address of the object itself.
        /// Needed for testing
        /// </summary>
        /// <param name="obj">An Object object</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //If the object this is being compared to is Employee
            if (obj is Employee)
            {
                Employee that = obj as Employee;
                return (EmpID == that.EmpID) && (FirstName == that.FirstName) &&
                    (LastName == that.LastName);
            } // end if

            return false;
        } // end method Equals()

        /// <summary>
        /// To return the hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        } // end method GetHashCode()

        /// <summary>
        /// To return maxCredits based on EType
        /// </summary>
        /// <returns></returns>
        private int GetCredits()
        {
            //HOURLY
            if (EmpType.Equals(EType.HOURLY))
            {
                return MAX_CREDITS_HOURLY;
            } // end if
            //SALARY
            if (EmpType.Equals(EType.SALARY))
            {
                return MAX_CREDITS_SALARY;
            } // end if
            //SALES
            if (EmpType.Equals(EType.SALES))
            {
                return MAX_CREDITS_SALES;
            } // end if

            return 0;
        } // end method GetCredits()

        /// <summary>
        /// To return MinGrade based on EType
        /// </summary>
        /// <returns></returns>
        private string GetGrade()
        {
            //HOURLY
            if (EmpType.Equals(EType.HOURLY))
            {
                return MIN_GRADE_HOURLY;
            } // end if
            //SALARY
            if (EmpType.Equals(EType.SALARY))
            {
                return MIN_GRADE_SALARY;
            } // end if
            //SALES
            if (EmpType.Equals(EType.SALES))
            {
                return MIN_GRADE_SALES;
            } // end if

            return string.Empty;
        } // end method GetGrade()
    } // end class Employee
} // end namespace Lab_12_JRL