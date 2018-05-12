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
    /// Business Rules for indexing SortedDictionary of employee objects
    /// Sealed Singleton class
    /// </summary>
    public sealed class BusinessRules
    {
        //Declare & Initialize Constants:
        const string F_NAME1 = "John";
        const string M_NAME1 = "R";
        const string L_NAME1 = "Doe";
        const string EMP_ID1 = "00001";
        const string MARITAL1 = "Single";
        const string FP_TIME1 = "Part-time";
        const string DEPARTMENT1 = "Customer Service";
        const string TITLE1 = "Customer Service Rep";
        const string START_DATE1 = "04/15/2015";
        const double TYPE_DETAILS1 = 15.00;
        const string F_NAME2 = "Mary";
        const string M_NAME2 = "J";
        const string L_NAME2 = "Hansen";
        const string EMP_ID2 = "00002";
        const string MARITAL2 = "Married";
        const string FP_TIME2 = "Full-time";
        const string DEPARTMENT2 = "Human Resources";
        const string TITLE2 = "HR Admin Assistant";
        const string START_DATE2 = "04/20/2012";
        const double TYPE_DETAILS2 = 4000.00;
        const string F_NAME3 = "Rubert";
        const string M_NAME3 = "C";
        const string L_NAME3 = "McGillacutty";
        const string EMP_ID3 = "00003";
        const string MARITAL3 = "Single";
        const string FP_TIME3 = "Part-time";
        const string DEPARTMENT3 = "Quality Assurance";
        const string TITLE3 = "QA Consultant";
        const string START_DATE3 = "01/25/2016";
        const double TYPE_DETAILS3 = 1500.00;
        const string AGENCY3 = "Tech Consulting";
        const string F_NAME4 = "Beavis";
        const string M_NAME4 = "W";
        const string L_NAME4 = "Wombat";
        const string EMP_ID4 = "00004";
        const string MARITAL4 = "Married";
        const string FP_TIME4 = "Full-time";
        const string DEPARTMENT4 = "Asia Sales";
        const string TITLE4 = "Sales Assoc";
        const string START_DATE4 = "06/09/2011";
        const double TYPE_DETAILS4 = 1000.00;
        const double TYPE_DETAILS5 = 0.10;
        const string INVALID_KEY_CAPTION = "INVALID EMPLOYEE ID ";
        const string INVALID_KEY_MSG = "The employee you attempted to access does not exist. ";

        //Declare Data Members:
        private static BusinessRules instance;
        private SortedDictionary<uint, Employee> employees = new SortedDictionary<uint, Employee>
        {
            {uint.Parse(EMP_ID1), new Hourly(EType.HOURLY, EMP_ID1, F_NAME1, M_NAME1, L_NAME1, MARITAL1, FP_TIME1, 
                DEPARTMENT1, TITLE1, Convert.ToDateTime(START_DATE1), TYPE_DETAILS1)},
            {uint.Parse(EMP_ID2), new Salary(EType.SALARY, EMP_ID2, F_NAME2, M_NAME2, L_NAME2, MARITAL2, FP_TIME2, 
                DEPARTMENT2, TITLE2, Convert.ToDateTime(START_DATE2), TYPE_DETAILS2)},
            {uint.Parse(EMP_ID3), new Contract(EType.CONTRACT, EMP_ID3, F_NAME3, M_NAME3, L_NAME3, MARITAL3, FP_TIME3, 
                DEPARTMENT3, TITLE3, Convert.ToDateTime(START_DATE3), TYPE_DETAILS3, AGENCY3)},
            {uint.Parse(EMP_ID4), new Sales(EType.SALES, EMP_ID4, F_NAME4, M_NAME4, L_NAME4, MARITAL4, FP_TIME4, 
                DEPARTMENT4, TITLE4, Convert.ToDateTime(START_DATE4), TYPE_DETAILS4, TYPE_DETAILS5)},
        };

        /// <summary>
        /// Singleton - To create a new instance of BusinessRules if it doesn't already exist, else return existing instance
        /// </summary>
        public static BusinessRules Instance
        {
            get
            {
                //If singleton has not been initialized
                if (instance == null)
                {
                    //Create instance and save
                    instance = new BusinessRules();
                } // end if

                return instance;
            } // end get
            set
            {
                instance = value;
            }
        } // end method GetInstance()

        /// <summary>
        /// Indexer - To iterate through, while get/set employees array
        /// </summary>
        /// <param name="i">unsigned int that represents the dictionary "key" value</param>
        /// <returns>employee object of given key</returns>
        public Employee this[uint i]
        {
            get
            {
                //Create temp emp
                Employee thisEmployee;

                //If-try and get the employee
                if (employees.TryGetValue(i, out thisEmployee))
                {
                    return employees[i];
                } // end if

                return null;
            } //get
            set
            {
                employees[i] = value;
            } //set
        } // end Employee Indexer

        /// <summary>
        /// Property - To return the collection of keys in the employees dictionary
        /// </summary>
        public SortedDictionary<uint, Employee>.KeyCollection Keys
        {
            get
            {
                return employees.Keys;
            }
        } // end property Keys

        /// <summary>
        /// Property - To return the length of the employees dictionary
        /// </summary>
        public int Length
        {
            get
            {
                return employees.Count;
            }
        } // end property length

        /// <summary>
        /// To add an employee object to the employees dictionary
        /// </summary>
        /// <param name="key">corresponding key to employee object</param>
        /// <param name="employee">Employee object</param>
        public void Add(uint key, Employee employee)
        {
            employees.Add(key, employee);
        } // end method Add()

        /// <summary>
        /// To get the SortedDictionary of employees
        /// Needed to get and pass this employee dictionary to the FileIO class
        /// </summary>
        /// <returns>A SortedDictionary of uint (keys) & Employee (values)</returns>
        public SortedDictionary<uint, Employee> GetEmployees()
        {
            return employees;
        } // end method GetEmployees()

        /// <summary>
        /// To set the SortedDictionary of employees
        /// Needed to pass and set the IO employee dictionary from FileIO class
        /// </summary>
        /// <param name="updatedEmployees">A SortedDictionary of uint (keys) & Employee (values)</param>
        public void SetEmployees(SortedDictionary<uint, Employee> updatedEmployees)
        {
            employees = updatedEmployees;
        } // end method SetEmployees()

        /// <summary>
        /// To remove the value associated with the given key from the employee dictionary
        /// </summary>
        /// <param name="key">uint employee key</param>
        public void Remove(uint key)
        {
            employees.Remove(key);
        } // end method Remove()
    } // end class BusinessRules
} // end namespace Lab_12_JRL