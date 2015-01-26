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
    public partial class NewEmployer : Form
    {
        // Variables
        static string employerIdentifier = null;
        static string bizName = null;
        static string emailAddress = null;
        static string bizPhone = null;
        static string streetAddress = null;
        static string streetAddress2 = null;
        static string city = null;
        static string state = null;
        static string zipCode = null;
        static string bizRep = null;
        static string mmtMainPath = @"C:\MMT Temp Services\";
        static string mainEmployersFilePath = mmtMainPath + @"Employers.txt";
        //Importing variables from MainForm
        MainForm MainFormClass;
        DataGridView MainFormEmployersTable;
        TabControl MainFormCurrentTab;
        DataGridViewColumn identColumn;
        ListView recentsBar;
        ListBox emplerRepList;


        public NewEmployer()
        {
            InitializeComponent();
        }

        //Constructor importing elements and variables from the main form
        public NewEmployer(MainForm MainFormThing, DataGridView MainFormEmployeesTableThing, TabControl MainFormCurrentTabThing, DataGridViewColumn identColumnThing,
            ListView recentsBarThing, ListBox emplerRepListThing)
        {
            InitializeComponent();
            //Ensures the main mmt directory is created
            if (!System.IO.File.Exists(mmtMainPath))
            {
                System.IO.Directory.CreateDirectory(mmtMainPath);
            }
            MainFormClass = MainFormThing;
            MainFormEmployersTable = MainFormEmployeesTableThing;
            MainFormCurrentTab = MainFormCurrentTabThing;
            identColumn = identColumnThing;
            recentsBar = recentsBarThing;
            emplerRepList = emplerRepListThing;
        }

        public void AllEmployeeFields(object sender, EventArgs e)
        {

        }

        //What happens when the user enters/changes text in the identifier text box
        private void identifierBox_TextChanged(object sender, EventArgs e)
        {
            employerIdentifier = identifierBox.Text;
            if (employerIdentifier != null && bizName != null && emailAddress != null && bizPhone != null
                && streetAddress != null && city != null && state != null && zipCode != null && bizRep != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the first name text box
        private void bizNameBox_TextChanged(object sender, EventArgs e)
        {
            bizName = bizNameBox.Text;
            MainFormCurrentTab.SelectedTab.Text = bizName;
            if (employerIdentifier != null && bizName != null && emailAddress != null && bizPhone != null
                && streetAddress != null && city != null && state != null && zipCode != null && bizRep != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the email text box
        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            emailAddress = emailBox.Text;
            if (employerIdentifier != null && bizName != null && emailAddress != null && bizPhone != null
                && streetAddress != null && city != null && state != null && zipCode != null && bizRep != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the company phone text box
        private void bizPhoneBox_TextChanged(object sender, EventArgs e)
        {
            bizPhone = bizPhoneBox.Text;
            if (employerIdentifier != null && bizName != null && emailAddress != null && bizPhone != null
                && streetAddress != null && city != null && state != null && zipCode != null && bizRep != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the street address text box
        private void addressBox_TextChanged(object sender, EventArgs e)
        {
            streetAddress = addressBox.Text;
            if (employerIdentifier != null && bizName != null && emailAddress != null && bizPhone != null
                 && streetAddress != null && city != null && state != null && zipCode != null && bizRep != null)
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
            if (employerIdentifier != null && bizName != null && emailAddress != null && bizPhone != null
                && streetAddress != null && city != null && state != null && zipCode != null && bizRep != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }
        
        //What happens when the user enters/changes text in the state text box
        private void stateBox_TextChanged(object sender, EventArgs e)
        {
            state = stateBox.Text;
            if (employerIdentifier != null && bizName != null && emailAddress != null && bizPhone != null
                && streetAddress != null && city != null && state != null && zipCode != null && bizRep != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the zip code text box
        private void zipBox_TextChanged(object sender, EventArgs e)
        {
            zipCode = zipBox.Text;
            if (employerIdentifier != null && bizName != null && emailAddress != null && bizPhone != null
                && streetAddress != null && city != null && state != null && zipCode != null && bizRep != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the user enters/changes text in the business representative text box
        private void bizRepBox_TextChanged(object sender, EventArgs e)
        {
            bizRep = bizRepBox.Text;
            if (employerIdentifier != null && bizName != null && emailAddress != null && bizPhone != null
                && streetAddress != null && city != null && state != null && zipCode != null && bizRep != null)
            {
                saveButton.BackColor = Color.Green;
                saveButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        //What happens when the save button is clicked
        private void saveButton_Click(object sender, EventArgs e)
        {
            bool isDone = true;
            foreach (Employer emplr in MainForm.Employers)
            {
                if (emplr.emplrID.Equals(employerIdentifier))
                {
                    MessageBox.Show("An employer with this identifier already exists. Please enter a new one.");
                    isDone = false;
                }
            }
            //Conditional statement as to whether all of the required fields have been filled out 
            if (employerIdentifier != null && bizName != null && emailAddress != null && bizPhone != null
                && streetAddress != null && city != null && state != null && zipCode != null && bizRep != null)
            {
                if (isDone == true)
                {
                    if (emailAddress.Contains('@') && bizPhone.Length >= 10)
                    {
                        //Saving process


                        FileStream empCSV = new FileStream(mainEmployersFilePath, FileMode.Append, FileAccess.Write);

                        //Create necessary directories, assign path and field variables
                        string[] employerFields = { employerIdentifier, bizName, emailAddress, bizPhone,
                                       streetAddress, streetAddress2, city, state, zipCode, bizRep };
                        string formattedEmpFields = Tools.formatToCSV(employerFields);

                        Employer newEmployer = new Employer(employerIdentifier, bizName, emailAddress, bizPhone,
                                           streetAddress, streetAddress2, city, state, zipCode, bizRep);
                        MainForm.Employers.Add(newEmployer);

                        //Write the field placement in CSV format to the data file
                        StreamWriter fileWriter = new StreamWriter(empCSV);
                        fileWriter.WriteLine(formattedEmpFields, Encoding.UTF8);
                        fileWriter.Close();

                        //Clear data from elements and rebind them with updated fields
                        MainFormEmployersTable.Rows.Clear();
                        Tools.readAndBindTableData(mainEmployersFilePath, MainFormEmployersTable, identColumn);
                        emplerRepList.Items.Clear();
                        Tools.readAndBindEmplerCustomObject(mainEmployersFilePath, emplerRepList);
                        string recentsBarText = employerIdentifier + " " + bizName;
                        recentsBar.Items.Add(recentsBarText);
                        MessageBox.Show("Saved");
                        MainFormClass.deleteCurrentTab();
                    }
                    //Data checks to ensure that proper data is entered.
                    if (!emailAddress.Contains('@'))
                    {
                        MessageBox.Show("Please enter a valid email address.");
                    }
                    if (bizPhone.Length < 10)
                    {
                        MessageBox.Show("Please enter a valid 10 digit phone number (May contain '-')");
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
            employerIdentifier = null;
            bizName = null;
            emailAddress = null;
            bizPhone = null;
            streetAddress = null;
            streetAddress2 = null;
            city = null;
            state = null;
            zipCode = null;
            bizRep = null;
            MainFormClass.deleteCurrentTab();
        }





    }
}
