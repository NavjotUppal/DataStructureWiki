﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureWiki
{
    public partial class DataStructureWiki : Form
    {
        public DataStructureWiki()
        {
            InitializeComponent();
        }
        // 9.1	Create a global 2D string array, use static variables for the dimensions(row, column)
        static int rows = 12;
        static int columns = 4;
        string[,] dataStructure = new string[rows, columns];

        //9.2	Create an ADD button that will store the information from the 4 text boxes into the 2D array
        private void buttonADD_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string category = textBoxCategory.Text;
            string structure = textBoxStructure.Text;
            string description = textBoxDescription.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category) 
                || string.IsNullOrEmpty(structure) || string.IsNullOrEmpty(description))
            {
                statusStripMsg.Text = "All fields should have value.";
            }
            else
            {
                for(int i = 0; i <rows; i++)
                {
                    dataStructure[i, 0] = name;
                    dataStructure[i, 1] = category;
                    dataStructure[i, 2] = structure;
                    dataStructure[i, 3] = description;
                   
                }
                clearTextBoxes();
            }

        }
        private void clearTextBoxes()
        {
            textBoxName.Clear();
            textBoxCategory.Clear();
            textBoxCategory.Clear();
            textBoxDescription.Clear();
            textBoxName.Focus();
        }
    }
}
