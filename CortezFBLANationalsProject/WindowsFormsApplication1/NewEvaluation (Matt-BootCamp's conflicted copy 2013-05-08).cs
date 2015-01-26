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
    public partial class NewEvaluation : Form
    {
        //VARIABLES
        static string employeeChosen = null;
        static string employerChosen = null;
        static string selectedEmployeeID;
        static string selectedEmployeeName;
        static string selectedEmployerID;
        static string selectedEmployerName;
        static string evalID = null;
        static bool wouldRecommend;
        static string recommend;
        static int workQualScore = 0;
        static int workHabScore = 0;
        static  int jobKnowScore = 0;
        static int behaviorScore = 0;
        static double avgScore = 0;
        static int overallProgScore = 0;
        static string workQualComments = null;
        static string workHabComments = null;
        static string jobKnowComments = null;
        static string behaviorComments = null;
        static string overallProgressComments = null;
        static string currentEvalDate;
        static string nextEvalDate;
        static string mmtMainPath = @"C:\MMT Temp Services\";
        static string mainEmployeesFilePath = mmtMainPath + @"Employees.txt";
        static string mainEmployersFilePath = mmtMainPath + @"Employers.txt";
        static string mainFieldFilePath = mmtMainPath + @"Field Placements.txt";
        static string mainEvalFilePath = mmtMainPath + @"Evaluations.txt";

        //Importing variables from MainForm
        MainForm MainFormClass;
        DataGridView MainFormEvalTable;
        TabControl MainFormCurrentTab;
        DataGridViewColumn dateColumn;
        ListView recentsBar;
        ListBox evalRepList;


        public NewEvaluation()
        {
            InitializeComponent();   
            NextEvalDatePicker.MaxSelectionCount = 1;
        }

        //Constructor importing elements and variables from the main form
        public NewEvaluation(MainForm MainFormThing, DataGridView MainFormEvalTableThing, TabControl MainFormCurrentTabThing, DataGridViewColumn MainFormDateColumnThing, 
            ListView recentsBarThing)
        {
            InitializeComponent();
            //Ensures the main mmt directory is created
            if (!System.IO.File.Exists(mmtMainPath))
            {
                System.IO.Directory.CreateDirectory(mmtMainPath);
            }
            MainFormClass = MainFormThing;
            MainFormEvalTable = MainFormEvalTableThing;
            MainFormCurrentTab = MainFormCurrentTabThing;
            dateColumn = MainFormDateColumnThing;
            recentsBar = recentsBarThing;
            
        }

        private void NewEvaluation_Load(object sender, EventArgs e)
        {
            employerSelectionBox.Items.Add("All Employers");
            Tools.readAndBindEmpCustomObject(mainEmployeesFilePath, employeeSelectionBox);
            if (employeeSelectionBox.Items.Count == 0)
            {
                MessageBox.Show("You don't have any employees added.\nClick cancel on the following form, create an employee, then try again.");

            }

            Tools.readAndBindEmplerCustomObject(mainEmployersFilePath, employerSelectionBox);

            if (employerSelectionBox.Items.Count == 1)
            {
                MessageBox.Show("You don't have any employers added yet, you may want to consider adding an employer first.");
            }
        }       
       
        //Top Panel Methods

        //What happens when the user enters/changes text in the identifier text box
        private void identifierBox_TextChanged(object sender, EventArgs e)
        {
            evalID = identifierBox.Text;
        }
        
        //What happens when an employee is selected
        private void employeeSelectionBox_SelectedValueChanged(object sender, EventArgs e)
        {
            employeeChosen = employeeSelectionBox.SelectedItem.ToString();
            int seperator = employeeChosen.IndexOf(" ");
            selectedEmployeeID = employeeChosen.Substring(0, seperator);
            selectedEmployeeName = employeeChosen.Substring(seperator + 1);
        }
        
        //What happens when an employer is selected
        private void employerSelectionBox_SelectedValueChanged(object sender, EventArgs e)
        {
            employerChosen = employerSelectionBox.SelectedItem.ToString();
            if(employerChosen.Contains("All Employers"))
            {
                Tools.readAndBindEmpCustomObject(mainEmployeesFilePath, employeeSelectionBox);
            }
            int seperator = employerChosen.IndexOf(" ");
            selectedEmployerID = employerChosen.Substring(0, seperator);
            selectedEmployerName = employerChosen.Substring(seperator + 1);
            employeeSelectionBox.Items.Clear();
            for (int i = 0; i < MainForm.Employees.Count; i++)
            {
                Employee currentEmployee = MainForm.Employees.ElementAt(i);
                string compName = currentEmployee.company.Substring(currentEmployee.company.IndexOf(' '));

                if (employerChosen.Contains(compName))
                {
                    string empData = currentEmployee.empID + " " + currentEmployee.name;

                    try
                    {
                        employeeSelectionBox.Items.Add(empData);
                    }
                    catch (NullReferenceException nullError)
                    {

                    }


                }
            }
        }


        //Work Quality Methods
        private void workQual1_CheckedChanged(object sender, EventArgs e)
        {
            workQualScore = 1;
            if (workQualComments != null && workQualScore != 0)
            {
                workQualNextButton.BackColor = Color.Green;
                workQualNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void workQual2_CheckedChanged(object sender, EventArgs e)
        {
            workQualScore = 2;
            if (workQualComments != null && workQualScore != 0)
            {
                workQualNextButton.BackColor = Color.Green;
                workQualNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void workQual3_CheckedChanged(object sender, EventArgs e)
        {
            workQualScore = 3;
            if (workQualComments != null && workQualScore != 0)
            {
                workQualNextButton.BackColor = Color.Green;
                workQualNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void workQual4_CheckedChanged(object sender, EventArgs e)
        {
            workQualScore = 4;
            if (workQualComments != null && workQualScore != 0)
            {
                workQualNextButton.BackColor = Color.Green;
                workQualNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void workQual5_CheckedChanged(object sender, EventArgs e)
        {
            workQualScore = 5;
            if (workQualComments != null && workQualScore != 0)
            {
                workQualNextButton.BackColor = Color.Green;
                workQualNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void workQualCommentsBox_TextChanged(object sender, EventArgs e)
        {
            workQualComments = workQualCommentsBox.Text;

            if (workQualComments != null && workQualScore != 0)
            {
                workQualNextButton.BackColor = Color.Green;
                workQualNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void workQualNextButton_Click(object sender, EventArgs e)
        {
            if (workQualComments.Contains(","))
            {
                workQualComments = workQualComments.Replace(',', '|');
            }

                workQualPanel.Hide();

        }


        //Work Habits Methods
        private void workHabPrevButton_Click(object sender, EventArgs e)
        {
            workQualPanel.Show();
            workQualPanel.BringToFront();
        }

        private void workHab1_CheckedChanged(object sender, EventArgs e)
        {
            workHabScore = 1;
            if (workHabComments != null && workHabScore != 0)
            {
                workHabNextButton.BackColor = Color.Green;
                workHabNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void workHab2_CheckedChanged(object sender, EventArgs e)
        {
            workHabScore = 2;
            if (workHabComments != null && workHabScore != 0)
            {
                workHabNextButton.BackColor = Color.Green;
                workHabNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void workHab3_CheckedChanged(object sender, EventArgs e)
        {
            workHabScore = 3;
            if (workHabComments != null && workHabScore != 0)
            {
                workHabNextButton.BackColor = Color.Green;
                workHabNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void workHab4_CheckedChanged(object sender, EventArgs e)
        {
            workHabScore = 4;
            if (workHabComments != null && workHabScore != 0)
            {
                workHabNextButton.BackColor = Color.Green;
                workHabNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void workHab5_CheckedChanged(object sender, EventArgs e)
        {
            workHabScore = 5;
            if (workHabComments != null && workHabScore != 0)
            {
                workHabNextButton.BackColor = Color.Green;
                workHabNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void workHabCommentsBox_TextChanged(object sender, EventArgs e)
        {
            workHabComments = workHabCommentsBox.Text;
            if (workHabComments != null && workHabScore != 0)
            {
                workHabNextButton.BackColor = Color.Green;
                workHabNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void workHabNextButton_Click(object sender, EventArgs e)
        {
            if (workHabComments.Contains(","))
            {
                workHabComments = workHabComments.Replace(',', '|');
            }
                workHabPanel.Hide();
            
        }

         
        //Job Knowledge Methods
        private void jobKnowPrevButton_Click(object sender, EventArgs e)
        {
            workHabPanel.Show();
            workHabPanel.BringToFront();
        }

        private void jobKnow1_CheckedChanged(object sender, EventArgs e)
        {
            jobKnowScore = 1;
            if (jobKnowComments != null && jobKnowScore != 0)
            {
                jobKnowNextButton.BackColor = Color.Green;
                jobKnowNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void jobKnow2_CheckedChanged(object sender, EventArgs e)
        {
            jobKnowScore = 2;
            if (jobKnowComments != null && jobKnowScore != 0)
            {
                jobKnowNextButton.BackColor = Color.Green;
                jobKnowNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void jobKnow3_CheckedChanged(object sender, EventArgs e)
        {
            jobKnowScore = 3;
            if (jobKnowComments != null && jobKnowScore != 0)
            {
                jobKnowNextButton.BackColor = Color.Green;
                jobKnowNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void jobKnow4_CheckedChanged(object sender, EventArgs e)
        {
            jobKnowScore = 4;
            if (jobKnowComments != null && jobKnowScore != 0)
            {
                jobKnowNextButton.BackColor = Color.Green;
                jobKnowNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void jobKnow5_CheckedChanged(object sender, EventArgs e)
        {
            jobKnowScore = 5;
            if (jobKnowComments != null && jobKnowScore != 0)
            {
                jobKnowNextButton.BackColor = Color.Green;
                jobKnowNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void jobKnowCommentsBox_TextChanged(object sender, EventArgs e)
        {
            jobKnowComments = jobKnowCommentsBox.Text;
            if (jobKnowComments != null && jobKnowScore != 0)
            {
                jobKnowNextButton.BackColor = Color.Green;
                jobKnowNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void jobKnowNextButton_Click(object sender, EventArgs e)
        {
            if (jobKnowComments.Contains(","))
            {
               jobKnowComments = jobKnowComments.Replace(',', '|');
            }
                jobKnowPanel.Hide();
            
        }


        //Behavior Methods

        private void behaviorPrevButton_Click(object sender, EventArgs e)
        {
            jobKnowPanel.Show();
            jobKnowPanel.BringToFront();
        }

        private void behavior1_CheckedChanged(object sender, EventArgs e)
        {
            behaviorScore = 1;
            if (behaviorComments != null && behaviorScore != 0)
            {
                behaviorNextButton.BackColor = Color.Green;
                behaviorNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void behavior2_CheckedChanged(object sender, EventArgs e)
        {
            behaviorScore = 2;
            if (behaviorComments != null && behaviorScore != 0)
            {
                behaviorNextButton.BackColor = Color.Green;
                behaviorNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void behavior3_CheckedChanged(object sender, EventArgs e)
        {
            behaviorScore = 3;
            if (behaviorComments != null && behaviorScore != 0)
            {
                behaviorNextButton.BackColor = Color.Green;
                behaviorNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void behavior4_CheckedChanged(object sender, EventArgs e)
        {
            behaviorScore = 4;
            if (behaviorComments != null && behaviorScore != 0)
            {
                behaviorNextButton.BackColor = Color.Green;
                behaviorNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void behavior5_CheckedChanged(object sender, EventArgs e)
        {
            behaviorScore = 5;
            if (behaviorComments != null && behaviorScore != 0)
            {
                behaviorNextButton.BackColor = Color.Green;
                behaviorNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void behaviorCommentsBox_TextChanged(object sender, EventArgs e)
        {
            behaviorComments = behaviorCommentsBox.Text;
            if (behaviorComments != null && behaviorScore != 0)
            {
                behaviorNextButton.BackColor = Color.Green;
                behaviorNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void behaviorNextButton_Click(object sender, EventArgs e)
        {
            if (behaviorComments.Contains(","))
            {
                behaviorComments = behaviorComments.Replace(',', '|');
            }

                behaviorPanel.Hide();
        }

        


       //Overall Progress Methods

        private void overallPrevButton_Click(object sender, EventArgs e)
        {
            behaviorPanel.Show();
            behaviorPanel.BringToFront();
        }
        
        private void overallProgCommentsbox_TextChanged(object sender, EventArgs e)
        {
            overallProgressComments = overallProgCommentsbox.Text;
            if (overallProgressComments != null && overallProgScore != 0)
            {
                overallNextButton.BackColor = Color.Green;
                overallNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void overall1_CheckedChanged(object sender, EventArgs e)
        {
            overallProgScore = 1;
            if (overallProgressComments != null && overallProgScore != 0)
            {
                overallNextButton.BackColor = Color.Green;
                overallNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void overall2_CheckedChanged(object sender, EventArgs e)
        {

            overallProgScore = 2;
            if (overallProgressComments != null && overallProgScore != 0)
            {
                overallNextButton.BackColor = Color.Green;
                overallNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void overall3_CheckedChanged(object sender, EventArgs e)
        {
            overallProgScore = 3;
            if (overallProgressComments != null && overallProgScore != 0)
            {
                overallNextButton.BackColor = Color.Green;
                overallNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void overall4_CheckedChanged(object sender, EventArgs e)
        {
            overallProgScore = 4;
            if (overallProgressComments != null && overallProgScore != 0)
            {
                overallNextButton.BackColor = Color.Green;
                overallNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }

        private void overall5_CheckedChanged(object sender, EventArgs e)
        {
            overallProgScore = 5;
            if (overallProgressComments != null && overallProgScore != 0)
            {
                overallNextButton.BackColor = Color.Green;
                overallNextButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }
        
        private void overallNextButton_Click(object sender, EventArgs e)
        {
            if (overallProgressComments.Contains(","))
            {
                overallProgressComments = overallProgressComments.Replace(',', '|');
            }

                overallProgPanel.Hide();
            
        }
       
        //Recommendation Methods
    
        private void recommendPrev_Click(object sender, EventArgs e)
        {
            overallProgPanel.Show();
            overallProgPanel.BringToFront();
        }

        private void recommendYesButton_CheckedChanged(object sender, EventArgs e)
        {
            wouldRecommend = true;
            if (wouldRecommend != null)
            {
                recommendNext.BackColor = Color.Green;
                recommendNext.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }
        
        private void recommendNobutton_CheckedChanged(object sender, EventArgs e)
        {
            wouldRecommend = false;
            if (wouldRecommend != null)
            {
                recommendNext.BackColor = Color.Green;
                recommendNext.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }
        
        private void reccomendNext_Click(object sender, EventArgs e)
        {
            recommendPanel.Hide();
        }

        //Next Evaluation Methods
        private void nextEvalPrev_Click_1(object sender, EventArgs e)
        {
            recommendPanel.Show();
            recommendPanel.BringToFront();
        }
        
        private void nextEvalNext_Click(object sender, EventArgs e)
        {
            //Calculate average score
            avgScore = (workQualScore + workHabScore + jobKnowScore + behaviorScore) / 4;
            //Get Current Date
            currentEvalDate = DateTime.Today.ToShortDateString();
            //Recommend?
            if (wouldRecommend == true)
                recommend = "Yes";
            else if (wouldRecommend == false)
                recommend = "No";
            //Format current date
            string fileCompatibleCurrentDate = currentEvalDate.Replace('/', '_');

            //Saving process
            FileStream evalCSV = new FileStream(mainEvalFilePath, FileMode.Append, FileAccess.Write);

            //Create necessary directories, assign path and field variables
            string[] evalFields = { currentEvalDate, evalID, selectedEmployeeID, selectedEmployeeName, selectedEmployerID, selectedEmployerName, 
                                      nextEvalDate, workQualScore.ToString(), workQualComments, workHabScore.ToString(),
                                    workHabComments, jobKnowScore.ToString(), jobKnowComments, behaviorScore.ToString(), behaviorComments,
                                      avgScore.ToString(), overallProgScore.ToString(), overallProgressComments, recommend};
            string formattedEvalFields = Tools.formatToCSV(evalFields);

            Evaluation newEval = new Evaluation(currentEvalDate, evalID, selectedEmployeeID, selectedEmployeeName, selectedEmployerID, selectedEmployerName,
                                      nextEvalDate, workQualScore.ToString(), workQualComments, workHabScore.ToString(),
                                    workHabComments, jobKnowScore.ToString(), jobKnowComments, behaviorScore.ToString(), behaviorComments,
                                      avgScore.ToString(), overallProgScore.ToString(), overallProgressComments, recommend);
            Employee employee_evaluated = Tools.findEmployee(selectedEmployeeID + " " + selectedEmployeeName);
            employee_evaluated.employeeEvaluations.Add(newEval);

            //Write the field placement to its own report and add the same data in CSV format to the data file
            StreamWriter fileWriter = new StreamWriter(evalCSV);
            fileWriter.WriteLine(formattedEvalFields, Encoding.UTF8);
            fileWriter.Close();


            //Clear data from elements and rebind them with updated fields
            MainFormEvalTable.Rows.Clear();
            Tools.readAndBindTableData(mainEvalFilePath, MainFormEvalTable, dateColumn);
            string recentsBarText = currentEvalDate + " " + selectedEmployeeName;
            recentsBar.Items.Add(recentsBarText);
            MessageBox.Show("Saved");
            MainFormClass.deleteCurrentTab();
        }

        private void evalCancelButton_Click(object sender, EventArgs e)
        {
            MainFormClass.deleteCurrentTab();
        }

        private void NextEvalDatePicker_DateSelected(object sender, DateRangeEventArgs e)
        {
            nextEvalDate = NextEvalDatePicker.SelectionStart.Date.ToShortDateString();
            if (nextEvalDate != null && evalID != null && employeeChosen != null && employerChosen != null)
            {
                nextEvalNext.BackColor = Color.Green;
                nextEvalNext.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            }
        }


        


        

        

        

        
       

       
       
        

       

       

 




    }
}
