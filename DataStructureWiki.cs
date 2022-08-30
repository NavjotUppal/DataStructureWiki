using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        // 9.6	Write the code for a Bubble Sort method to sort the 2D array by Name ascending,
        // ensure you use a separate swap method that passes the array element to be swapped (do not use any built-in array methods),
        private void buttonSORT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ptr; i++)
            {
                if (String.Compare(dataStructure[i, 0], dataStructure[i + 1, 0], StringComparison.Ordinal) > 0)
                {
                    swap(i);
                }
            }
            updateListViewData();
        }

        // 9.7	Write the code for a Binary Search for the Name in the 2D array and display the information in the other textboxes when found,
        // add suitable feedback if the search in not successful and clear the search textbox (do not use any built-in array methods),
        private void buttonSEARCH_Click(object sender, EventArgs e)
        {

        }
        #region UTILITIES
        //9.5	Create a CLEAR method to clear the four text boxes so a new definition can be added
        private void clearTextBoxes()
        {
            textBoxName.Clear();
            textBoxCategory.Clear();
            textBoxStructure.Clear();
            textBoxDescription.Clear();
            textBoxName.Focus();
        }
        //9.8	Create a display method that will show the following information in a ListView: Name and Category
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
        //9.9	Create a method so the user can select a definition (Name) from the ListView and all the information is displayed in the appropriate Textboxes,
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
        private void swap(int i)
        {
            String temp;
            for (int j = 0; j < columns; j++)
            {
                temp = dataStructure[i, j];
                dataStructure[i, j] = dataStructure[i + 1, j];
                dataStructure[i + 1, j] = temp;
            }
        }

        #endregion
        //9.10	Create a SAVE button so the information from the 2D array can be written into a
        //binary file called definitions.dat which is sorted by Name, ensure the user has the option to select an alternative file.
        //Use a file stream and BinaryWriter to create the file.
        private void buttonSAVE_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "bin file|=.bin";
            saveFileDialog.Title = "Save a BIN file";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.DefaultExt = "bin";
            string defaultFileName = "default.bin";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;
            if (saveFileDialog.FileName != "")
            {
                saveDataFile(fileName);
            }
            else
            {
                saveDataFile(defaultFileName);
            }
        }
        private void saveDataFile(string saveFileName)
        {
            using (Stream stream = File.Open(saveFileName, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    for (int x = 0; x < rows; x++)
                    {
                        for (int y = 0; y < columns; y++)
                        {
                            if (dataStructure[x, y] != null)
                            {
                                writer.Write(dataStructure[x, y]);
                            }
                        }
                    }
                    writer.Write(ptr);
                }
            }
        }
        // 9.11	Create a LOAD button that will read the information from a binary file
        // called definitions.dat into the 2D array, ensure the user has the option to select an alternative file.
        // Use a file stream and BinaryReader to complete this task.
        private void buttonLOAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "BIN FILES|*.bin";
            openFileDialog.Title = "Open a BIN file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openDataFile(openFileDialog.FileName);
                
            }


        }
        private void openDataFile(string openFileName)
        {
            try
            {
                using (Stream stream = File.Open(openFileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        int i = 0;
                        Array.Clear(dataStructure, 0, dataStructure.Length);
                        while (stream.Position < stream.Length)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataStructure[i, j] = reader.ReadString();
                            }
                            i++;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            updateListViewData();
        }
    }
}
