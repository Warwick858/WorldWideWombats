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
using System.Collections.Generic;
using System.IO;

namespace Lab_12_JRL
{
    /// <summary>
    /// IFileAccess Interface for "database" (fileIO)
    /// Method Prototypes for: read, write, open, close DB
    /// Includes Property prototype for a SortedDictionary of uint, Employee - EmployeeDB
    /// </summary>
    public interface IFileAccess
    {
        //Declare & Define method prototypes/property: 
        void WriteFileDB();
        void ReadFileDB(FileStream stream);
        void OpenFileDB();
        void CloseFileDB(FileStream stream);
        SortedDictionary<uint, Employee> EmployeeDB { get; set; }
    } // end interface IFileAccess
} // end namespace Lab_12_JRL
