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



namespace CortezFBLA
{
    public partial class NewEmployee : Form
    {
        // Variables
        public static string employeeIdentifier = null;
        static string firstName = null;
        static string lastName = null;
        static string emailAddress = null;
        static string homePhone = null;
        static string cellPhone = null;
        static string streetAddress = null;
        static string streetAddress2 = null;
        static string city = null;
        static string state = null;
        static string zipCode = null;
        static string mmtMainPath = @"C:\MMT Temp Services\";
        static string mainEmployeesFilePath = mmtMainPath + @"Employees.txt";
        static bool[] counter = new bool[0];
        static bool hasText = false;
        //Importing variables from MainForm
        MainForm MainFormClass;
        DataGridView MainFormEmployeesTable;
        DataGridViewColumn idColumn;
        TabControl MainFormCurrentTab;
        ListView recentsBar;
        ListBox empRepList;
        

        public NewEmployee()
        {
            InitializeComponent();
        }

        //Constructor importing elements and variables from the main form
        public NewEmployee(MainForm MainFormThing, DataGridView MainFormEmployeesTableThing, TabControl MainFormCurrentTabThing, DataGridViewColumn idColumnThing,
            ListView recentsBarThing, ListBox empRepListThing)
        {
            InitializeComponent();
            //Ensures the main mmt directory is created
            if (!System.IO.File.Exists(mmtMainPath))
            {
                System.IO.Directory.CreateDirectory(mmtMainPath);
            }
            MainFormClass = MainFormThing;
            MainFormEmployeesTable = MainFormEmployeesTableThing;
            MainFormCurrentTab = MainFormCurrentTabThing;
            idColumn = idColumnThing;
            recentsBar = recentsBarThing;
            empRepList = empRepListThing;

        }       

        public void AllEmployeeFields(object sender, EventArgs e)
        {

        }

        //What happens when the user enters/changes text in the identifier text box
        private void identifierBox_TextChanged(object sender, EventArgs e)
        {
            employeeIdentifier = identifierBox.Text;
            if (employeeIdentifier != null && firstName != null && lastName != null && emailAddress != null && homePhone != null
                && cellPhone != null && streetAddress != null && city != null && state != null && zipCode != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the first name text box
        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {
            firstName = firstNameBox.Text;
            MainFormCurrentTab.SelectedTab.Text = firstName;
            if (employeeIdentifier != null && firstName != null && lastName != null && emailAddress != null && homePhone != null
                && cellPhone != null && streetAddress != null && city != null && state != null && zipCode != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the last name text box
        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {
            lastName = lastNameBox.Text;
            MainFormCurrentTab.SelectedTab.Text = firstName + " " + lastName;
            if (employeeIdentifier != null && firstName != null && lastName != null && emailAddress != null && homePhone != null
                && cellPhone != null && streetAddress != null && city != null && state != null && zipCode != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the email text box
        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            emailAddress = emailBox.Text;
            if (employeeIdentifier != null && firstName != null && lastName != null && emailAddress != null && homePhone != null
                && cellPhone != null && streetAddress != null && city != null && state != null && zipCode != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the home phone text box
        private void homePhoneBox_TextChanged(object sender, EventArgs e)
        {
            homePhone = homePhoneBox.Text;
            if (employeeIdentifier != null && firstName != null && lastName != null && emailAddress != null && homePhone != null
                && cellPhone != null && streetAddress != null && city != null && state != null && zipCode != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the cell phone text box
        private void cellPhoneBox_TextChanged(object sender, EventArgs e)
        {
            cellPhone = cellPhoneBox.Text;
            if (employeeIdentifier != null && firstName != null && lastName != null && emailAddress != null && homePhone != null
                && cellPhone != null && streetAddress != null && city != null && state != null && zipCode != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the street address text box
        private void addressBox_TextChanged(object sender, EventArgs e)
        {
            streetAddress = addressBox.Text;
            if (employeeIdentifier != null && firstName != null && lastName != null && emailAddress != null && homePhone != null
                && cellPhone != null && streetAddress != null && city != null && state != null && zipCode != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the secondary street address text box
        private void addressbox2_TextChanged(object sender, EventArgs e)
        {
            streetAddress2 = addressbox2.Text;
        }

        //What happens when the user enters/changes text in the city text box
        private void cityBox_TextChanged(object sender, EventArgs e)
        {
            city = cityBox.Text;
            if (employeeIdentifier != null && firstName != null && lastName != null && emailAddress != null && homePhone != null
                 && cellPhone != null && streetAddress != null && city != null && state != null && zipCode != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the state text box
        private void stateBox_TextChanged(object sender, EventArgs e)
        {
            state = stateBox.Text;
            if (employeeIdentifier != null && firstName != null && lastName != null && emailAddress != null && homePhone != null
                && cellPhone != null && streetAddress != null && city != null && state != null && zipCode != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the zip code text box
        private void zipBox_TextChanged(object sender, EventArgs e)
        {
            zipCode = zipBox.Text;
            if (employeeIdentifier != null && firstName != null && lastName != null && emailAddress != null && homePhone != null
                && cellPhone != null && streetAddress != null && city != null && state != null && zipCode != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the save button is clicked
        private void saveButton_Click(object sender, EventArgs e)
        {

               //Conditional statement as to whether all of the required fields have been filled out        
            if (employeeIdentifier != null && firstName != null && lastName != null && emailAddress != null && homePhone != null
                && cellPhone != null && streetAddress != null && city != null && state != null && zipCode != null)
            {
                bool isDone = true;
                foreach (Employee emp in MainForm.Employees)
                {
                    if (emp.empID.Equals(employeeIdentifier))
                    {
                        MessageBox.Show("An employee with this identifier already exists. Please enter a new one.");
                        isDone = false;
                    }
                }
                if (isDone == true)
                {
                    if (emailAddress.Contains('@') && homePhone.Length >= 10 && cellPhone.Length >= 10)
                    {
                        //Saving process

                        FileStream empCSV = new FileStream(mainEmployeesFilePath, FileMode.Append, FileAccess.Write);

                        //Create necessary directories, assign path and field variables
                        string[] employeeFields = { employeeIdentifier, firstName, lastName, emailAddress, homePhone,
                                    cellPhone, streetAddress, streetAddress2, city, state, zipCode };
                        string formattedEmpFields = Tools.formatToCSV(employeeFields);

                        Employee newEmployee = new Employee(employeeIdentifier, firstName, lastName, emailAddress, homePhone,
                                        cellPhone, streetAddress, streetAddress2, city, state, zipCode);
                        MainForm.Employees.Add(newEmployee);


                        //Write the field placement to its own report and add the same data in CSV format to the data file
                        StreamWriter fileWriter = new StreamWriter(empCSV);
                        fileWriter.WriteLine(formattedEmpFields, Encoding.UTF8);
                        fileWriter.Close();


                        //Clear data from elements and rebind them with updated fields
                        MainFormEmployeesTable.Rows.Clear();
                        Tools.readAndBindTableData(mainEmployeesFilePath, MainFormEmployeesTable, idColumn);
                        empRepList.Items.Clear();
                        Tools.readAndBindEmpCustomObject(mainEmployeesFilePath, empRepList);
                        string recentsBarText = employeeIdentifier + " " + firstName + " " + lastName;
                        recentsBar.Items.Add(recentsBarText);
                        MessageBox.Show("Saved");


                        employeeIdentifier = null;
                        firstName = null;
                        lastName = null;
                        emailAddress = null;
                        homePhone = null;
                        cellPhone = null;
                        streetAddress = null;
                        streetAddress2 = null;
                        city = null;
                        state = null;
                        zipCode = null;
                        MainFormClass.deleteCurrentTab();
                    }
                    else
                    {
                        //Data checks to ensure proper data is entered
                        if (!emailAddress.Contains('@'))
                        {
                            MessageBox.Show("Please enter a valid email address.");
                        }
                        if (homePhone.Length < 10)
                        {
                            MessageBox.Show("Please enter a valid 10 digit home phone number (May contain '-')");
                        }
                        if (cellPhone.Length < 10)
                        {
                            MessageBox.Show("Please enter a valid 10 digit cell phone number (May contain '-')");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required elements (*)");
            }
        }

        //What happens when the cancel button is clicked
        private void cancelButton_Click(object sender, EventArgs e)
        {
            employeeIdentifier = null;
            firstName = null;
            lastName = null;
            emailAddress = null;
            homePhone = null;
            cellPhone = null;
            streetAddress = null;
            streetAddress2 = null;
            city = null;
            state = null;
            zipCode = null;
            MainFormClass.deleteCurrentTab();
        }


    }
}
