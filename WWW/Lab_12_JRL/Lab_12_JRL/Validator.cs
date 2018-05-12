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
using System.Text.RegularExpressions;

namespace Lab_12_JRL
{
    /// <summary>
    /// This class validates user input
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// To validate the employee ID
        /// </summary>
        /// <param name="empID">a string</param>
        /// <returns>a bool</returns>
        public static bool EmpID(string empID)
        {
            //Declare & init vars:
            string regexStr = @"^[0-9]{5}$";
            Regex regex = new Regex(regexStr);

            //If the empID is good
            if (regex.IsMatch(empID))
            {
                return true;
            } // end if

            return false;
        } // end method EmpID()

        /// <summary>
        /// To validate any name field
        /// </summary>
        /// <param name="name">a string</param>
        /// <returns>a bool</returns>
        public static bool Name(string name)
        {
            //Declare & init vars:
            string regexStr = @"^(?=[a-zA-Z\s]{2,25}$)(?=[a-zA-Z\s])(?:([\w\s*?])\1?(?!\1))+$";
            Regex regex = new Regex(regexStr);

            //If the string has no numbers, specials, white space
            if (regex.IsMatch(name))
            {
                return true;
            } // end if

            return false;
        } // end method Name()

        /// <summary>
        /// To validate the middle initial field
        /// </summary>
        /// <param name="middle">a string</param>
        /// <returns>a bool</returns>
        public static bool MiddleInitial(string middle)
        {
            //Declare & init vars:
            string regexStr = @"^[A-Z]{1}$";
            Regex regex = new Regex(regexStr);

            //If the string is 1 char of upper or lower alpha
            if (regex.IsMatch(middle))
            {
                return true;
            } // end if

            return false;
        } // end method MiddleInitial()

        /// <summary>
        /// To validate the department & title fields
        /// </summary>
        /// <param name="valueStr">a string</param>
        /// <returns>a bool</returns>
        public static bool DeptTitle(string valueStr)
        {
            //Declare & init vars:
            string regexStr = @"^[a-zA-Z\s]+$";
            Regex regex = new Regex(regexStr);

            //If the string only contains upper/lower alpha & spaces
            if (regex.IsMatch(valueStr))
            {
                return true;
            } // end if

            return false;
        } // end method DeptTitle()

        /// <summary>
        /// To validate any compensation field from the employee add form
        /// </summary>
        /// <param name="compensation">a string</param>
        /// <returns>a bool</returns>
        public static bool Compensation(string compensation)
        {
            //Declare & init vars:
            string regexStr = @"^[0-9]*[.,]?[0-9]*$";
            Regex regex = new Regex(regexStr);

            //If the empID is good
            if (regex.IsMatch(compensation))
            {
                return true;
            } // end if

            return false;
        } // end method Compensation()

        /// <summary>
        /// To validate course ID
        /// </summary>
        /// <param name="courseID">a string</param>
        /// <returns>a bool</returns>
        public static bool CourseID(string courseID)
        {
            string regexStr = @"^[a-zA-Z0-9]*$";
            Regex regex = new Regex(regexStr);

            //If the empID is good
            if (regex.IsMatch(courseID))
            {
                return true;
            } // end if

            return false;
        } // end method CourseID()

        /// <summary>
        /// To validate the course description
        /// </summary>
        /// <param name="courseDesc">a string</param>
        /// <returns>a bool</returns>
        public static bool CourseDesc(string courseDesc)
        {
            //Declare & init vars:
            string regexStr = @"^[a-zA-Z_.#+,/)( ]*$";
            Regex regex = new Regex(regexStr);

            //If the empID is good
            if (regex.IsMatch(courseDesc))
            {
                return true;
            } // end if

            return false;
        } // end method CourseDesc()
    } // end class Validator
} // end namespace Lab_12_JRL
