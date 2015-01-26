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
using System.Drawing.Printing;
using System.Diagnostics;
using Microsoft.Office.Tools.Word;


namespace CortezFBLA
{
    public partial class MainForm : Form
    {
        //Main ArrayLists of Respective Objects
        public static List<Employee> Employees = new List<Employee>();
        public static List<Employer> Employers = new List<Employer>();
        public static List<FieldPlacement> FieldPlacements = new List<FieldPlacement>();
        //Path strings
        static string mmtMainPath = @"C:\MMT Temp Services\";
        static string employeePath = mmtMainPath + @"Employees\";
        static string employerPath = mmtMainPath + @"Employers\";
        static string evalPath = mmtMainPath + @"Evaluations\";
        static string fieldPath = mmtMainPath + @"Field Placements\";
        static string mainEmployeesFilePath = @"C:\MMT Temp Services\Employees.txt";
        static string mainEmployersFilePath = @"C:\MMT Temp Services\Employers.txt";
        static string mainFieldFilePath = @"C:\MMT Temp Services\Field Placements.txt";
        static string mainEvalFilePath = @"C:\MMT Temp Services\Evaluations.txt";
        bool tabAdded = false;
        //Import variables from other forms
        NewEmployee newEmployeeWindow;
        NewEmployer newEmployerWindow;
        NewEvaluation newEvalWindow;
        NewFieldPlacement newFieldPlacementWindow;
        //Report Variables
        static string selectedEmployee = null;
        static string selectedEmployer = null;
        static string selectedFieldPlacement = null;
        static string fieldPlacementFilePath = null;
        static string selectedEvaluation = null;
        static string evalFilePath = null;
        public static  int whatPath = 0;
        Font printFont;
        string printFilePath;

        public MainForm()
        {
            InitializeComponent();

            //Create any non-existent paths
            if (!System.IO.File.Exists(mmtMainPath))
            {
                System.IO.Directory.CreateDirectory(mmtMainPath);
            }
            if (!System.IO.File.Exists(mainEmployeesFilePath))
            {
                System.IO.File.CreateText(mainEmployeesFilePath).Close();
            }
            if (!System.IO.File.Exists(mainEmployersFilePath))
            {
                System.IO.File.CreateText(mainEmployersFilePath).Close();
            }
            if (!System.IO.File.Exists(mainFieldFilePath))
            {
                System.IO.File.CreateText(mainFieldFilePath).Close();
            }
            if (!System.IO.File.Exists(mainEvalFilePath))
            {
                System.IO.File.CreateText(mainEvalFilePath).Close();
            }

            //Read in CSV Data and apply it to the DataGridViews (Tables)
            Tools.readAndBindTableData(mainEmployeesFilePath, employeesTable, idColumn);
            Tools.readAndBindTableData(mainEmployersFilePath, employersTable, identColumn);
            Tools.readAndBindTableData(mainFieldFilePath, fieldTable, emplerIDColumn);
            Tools.readAndBindTableData(mainEvalFilePath, evalTable, dateColumn);
            //Clear and Read in CSV data to the Reports Tab
            empRepList.Items.Clear();
            emplerRepList.Items.Clear();
            Tools.readAndBindEmpCustomObject(mainEmployeesFilePath, empRepList);
            Tools.readAndBindEmplerCustomObject(mainEmployersFilePath, emplerRepList);
            //Read in CSV Data to a list of objects for use during run-time
            Tools.importCSV(mainEmployeesFilePath);
            Tools.importCSV(mainFieldFilePath);
            Tools.importCSV(mainEmployersFilePath);
            Tools.importCSV(mainEvalFilePath);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Bring up the home view
            homeView.Parent = this;
            homeView.BringToFront();
            homeView.Location = new Point (155,43);
            mainTab.SelectedIndex = -1;
            currentTab.SendToBack();
        }

        //What happens when the home button is clicked
        private void homeButton_Click(object sender, EventArgs e)
        {
            homeView.Show();
            mainTab.SelectedIndex = -1;
            if (tabAdded == false)
            {
                currentTab.SendToBack();
            }
            else
            {
                currentTab.BringToFront();
                currentTab.Size = new Size(696, 22);
                currentTab.SelectedIndex = -1;
            }
        }

        //What happens when the main tab bar is clicked
        private void mainTab_Click(object sender, EventArgs e)
        {
            homeView.Hide();
            if (tabAdded == false)
            {
                currentTab.SendToBack();
            }
            else
            {
                currentTab.BringToFront();
                currentTab.Size = new Size(696, 22);
                currentTab.SelectedIndex = -1;
            }

            if (mainTab.SelectedIndex == 1)
            {
                employeesTable.Show();
            }
            
            else if (mainTab.SelectedIndex == 2)
            {
                employersTable.Show();
            }
            
            
        }
        
        //what happens if the current tab bar is clicked
        private void currentTab_Click(object sender, EventArgs e)
        {
            mainTab.SelectedIndex = -1;
            currentTab.Size = new Size(696, 585);
        }
                
        //If the new employee button is clicked, make a new tab with the new employee window on it
        private void employeeButton_Click(object sender, EventArgs e)
        {

            currentTab.Size = new Size(696, 585);
            currentTab.BringToFront();
            int theTab = currentTab.TabCount - 1;
            if (tabAdded == false)
            {
                primaryTab.Text = "New Employee";
                tabAdded = true;
                makeNewEmployee();

            }
            else
            {
                TabPage employeeTab1 = new TabPage("New Employee");
                currentTab.TabPages.Add(employeeTab1);
                int numberTabs = currentTab.TabCount - 1;
                currentTab.SelectedIndex = numberTabs;
                makeNewEmployee();

            }


        }

        //If the new evaluation button is clicked, make a new tab with the new evaluation window in it.
        private void evalbutton_Click(object sender, EventArgs e)
        {
            currentTab.Size = new Size(696, 585);
            currentTab.BringToFront();
            if (tabAdded == false)
            {
                primaryTab.Text = "New Evaluation";
                tabAdded = true;
                makeNewEval();
            }
            else
            {
                TabPage evalTab1 = new TabPage("New Evaluation");
                currentTab.TabPages.Add(evalTab1);
                int numberTabs = currentTab.TabCount - 1;
                currentTab.SelectedIndex = numberTabs;
                makeNewEval();
            }

        }

        //If the new employer button is clicked, make a new tab with the new employer window in it
        private void employerButton_Click(object sender, EventArgs e)
        {
            currentTab.Size = new Size(696, 585);
            currentTab.BringToFront();
            if (tabAdded == false)
            {
                primaryTab.Text = "New Employer";
                tabAdded = true;
                makeNewEmployer();
            }
            else
            {
                TabPage employerTab1 = new TabPage("New Employer");
                currentTab.TabPages.Add(employerTab1);
                int numberTabs = currentTab.TabCount - 1;
                currentTab.SelectedIndex = numberTabs;
                makeNewEmployer();
            }
        }

        //If the new field placement button is clicked, make a new tab with the new field placement window in it
        private void fieldButton_Click(object sender, EventArgs e)
        {
            currentTab.Size = new Size(696, 585);
            currentTab.BringToFront();
            if (tabAdded == false)
            {
                primaryTab.Text = "New Field Placement";
                tabAdded = true;
                makeNewFieldPlacement();
            }
            else
            {
                TabPage fieldTab1 = new TabPage("New Field Placement");
                currentTab.TabPages.Add(fieldTab1);
                int numberTabs = currentTab.TabCount - 1;
                currentTab.SelectedIndex = numberTabs;
                makeNewFieldPlacement();
            }
        }


        
        //Methods for creating an instance of each respective Windows Form
        public void makeNewEmployee()
        {
            NewEmployee employeeWindow = new NewEmployee(this, employeesTable, currentTab, idColumn, recentsBar, empRepList);
            employeeWindow.TopLevel = false;
            employeeWindow.Visible = true;
            employeeWindow.FormBorderStyle = FormBorderStyle.None;
            employeeWindow.Dock = DockStyle.Fill;
            currentTab.TabPages[currentTab.SelectedIndex].Controls.Add(employeeWindow);
            newEmployeeWindow = employeeWindow;
        }
        public void makeNewEmployer()
        {
            NewEmployer employerWindow = new NewEmployer(this, employersTable, currentTab, identColumn, recentsBar, emplerRepList);
            employerWindow.TopLevel = false;
            employerWindow.Visible = true;
            employerWindow.FormBorderStyle = FormBorderStyle.None;
            employerWindow.Dock = DockStyle.Fill;
            currentTab.TabPages[currentTab.SelectedIndex].Controls.Add(employerWindow);
            newEmployerWindow = employerWindow;
        }
        public void makeNewEval()
        {
            NewEvaluation evalWindow = new NewEvaluation(this, evalTable, currentTab, dateColumn, recentsBar);
            evalWindow.TopLevel = false;
            evalWindow.Visible = true;
            evalWindow.FormBorderStyle = FormBorderStyle.None;
            evalWindow.Dock = DockStyle.Fill;
            currentTab.TabPages[currentTab.SelectedIndex].Controls.Add(evalWindow);
            newEvalWindow = evalWindow;
        }
        public void makeNewFieldPlacement()
        {
            NewFieldPlacement fieldWindow = new NewFieldPlacement(this, fieldTable, currentTab, emplerIDColumn, recentsBar);
            fieldWindow.TopLevel = false;
            fieldWindow.Visible = true;
            fieldWindow.FormBorderStyle = FormBorderStyle.None;
            fieldWindow.Dock = DockStyle.Fill;
            currentTab.TabPages[currentTab.SelectedIndex].Controls.Add(fieldWindow);
            newFieldPlacementWindow = fieldWindow;
        }
        
        //Method for tab deletion
        public void deleteCurrentTab()
        {
            if (currentTab.TabCount == 1)
            {
                currentTab.TabPages.Remove(currentTab.SelectedTab);
                currentTab.SelectedIndex = currentTab.TabCount - 1;
                homeButton_Click(null, null);

            }
            else
            {
                currentTab.TabPages.Remove(currentTab.SelectedTab);
                currentTab.SelectedIndex = currentTab.TabCount - 1;
            }
        }




    //SHORTCUTS
          //Menu Bar Shortcuts

            //Method for creating a new employee when you press File -> New -> Employee
            private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
            {
                employeeButton_Click(null, null); 
            }

            //Method for creating a new evaluation when you press File -> New -> Evaluation
            private void newEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
            {
                evalbutton_Click(null, null);
            }

            //Method for creating a new employer when you press File -> New -> Employer
            private void newEmployerToolStripMenuItem_Click(object sender, EventArgs e)
            {
                employerButton_Click(null, null);
            }

            //Method for creating a new field placement when you press File -> New -> Field Placement
            private void newFieldPlacementToolStripMenuItem_Click(object sender, EventArgs e)
            {
                fieldButton_Click(null, null);
            }

            //Method that brings the user to the reports tab when File -> View Reports is selected
            private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
            {
                mainTab_Click(null, null);
                reportsTab.Select();
                reportsTab.Show();
                reportsTab.BringToFront();
                mainTab.SelectedIndex = 4;
            }
            
        //Method to call up the help window when the help button is clicked
            private void helpToolStripMenuItem_Click(object sender, EventArgs e)
            {
                HelpWindow helpWindow = new HelpWindow();
                helpWindow.ShowDialog();
            }
          
        //Print menu strip options
        //Method to sort by evaluation score
          private void byEvaluationScoreToolStripMenuItem_Click(object sender, EventArgs e)
          {
              int i = 1;
              string sortedPath = @"C:\MMT Temp Services\Sorted Employees.txt";
              Tools.importReadCreate(mainEvalFilePath, i);
              printFilePath = sortedPath;
              PrintDocument printDoc = new PrintDocument();
              printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
              PrintDialog printDiagBox = new PrintDialog();
              printFont = new System.Drawing.Font("Arial", 10);
              printDiagBox.Document = printDoc;
              if (MessageBox.Show("Would you like to preview the document before printing?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
              {
                  PrintPreviewDialog printPrev = new PrintPreviewDialog();
                  printPrev.Width = 725;
                  printPrev.Height = 850;
                  printPrev.Document = printDoc;
                  printPrev.ShowDialog();
              }
              if (printDiagBox.ShowDialog() == DialogResult.OK)
              {
                  printDoc.DocumentName = printFilePath;
                  printDoc.Print();
                  printDiagBox.Dispose();
                  printDoc.Dispose();
              }
              else
              {
                  MessageBox.Show("Cancelled the print job.");
              }
          }
        //Method to sort by the employer name
          private void byEmployerNameToolStripMenuItem_Click(object sender, EventArgs e)
          {
              int i = 2;
              string sortedPath = @"C:\MMT Temp Services\Sorted Employees.txt";
              Tools.importReadCreate(mainEvalFilePath, i);
              printFilePath = sortedPath;
              PrintDocument printDoc = new PrintDocument();
              printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
              PrintDialog printDiagBox = new PrintDialog();
              printFont = new System.Drawing.Font("Arial", 10);
              printDiagBox.Document = printDoc;
              if (MessageBox.Show("Would you like to preview the document before printing?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
              {
                  PrintPreviewDialog printPrev = new PrintPreviewDialog();
                  printPrev.Width = 725;
                  printPrev.Height = 850;
                  printPrev.Document = printDoc;
                  printPrev.ShowDialog();
              }
              if (printDiagBox.ShowDialog() == DialogResult.OK)
              {
                  printDoc.DocumentName = printFilePath;
                  printDoc.Print();
                  printDiagBox.Dispose();
                  printDoc.Dispose();
              }
              else
              {
                  MessageBox.Show("Cancelled the print job.");
              }
          }
        //Method to sort by the employee's first name
          private void byEmployeeFirstNameToolStripMenuItem_Click(object sender, EventArgs e)
          {
              int i = 3;
              string sortedPath = @"C:\MMT Temp Services\Sorted Employees.txt";
              Tools.importReadCreate(mainEvalFilePath, i);
              printFilePath = sortedPath;
              PrintDocument printDoc = new PrintDocument();
              printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
              PrintDialog printDiagBox = new PrintDialog();
              printFont = new System.Drawing.Font("Arial", 10);
              printDiagBox.Document = printDoc;
              if (MessageBox.Show("Would you like to preview the document before printing?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
              {
                  PrintPreviewDialog printPrev = new PrintPreviewDialog();
                  printPrev.Width = 725;
                  printPrev.Height = 850;
                  printPrev.Document = printDoc;
                  printPrev.ShowDialog();
              }
              if (printDiagBox.ShowDialog() == DialogResult.OK)
              {
                  printDoc.DocumentName = printFilePath;
                  printDoc.Print();
                  printDiagBox.Dispose();
                  printDoc.Dispose();
              }
              else
              {
                  MessageBox.Show("Cancelled the print job.");
              }
          }
        //Method bringing the user to the reports tab when you click Print -> Individual Reports
          private void individualReportsToolStripMenuItem_Click(object sender, EventArgs e)
          {
              mainTab_Click(null, null);
              reportsTab.Select();
              reportsTab.Show();
              reportsTab.BringToFront();
              mainTab.SelectedIndex = 4;
          }
       //Event handler for when you print the file
          private void PrintPage(object sender, PrintPageEventArgs e)
          {
              
              StreamReader fileToPrint = new StreamReader(printFilePath);
              float yPos = 0f;
              int count = 0;
              float leftMargin = e.MarginBounds.Left;
              float topMargin = e.MarginBounds.Top;
              string line = null;
              float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
              while (count < linesPerPage)
              {
                  line = fileToPrint.ReadLine();
                  if (line == null)
                  {
                      break;
                  }
                  yPos = topMargin + count * printFont.GetHeight(e.Graphics);
                  e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                  count++;
              }
              if (line != null)
              {
                  e.HasMorePages = true;
              }
              fileToPrint.Close();
          }
 



    //Keyboard Shortcuts
          protected override bool ProcessCmdKey(ref Message msg, Keys keyboardShortcuts)
            {
                {
                    if (keyboardShortcuts == (Keys.Control | Keys.N))
                    {
                        employeeButton_Click(null, null);
                        return true;
                    }
                    else if (keyboardShortcuts == (Keys.Control | Keys.E))
                    {
                        evalbutton_Click(null, null);
                        return true;
                    }
                    else if (keyboardShortcuts == (Keys.Control | Keys.Shift | Keys.N))
                    {
                        employerButton_Click(null, null);
                        return true;
                    }
                    else if (keyboardShortcuts == (Keys.Control | Keys.L))
                    {
                        fieldButton_Click(null, null);
                        return true;
                    }
                    else if (keyboardShortcuts == (Keys.Control | Keys.R))
                    {
                        mainTab_Click(null, null);
                        reportsTab.Select();
                        reportsTab.Show();
                        reportsTab.BringToFront();
                        mainTab.SelectedIndex = 4;
                        return true;
                    }

                    return base.ProcessCmdKey(ref msg, keyboardShortcuts);
                }
            }
    //END OF SHORTCUTS


//REPORT METHODS AND EVENTS

          //Method for saving the edited file
          public void saveFile(string path, string name)
          {
              if(!System.IO.Directory.Exists(mmtMainPath + @"/Backups"))
              {
                  System.IO.Directory.CreateDirectory(mmtMainPath + @"/Backups");
              }

              if(path.Contains("Employee"))
              {
                  Employee foundEmployee = Tools.findEmployee(name);
                  MainForm.Employees.Remove(foundEmployee);
                  MainForm.Employees.Add(new Employee(empIDBox.Text, empFNameBox.Text, empLNameBox.Text, empEmailBox.Text, empHPhoneBox.Text, empCPhoneBox.Text, empAddressBox.Text,
                      empAddressbox2.Text, empCityBox.Text, empStateBox.Text, empZipBox.Text));


                  /* The following sequence of code reads the employees CSV, finds the old line for the edited employee,
                   * and if the old ID's match, don't write that csv line to the new csv file, otherwise write each employee
                   * line to the new csv. Then, replace the contents of the original Employees.txt file with the contents
                   * of the new employees CSV (The one sans unedited employee), delete the "new" employee csv and then
                   * write the edited employee to the csv. Essentially, this sequence replaces the unedited employee with the edited employee.
                   */
                  string backupPath = mmtMainPath + @"Backups\Employees_Backup.txt";
                  string newPath = mmtMainPath + "Employees1.txt";
                  string next = null;
                  using (StreamReader reader = new StreamReader(path))
                  {
                      using (StreamWriter writer = new StreamWriter(newPath))
                      {
                          while ((next = reader.ReadLine()) != null)
                          {
                              string[] tokenArray = next.Split(new char[] { ',' });
                              if (String.Compare(tokenArray[0], foundEmployee.empID) == 0)
                              {

                              }
                              else
                              {
                                  if (tokenArray[0].Equals(""))
                                  {

                                  }
                                  else
                                  {
                                      writer.WriteLine(next);
                                  }
                              }
                          }
                      }
                  }
                  string[] empData = {empIDBox.Text, empFNameBox.Text, empLNameBox.Text, empEmailBox.Text, empHPhoneBox.Text, empCPhoneBox.Text, empAddressBox.Text,
                      empAddressbox2.Text, empCityBox.Text, empStateBox.Text, empZipBox.Text};
                  string finalEmpData = Tools.formatToCSV(empData);
                  System.IO.File.AppendAllText(newPath, finalEmpData);
                  System.IO.File.Replace(newPath, path, backupPath);
                  empRepList.Items.Clear();
                  Tools.readAndBindEmpCustomObject(path, empRepList);
              }
              else if(path.Contains("Employer"))
              {
                  Employer foundEmployer = Tools.findEmployer(name);
                  MainForm.Employers.Remove(foundEmployer);
                  MainForm.Employers.Add(new Employer(emplrIDBox.Text, compNameBox.Text, compEmailBox.Text, compPhoneBox.Text, compAddressBox.Text, compAddress2Box.Text,
                      compCityBox.Text, compStateBox.Text, compZipBox.Text, compRepBox.Text));

                  string backupPath = mmtMainPath + @"Backups\Employers_Backup.txt";
                  string newPath = mmtMainPath + "Employers1.txt";
                  string next = null;
                  using (StreamReader reader = new StreamReader(path))
                  {
                      using (StreamWriter writer = new StreamWriter(newPath))
                      {
                          while ((next = reader.ReadLine()) != null)
                          {
                              string[] tokenArray = next.Split(new char[] { ',' });
                              if (String.Compare(tokenArray[0], foundEmployer.emplrID) == 0)
                              {

                              }
                              else
                              {
                                  if (tokenArray[0].Equals(""))
                                  {

                                  }
                                  else
                                  {
                                      writer.WriteLine(next);
                                  }
                              }
                          }
                      }
                  }

                  string[] emplrData = {emplrIDBox.Text, compNameBox.Text, compEmailBox.Text, compPhoneBox.Text, compAddressBox.Text, compAddress2Box.Text,
                      compCityBox.Text, compStateBox.Text, compZipBox.Text, compRepBox.Text};
                  string finalEmplrData = Tools.formatToCSV(emplrData);
                  System.IO.File.AppendAllText(newPath, finalEmplrData);
                  System.IO.File.Replace(newPath, path, backupPath);
                  emplerRepList.Items.Clear();
                  Tools.readAndBindEmplerCustomObject(path, emplerRepList);
              }
              
          }


        //When you select an employee report, populate the text boxes with that employees info.
          private void empRepList_SelectedIndexChanged(object sender, EventArgs e)
          {
              whatPath = 1;
              introPanel.Hide();
              emplrReportPanel.Hide();
              empReportPanel.Show();
              empReportPanel.BringToFront();
              selectedEmployee = (string)empRepList.SelectedItem;
               Employee desiredEmployee = Tools.findEmployee(selectedEmployee);
              if (desiredEmployee == null)
              {
                  MessageBox.Show("The employee could not be found.");
              }
              else
              {
                  empIDBox.Text = desiredEmployee.empID;
                  empFNameBox.Text = desiredEmployee.first;
                  empLNameBox.Text = desiredEmployee.last;
                  empEmailBox.Text = desiredEmployee.email;
                  empHPhoneBox.Text = desiredEmployee.home;
                  empCPhoneBox.Text = desiredEmployee.cell;
                  empAddressBox.Text = desiredEmployee.address;
                  empAddressbox2.Text = desiredEmployee.address2;
                  empCityBox.Text = desiredEmployee.theCity;
                  empStateBox.Text = desiredEmployee.theState;
                  empZipBox.Text = desiredEmployee.zip;
                  companyLabel.Text = desiredEmployee.company;
              }
              
          }
        //When you click the view evaluations button, make a new view evaluations window based on all of the employee's evaluations.
          private void viewEvalsButton_Click(object sender, EventArgs e)
          {
              string empData = empIDBox.Text + " " + empFNameBox.Text + " " + empLNameBox.Text;
              Employee pickedEmployee = Tools.findEmployee(empData);
              ViewEval viewEvals = new ViewEval(pickedEmployee);
              viewEvals.ShowDialog();
          }

        //When you select and employer report, populate the text boxes with the employer's info.
          private void emplerRepList_SelectedIndexChanged(object sender, EventArgs e)
          {
              whatPath = 2;
              introPanel.Hide();
              empReportPanel.Hide();
              emplrReportPanel.Show();
              emplrReportPanel.BringToFront();
              selectedEmployer = (string)emplerRepList.SelectedItem;
              Employer desiredEmployer = Tools.findEmployer(selectedEmployer);
              if (desiredEmployer == null)
              {
                  MessageBox.Show("The employer could not be found.");
              }
              else
              {
                  emplrIDBox.Text = desiredEmployer.emplrID;
                  compNameBox.Text = desiredEmployer.compName;
                  compEmailBox.Text = desiredEmployer.email;
                  compPhoneBox.Text = desiredEmployer.compPhone;
                  compAddressBox.Text = desiredEmployer.address;
                  compAddress2Box.Text = desiredEmployer.address2;
                  compCityBox.Text = desiredEmployer.theCity;
                  compStateBox.Text = desiredEmployer.theState;
                  compZipBox.Text = desiredEmployer.zip;
                  compRepBox.Text = desiredEmployer.companyRep;
              }

          }

        //What happens when you click the save button
          private void repSaveButton_Click(object sender, EventArgs e)
          {
              if (MessageBox.Show("In order for changes to take full effect, the applicaton must restart. Continue?",
                  "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
              {
                  if (whatPath == 1)
                  {
                      saveFile(mainEmployeesFilePath, selectedEmployee);

                  }
                  else if (whatPath == 2)
                  {
                      saveFile(mainEmployersFilePath, selectedEmployer);
                  }
                  Application.Restart();
              }
              else
              {
                  MessageBox.Show("Note: choosing employees for evaluations will not work until the app is restarted manually.");
              }
          }

        //When you click the print button, save the file and print out the information.
          public void repPrintButton_Click(object sender, EventArgs e)
          {
              repSaveButton_Click(null, null);

              if (whatPath == 1)
              {
                  printFilePath = mmtMainPath + selectedEmployee + ".txt";
                  StreamWriter writer = new StreamWriter(printFilePath);
                  writer.WriteLine("Employee Identifier: " + empIDBox.Text);
                  writer.WriteLine();
                  writer.WriteLine("First: " + empFNameBox.Text + "    Last: " + empLNameBox.Text);
                  writer.WriteLine();
                  writer.WriteLine("Email: " + empEmailBox.Text);
                  writer.WriteLine();
                  writer.WriteLine("Home #: " + empHPhoneBox.Text + "    Cell #: " + empCPhoneBox.Text);
                  writer.WriteLine();
                  writer.WriteLine("Address: " + empAddressBox.Text + "    Address 2: " + empAddressbox2.Text);
                  writer.WriteLine();
                  writer.WriteLine("City: " + empCityBox.Text + "    State: " + empStateBox.Text);
                  writer.WriteLine();
                  writer.WriteLine("Zip: " + empZipBox.Text);
                  writer.WriteLine();
                  writer.WriteLine();
                  writer.WriteLine("Employer: " + companyLabel.Text);
                  writer.Close();
              }
              else if (whatPath == 2)
              {
                  printFilePath = mmtMainPath + selectedEmployer + ".txt";
                  StreamWriter writer = new StreamWriter(printFilePath);
                  writer.WriteLine("Employer Identifier: " + emplrIDBox.Text);
                  writer.WriteLine();
                  writer.WriteLine("Company Name: " + compNameBox.Text);
                  writer.WriteLine();
                  writer.WriteLine("Company Email: " + compEmailBox.Text + "    Company Phone #: " + compPhoneBox.Text);
                  writer.WriteLine();
                  writer.WriteLine("Company Address: " + compAddressBox.Text + "    Company Address 2: " + compAddress2Box.Text);
                  writer.WriteLine();
                  writer.WriteLine("City: " + compCityBox.Text + "    State: " + compStateBox.Text);
                  writer.WriteLine();
                  writer.WriteLine("Zip: " + compZipBox.Text);
                  writer.WriteLine();
                  writer.WriteLine();
                  writer.WriteLine("Company Representative: " + compRepBox.Text);
                  writer.Close();
              }
             

              PrintDocument printDoc = new PrintDocument(); 

              printDoc.PrintPage += new PrintPageEventHandler(PrintPage);  
              
              PrintDialog printDiagBox = new PrintDialog();
              printFont = new System.Drawing.Font("Arial", 10);
              printDiagBox.Document = printDoc;
              if (MessageBox.Show("Would you like to preview the document before printing?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
              {
                  PrintPreviewDialog printPrev = new PrintPreviewDialog();
                  printPrev.Width = 725;
                  printPrev.Height = 850;
                  printPrev.Document = printDoc;
                  printPrev.ShowDialog();
              }
              if (printDiagBox.ShowDialog() == DialogResult.OK)
              {

                  printDoc.DocumentName = printFilePath;
                  printDoc.Print();
                  
              }

              else
              {
                  MessageBox.Show("Cancelled the print job.");
              }
              printDiagBox.Dispose();
              printDoc.Dispose();
              System.IO.File.Delete(printFilePath);
          }






       










    }
}
