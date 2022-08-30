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
        #region ADD
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

            else if (ptr < rows)
            {
                //for (int i = 0; i < rows; i++)
                {
                    dataStructure[ptr, 0] = name.ToString();
                    dataStructure[ptr, 1] = category.ToString();
                    dataStructure[ptr, 2] = structure.ToString();
                    dataStructure[ptr, 3] = description.ToString();

                }
                ptr++;
                clearTextBoxes();
                updateListViewData();
            }
            else
            {
                MessageBox.Show("Storage is FULL. Please delete a data structure to make space");
            }

        }
        #endregion
        private void clearTextBoxes()
        {
            textBoxName.Clear();
            textBoxCategory.Clear();
            textBoxStructure.Clear();
            textBoxDescription.Clear();
            textBoxName.Focus();
        }

        // 9.3	Create an EDIT button that will allow the user to modify any information from the 4 text boxes into the 2D array
        #region EDIT
        private void buttonEDIT_Click(object sender, EventArgs e)
        {

            //listViewData.Items[0].Selected = true;
            int index = listViewData.SelectedIndices[0];

            dataStructure[index, 0] = textBoxName.Text;
            dataStructure[index, 1] = textBoxCategory.Text;
            dataStructure[index, 2] = textBoxStructure.Text;
            dataStructure[index, 3] = textBoxDescription.Text;
            updateListViewData();
            clearTextBoxes();


        }
        #endregion
        //Adding/Updating data in listview
        private void updateListViewData()
        {

            listViewData.Items.Clear();

            for (int i = 0; i < ptr; i++)
            {
                ListViewItem listViewItem = new ListViewItem(dataStructure[i, 0]);
                listViewItem.SubItems.Add(dataStructure[i, 1]);
                listViewData.Items.Add(listViewItem);
            }

        }
        //selecting row in listview
        private void listViewData_Click(object sender, EventArgs e)
        {
            int pos = listViewData.SelectedIndices[0];
            //int pos = listViewData.FocusedItem.Index;

            //int index = listViewData.Items.IndexOf(listViewData.SelectedItems[0]);
            displayData(pos);

        }
        private void displayData(int pos)
        {
            textBoxName.Text = dataStructure[pos, 0];
            textBoxCategory.Text = dataStructure[pos, 1];
            textBoxStructure.Text = dataStructure[pos, 2];
            textBoxDescription.Text = dataStructure[pos, 3];

        }
        // 9.4	Create a DELETE button that removes all the information from a single entry of the array; the user must be prompted before the final deletion occurs,
        #region DELETE
        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            int index = listViewData.SelectedIndices[0];
            listViewData.Items.RemoveAt(index);
            //shifting the data in structure
            for (int i = index; i < ptr; i++)
            {
                dataStructure[index, 0] = dataStructure[index + 1, 0];
                dataStructure[index, 1] = dataStructure[index + 1, 1];
                dataStructure[index, 2] = dataStructure[index + 1, 2];
                dataStructure[index, 3] = dataStructure[index + 1, 3];

            }
            ptr--;
            // updateListViewData();
            clearTextBoxes();
        }
        #endregion
        

    }
}
