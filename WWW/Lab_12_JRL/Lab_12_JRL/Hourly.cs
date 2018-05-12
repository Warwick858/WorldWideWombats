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

namespace Lab_12_JRL
{
    /// <summary>
    /// This class models a Hourly Employee.
    /// It contains all Hourly Employee methods & data.
    /// This class inherits from the Employee base class.
    /// </summary>
    [Serializable]
    public sealed class Hourly : Employee
    {
        //Define Class Properties:
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        /// <summary>
        /// Constructor - To initialize data members to default values
        /// </summary>
        public Hourly()
        {
            HourlyRate = 0.0;
            HoursWorked = 0.0;
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
        /// <param name="hourlyRate">double</param>
        public Hourly(EType empType, string empID, string firstName, string middle, string lastName, string marital, string fPTime,
            string department, string title, DateTime startDate, double hourlyRate)
            : base(empType, empID, firstName, middle, lastName, marital, fPTime, department, title, startDate)
        {
            HourlyRate = hourlyRate;
            HoursWorked = 0.0;
        } // end Parameterized constructor

        /// <summary>
        /// To override the ToString method so object property values are returned
        /// </summary>
        /// <returns>The string containing the object property values</returns>
        public override string ToString()
        {
            return "\r\n" + FirstName.ToString() + " " + LastName.ToString() + ":\r\n\t" +
                "Type: " + EmpType.ToString().ToLowerInvariant() + "\r\n\t" +
                "ID: " + EmpID.ToString() + "\r\n\t" +
                "Hourly Rate: " + HourlyRate.ToString("C") + "\n";
        } // end method ToString()

        /// <summary>
        /// To overload the equals method so it compares object values,
        /// rather than the address of the object itself.
        /// Needed for testing
        /// </summary>
        /// <param name="obj">An Object object</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //If the object this is being compared to is Hourly
            if (obj is Hourly)
            {
                Hourly that = obj as Hourly;
                return (EmpID == that.EmpID) && (FirstName == that.FirstName) &&
                    (LastName == that.LastName) && (HourlyRate == that.HourlyRate);
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
    } // end class Hourly
} // end namespace Lab_12_JRL