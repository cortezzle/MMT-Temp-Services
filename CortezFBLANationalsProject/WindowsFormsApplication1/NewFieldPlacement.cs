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
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CortezFBLA
{
    public partial class NewFieldPlacement : Form
    {
        //Variables
        static string selectedEmployer;
        static string selectedEmployerID;
        static string selectedEmployerName;
        static string selectedEmployee;
        static string selectedEmployeeID;
        static string selectedEmployeeName;
        static string mmtMainPath = @"C:\MMT Temp Services\";
        static string mainEmployeesFilePath = mmtMainPath + @"Employees.txt";
        static string mainEmployersFilePath = mmtMainPath + @"Employers.txt";
        static string mainFieldFilePath = mmtMainPath + @"Field Placements.txt";
        //Importing variables from MainForm
        MainForm MainFormClass;
        DataGridView MainFormFieldTable;
        TabControl MainFormCurrentTab;
        DataGridViewColumn emplerIDColumn;
        ListView recentsBar;


        public NewFieldPlacement()
        {
            InitializeComponent();
            //Ensures the main mmt directory is created
            if (!System.IO.File.Exists(mmtMainPath))
            {
                System.IO.Directory.CreateDirectory(mmtMainPath);
            }

        }

        //Constructor importing elements and variables from the main form
        public NewFieldPlacement(MainForm MainFormThing, DataGridView MainFormFieldTableThing, TabControl MainFormCurrentTabThing, DataGridViewColumn emplerIDColumnThing,
            ListView recentsBarThing)
        {
            InitializeComponent();
            if (System.IO.File.Exists(mainEmployersFilePath))
            {
                employerListbox.Items.Clear();
                Tools.readAndBindEmplerCustomObject(mainEmployersFilePath, employerListbox);
            }
            else
            {
                MessageBox.Show("You don't have any employers added yet!");
            }
            MainFormClass = MainFormThing;
            MainFormFieldTable = MainFormFieldTableThing;
            MainFormCurrentTab = MainFormCurrentTabThing;
            emplerIDColumn = emplerIDColumnThing;
            recentsBar = recentsBarThing;
            

        }

        //What happens when you press the cancel button
        private void LinkCancelButton_Click(object sender, EventArgs e)
        {
            MainFormClass.deleteCurrentTab();

        }
        
        //What happens when you select an employer
        private void employerListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employerListbox.SelectedItem != null)
            {
                selectedEmployer = (string)employerListbox.SelectedItem;
                int seperator = selectedEmployer.IndexOf(" ");
                selectedEmployerID = selectedEmployer.Substring(0, seperator);
                selectedEmployerName = selectedEmployer.Substring(seperator + 1);
                LinkNextButton.BackColor = Color.Green;
                LinkNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }
        
        //What happens when the next button is clicked
        private void LinkNextButton_Click(object sender, EventArgs e)
        {
            if (employerListbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employer before continuing!");
            }
            else
            {
                if(System.IO.File.Exists(mainEmployeesFilePath))
                {
                employeeListbox.Items.Clear();
                Tools.readAndBindEmpCustomObject(mainEmployeesFilePath, employeeListbox);
                }
                else
                {
                    MessageBox.Show("You don't have any employees added yet!");
                }
                selectEmployeeLabel.Show();
                employeeListbox.Show();
                linkButton.Show();
            }
        }

        //What happens when an employee is selected
        private void employeeListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeListbox.SelectedItem != null)
            {
                selectedEmployee = (string)employeeListbox.SelectedItem;
                int seperator = selectedEmployee.IndexOf(" ");
                selectedEmployeeID = selectedEmployee.Substring(0, seperator);
                selectedEmployeeName = selectedEmployee.Substring(seperator + 1);
                linkButton.BackColor = Color.Green;
                linkButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the link button is clicked
        private void linkButton_Click(object sender, EventArgs e)
        {
            if (employeeListbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee before attempting to link!");
            }
            else
            {
                //Saving process


                FileStream fieldCSV = new FileStream(mainFieldFilePath, FileMode.Append, FileAccess.Write);

                //Create necessary directories, assign path and field variables
                string[] fieldPlacementFields = { selectedEmployerID, selectedEmployerName, selectedEmployeeID, selectedEmployeeName };
                string formattedFieldPlaceFields = Tools.formatToCSV(fieldPlacementFields);

                Employee desiredEmployee = Tools.findEmployee((string)selectedEmployee);
                desiredEmployee.company =  (string)selectedEmployer;

                //Write the field placement to its own report and add the same data in CSV format to the data file
                StreamWriter fileWriter = new StreamWriter(fieldCSV);
                fileWriter.WriteLine(formattedFieldPlaceFields, Encoding.UTF8);
                fileWriter.Close();

                //Clear data from elements and rebind them with updated fields
                MainFormFieldTable.Rows.Clear();
                Tools.readAndBindTableData(mainFieldFilePath, MainFormFieldTable, emplerIDColumn);
                string recentsBarText = selectedEmployerName + " | " + selectedEmployeeName;
                recentsBar.Items.Add(recentsBarText);
                MessageBox.Show("Saved");

                MainFormClass.deleteCurrentTab();

            }

        }
    }


}

