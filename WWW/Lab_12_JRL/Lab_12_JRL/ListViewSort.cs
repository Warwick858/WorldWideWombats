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
using System.Collections;
using System.Windows.Forms;

namespace Lab_12_JRL
{
    /// <summary>
    /// To sort the items from the ListView
    /// </summary>
    class ListViewSort : IComparer
    {
        //Declare data members:
        private int col;

        /// <summary>
        /// The default constructor
        /// </summary>
        public ListViewSort()
        {
            col = 0;
        } // end default constructor

        /// <summary>
        /// To set the column number
        /// </summary>
        /// <param name="column"></param>
        public ListViewSort(int column)
        {
            col = column;
        } // end method ListViewSort()

        /// <summary>
        /// To compare the subitems
        /// </summary>
        /// <param name="x">object</param>
        /// <param name="y">object</param>
        /// <returns>return value as int</returns>
        public int Compare(object x, object y)
        {
            //Declare & init vars:
            int returnVal = -1;

            //Compare the subitems
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
            ((ListViewItem)y).SubItems[col].Text);

            return returnVal;
        } // end method Compare()
    } // end class ListViewSort
} // end namespace Lab_12_JRL
