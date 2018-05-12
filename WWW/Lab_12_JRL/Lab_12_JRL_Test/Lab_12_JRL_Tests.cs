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
using Lab_12_JRL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_12_JRL_Test
{
    /// <summary>
    /// Test Class for Lab_12_JRL Classes
    /// The following derived class constructor tests inherently test their inherited classes. (No pun intended ;)
    /// </summary>
    [TestClass]
    public class Lab_12_JRL_Tests
    {
        //Declare & Initialize Constants:
        const string FIRST_NAME = "John";
        const string M_NAME1 = "R";
        const string LAST_NAME = "Doe";
        const string EMP_ID1 = "00001";
        const string EMP_ID2 = "00002";
        const string MARITAL1 = "Single";
        const string FP_TIME1 = "Part-time";
        const string DEPARTMENT1 = "Customer Service";
        const string TITLE1 = "Customer Service Representative";
        const string START_DATE1 = "04/15/2015";
        const double HOURLY_RATE = 15.00;
        const double CONTRACT_WAGE = 20.00;
        const double MONTHLY_SALARY = 2000.00;
        const double COMMISSION_RATE = 0.10;
        const string EMP_ID = "999999999";

        /// <summary>
        /// To test the constructor in the Hourly class
        /// </summary>
        [TestMethod]
        public void HourlyConstructor()
        {
            Hourly hourlyEmp = new Hourly()
            {
                EmpType = EType.HOURLY,
                EmpID = EMP_ID,
                FirstName = FIRST_NAME,
                LastName = LAST_NAME,
                HourlyRate = HOURLY_RATE
            };

            Assert.IsNotNull(hourlyEmp);
        } // end method HourlyConstructor()

        /// <summary>
        /// To test the constructor in the Contract class
        /// </summary>
        [TestMethod]
        public void ContractConstructor()
        {
            Contract contractEmp = new Contract()
            {
                EmpType = EType.HOURLY,
                EmpID = EMP_ID,
                FirstName = FIRST_NAME,
                LastName = LAST_NAME,
                ContractWage = CONTRACT_WAGE
            };

            Assert.IsNotNull(contractEmp);
        } // end method ContractConstructor()

        /// <summary>
        /// To test the constructor in the Sales class, which also tests the base Salary class
        /// </summary>
        [TestMethod]
        public void SalesConstructor()
        {
            Sales salesEmp = new Sales()
            {
                EmpType = EType.HOURLY,
                EmpID = EMP_ID,
                FirstName = FIRST_NAME,
                LastName = LAST_NAME,
                MonthlySalary = MONTHLY_SALARY,
                CommissionRate = COMMISSION_RATE
            };

            Assert.IsNotNull(salesEmp);
        } // end method SalesConstructor()

        /// <summary>
        /// To test the BusinessRules class Instance property
        /// </summary>
        [TestMethod]
        public void BusinessRulesInstance()
        {
            Assert.IsNotNull(BusinessRules.Instance);
        } // end method BusinessRulesInstance()

        /// <summary>
        /// To test the BusinessRules class Length method
        /// </summary>
        [TestMethod]
        public void BusinessRulesLength()
        {
            int testLength = BusinessRules.Instance.Length;

            Assert.AreEqual(testLength, BusinessRules.Instance.Length);
        } // end method BusinessRulesLength()

        /// <summary>
        /// To test the BusinessRules class Add method
        /// </summary>
        [TestMethod]
        public void BusinessRulesAdd()
        {
            //Create new HOURLY
            Hourly empTest = new Hourly()
            {
                EmpType = EType.HOURLY,
                EmpID = EMP_ID,
                FirstName = FIRST_NAME,
                LastName = LAST_NAME,
                HourlyRate = HOURLY_RATE
            };

            //Add it to BusinessRules employees dictionary
            BusinessRules.Instance.Add(uint.Parse(EMP_ID), empTest);

            //Ensure the employee was added and it matches original
            Assert.AreEqual(empTest, BusinessRules.Instance[uint.Parse(EMP_ID)]);
        } // end method BusinessRulesAdd()

        /// <summary>
        /// To test the FileIO class ReadFileDB method
        /// </summary>
        [TestMethod]
        public void FileIOReadFileDB()
        {
            ////Declare & init vars:
            FileStream fStream = File.Open("test.bin", FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            SortedDictionary<uint, Employee> employees = new SortedDictionary<uint, Employee>
            {
                {uint.Parse(EMP_ID1), new Hourly(EType.HOURLY, EMP_ID1, FIRST_NAME, M_NAME1, LAST_NAME, MARITAL1, FP_TIME1,
                    DEPARTMENT1, TITLE1, Convert.ToDateTime(START_DATE1), HOURLY_RATE)},
                {uint.Parse(EMP_ID2), new Salary(EType.SALARY, EMP_ID2, FIRST_NAME, M_NAME1, LAST_NAME, MARITAL1, FP_TIME1,
                    DEPARTMENT1, TITLE1, Convert.ToDateTime(START_DATE1), MONTHLY_SALARY)}
            };

            //Serialize current BusinessRules data
            formatter.Serialize(fStream, employees);

            //Close the FileStream (Create)
            fStream.Close();

            //Set FileStream to OpenRead
            fStream = File.OpenRead("test.bin");

            //Call ReadFileDB and pass fStream to test.bin
            FileIO.Instance.ReadFileDB(fStream);

            //Close the FileStream (Open)
            fStream.Close();

            //Assert EmployeeDB and original disctionary hold the same employee objects
            Assert.AreEqual(employees[0], FileIO.Instance.EmployeeDB[0]);
            Assert.AreEqual(employees[1], FileIO.Instance.EmployeeDB[1]);
        } // end method FileIOReadFileDB()

        /// <summary>
        /// To test the FileIO WriteFileDB method
        /// </summary>
        [TestMethod]
        public void FileIOWriteFileDB()
        {
            //Turn on TestMode to bypass OpenFileDialog
            FileIO.Instance.TestMode = true;

            //Save current EmployeeDB
            SortedDictionary<uint, Employee> currEmployees = FileIO.Instance.EmployeeDB;

            //Call WriteFileDB in FileIO class
            FileIO.Instance.WriteFileDB();

            //Turn off TestMode
            FileIO.Instance.TestMode = false;

            //Open test.bin
            FileStream fStream = File.OpenRead("test.bin");

            //Call ReadFileDB and pass fStream to test.bin
            FileIO.Instance.ReadFileDB(fStream);

            //Close the FileStream
            fStream.Close();

            //Assert EmployeeDB and original dictionary hold the same employee objects
            Assert.AreEqual(currEmployees[0], FileIO.Instance.EmployeeDB[0]);
            Assert.AreEqual(currEmployees[1], FileIO.Instance.EmployeeDB[1]);
        } // end method FileIOWriteFileDB()

        /// <summary>
        /// To test the FileIO CloseFileDB method
        /// </summary>
        [TestMethod]
        public void FileIOCloseFileDB()
        {
            //Declare & init vars:
            FileStream fStream = File.OpenRead("test.bin");

            //Call CloseFileDB in FileIO class
            FileIO.Instance.CloseFileDB(fStream);

            //Assert the stream is no longer readable
            Assert.IsFalse(fStream.CanRead);
        } // end method FileIOCloseFileDB()
    } // end class Lab_12_JRL_Tests
} // end namespace Lab_12_JRL_Test
