using System;
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
        int ptr = 0; // pointer for row count

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
                statusStripMsg.Items.Add("Null or Empty values are not accepted");
                textBoxName.Focus();
            }

            else
            {
                for (int i = 0; i < rows; i++)
                {
                    dataStructure[i, 0] = name;
                    dataStructure[i, 1] = category;
                    dataStructure[i, 2] = structure;
                    dataStructure[i, 3] = description;

                }
                ptr++;
                clearTextBoxes();
                updateListViewData();
            }

        }
        private void clearTextBoxes()
        {
            textBoxName.Clear();
            textBoxCategory.Clear();
            textBoxStructure.Clear();
            textBoxDescription.Clear();
            textBoxName.Focus();
        }

        // 9.3	Create an EDIT button that will allow the user to modify any information from the 4 text boxes into the 2D array
        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            if (listViewData.Items.Count > 0)
            {
                listViewData.Items[0].Selected = true;
                int index = listViewData.SelectedIndices[0];
                listViewData.Items.RemoveAt(index);
                dataStructure[index, 0] = textBoxName.Text;
                dataStructure[index, 1] = textBoxCategory.Text;
                dataStructure[index, 2] = textBoxStructure.Text;
                dataStructure[index, 3] = textBoxDescription.Text;
                
                ptr = index;
               updateListViewData();
                clearTextBoxes();

            }
        }

        //Adding data in listview
        private void updateListViewData()
        {

            //listViewData.Items.Clear();
            if (ptr < rows)
            {
                ListViewItem listViewItem = new ListViewItem(dataStructure[ptr, 0]);
                listViewItem.SubItems.Add(dataStructure[ptr, 1]);
                listViewData.Items.Add(listViewItem);
            }
            else
            {
                MessageBox.Show("Data cannot be entered as storage is FULL");
            }
        }

        private void listViewData_Click(object sender, EventArgs e)
        {
            int index = listViewData.SelectedIndices[0];
            textBoxName.Text = dataStructure[index, 0].ToString();
            textBoxCategory.Text = dataStructure[index, 1].ToString();
            textBoxStructure.Text = dataStructure[index, 2].ToString();
            textBoxDescription.Text = dataStructure[index, 3].ToString();

        }
    }
}
