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
    /// This class represents an academic course
    /// </summary>
    [Serializable]
    public class Course
    {
        //Define Class Properties:
        public string ID { get; set; }
        public string Description { get; set; }
        public string Grade { get; set; }
        public int Credits { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string CreditAmount { get; set; }

        /// <summary>
        /// Constructor - To initialize data members to default values
        /// </summary>
        public Course()
        {
            ID = string.Empty;
            Description = string.Empty;
            Grade = string.Empty;
            Credits = 0;
            ApprovalDate = DateTime.MinValue;
            CreditAmount = string.Empty;
        } // end default constructor

        /// <summary>
        /// To initialize data members to given values
        /// </summary>
        /// <param name="id">string</param>
        /// <param name="description">string</param>
        /// <param name="grade">string</param>
        /// <param name="credits">int</param>
        public Course(string id, string description, string grade, int credits)
        {
            ID = id;
            Description = description;
            Grade = grade;
            Credits = credits;
            ApprovalDate = DateTime.MinValue;
            CreditAmount = string.Empty;
        } // end Parameterized constructor
    } // end class Course
} // end namespace Lab_12_JRL
