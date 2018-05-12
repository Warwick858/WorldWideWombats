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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Lab_12_JRL
{
    /// <summary>
    /// FileIO class - Implements IFileAccess interface
    /// Manages IO persistance for BusinessRules
    /// Includes: Read, Write, Open, Close
    /// </summary>
    [Serializable]
    public class FileIO : object, IFileAccess
    {
        //Declare Data Members:
        [NonSerialized]
        private static FileIO instance;

        //Define Class Properties:
        public SortedDictionary<uint, Employee> EmployeeDB { get; set; }
        public bool TestMode { get; set; }

        /// <summary>
        /// Singleton - To create a new instance of FileIO if it doesn't already exist, 
        /// else return existing instance
        /// </summary>
        public static FileIO Instance
        {
            get
            {
                //If singleton has not been initialized
                if (instance == null)
                {
                    //Create instance and save
                    instance = new FileIO();
                } // end if

                return instance;
            } // end get
        } // end property Instance

        /// <summary>
        /// To allow the user to choose a file to read from
        /// </summary>
        public void OpenFileDB()
        {
            //Declare & init vars:
            FileStream stream = null;
            OpenFileDialog openFD = new OpenFileDialog();

            //Ensure open file dialog opens previous directory
            openFD.RestoreDirectory = true;

            //If user has picked a file
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                //If file is NOT null
                if ((stream = (FileStream)openFD.OpenFile()) != null)
                {
                    //Deserialize data
                    ReadFileDB(stream);

                    CloseFileDB(stream);
                } // end if
            } // end if
        } // end method OpenFileDB()

        /// <summary>
        /// To create a binary formatter and use the given stream to deserialize the data
        /// </summary>
        /// <param name="stream">A FileStream object</param>
        public void ReadFileDB(FileStream stream)
        {
            //Declare & init vars:
            IFormatter formatter = new BinaryFormatter();
            List<Employee> readEmployees = new List<Employee>();

            //Deserialize data
            EmployeeDB = (SortedDictionary<uint, Employee>)formatter.Deserialize(stream);
            //Pass newly read data to BusinessRules
            BusinessRules.Instance.SetEmployees(EmployeeDB);
        } // end method ReadFileDB()

        /// <summary>
        /// To serialize the data and write it to the user defined file
        /// </summary>
        public void WriteFileDB()
        {
            //Declare & init vars:
            FileStream stream = null;
            SaveFileDialog saveFD = new SaveFileDialog();
            IFormatter formatter = new BinaryFormatter();

            //If testMode is off
            if (!TestMode)
            {
                //Ensure open file dialog opens previous directory
                saveFD.RestoreDirectory = true;

                //If user has picked a file
                if (saveFD.ShowDialog() == DialogResult.OK)
                {
                    //If file is NOT null
                    if ((stream = (FileStream)saveFD.OpenFile()) != null)
                    {
                        //Get data from BusinessInstance
                        EmployeeDB = BusinessRules.Instance.GetEmployees();
                        //Serialize data
                        formatter.Serialize(stream, EmployeeDB);

                        CloseFileDB(stream);
                    } // end if
                } // end if
            } // end if
            else // TestMode is on
            {
                //Open test.bin
                stream = File.OpenWrite("test.bin");

                //Get data from BusinessInstance
                EmployeeDB = BusinessRules.Instance.GetEmployees();
                //Serialize data
                formatter.Serialize(stream, EmployeeDB);

                CloseFileDB(stream);
            } // end else
        } // end method WriteFileDB()

        /// <summary>
        /// To close the given stream
        /// </summary>
        /// <param name="stream">A FileStream object</param>
        public void CloseFileDB(FileStream stream)
        {
            stream.Close();
        } // end method CloseFileDB()
    } // end class FileIO
} // end namespace Lab_12_JRL
