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
    public static class Tools
    {

        //Format fields array into CSV formatted string
        public static string formatToCSV(string[] fields)
        {
            string formattedFields = null;
            for (int l = 0; l < fields.Length; l++)
            {
                formattedFields += fields[l] + ",";
            }
            string removeLastComma = formattedFields.Substring(0, formattedFields.Length - 1);
            string finalFormattedFields = removeLastComma + "\n";
            return finalFormattedFields;
        }

        //Import a csv and add its values to a new object
        public static void importCSV(string path)
       {
           StreamReader CSVReader = new StreamReader(path);
           while (!CSVReader.EndOfStream)
           {
               List<string> tokens = new List<string>();
               string lineString = CSVReader.ReadLine();
               string[] tokenArray = lineString.Split(new char[] { ',' });
               for (int i = 0; i < tokenArray.Length; i++)
               {
                   tokens.Add(tokenArray[i]);
               }
               if(tokens.ElementAt(0).Equals(""))
               {
                   
               }
               else
               {
                   //If the path is the employees path, gather the employee tokens, make a new employee, and add it to the main employees ArrayList.
                   if (path.Contains("Employees"))
                   {
                       string empID = tokens.ElementAt(0);
                       string fName = tokens.ElementAt(1);
                       string lName = tokens.ElementAt(2);
                       string empEmail = tokens.ElementAt(3);
                       string hPhone = tokens.ElementAt(4);
                       string cPhone = tokens.ElementAt(5);
                       string empAddress = tokens.ElementAt(6);
                       string empAddress2 = tokens.ElementAt(7);
                       string empCity = tokens.ElementAt(8);
                       string empState = tokens.ElementAt(9);
                       string empZip = tokens.ElementAt(10);
                       Employee newEmp = new Employee(empID, fName, lName, empEmail, hPhone, cPhone, empAddress, empAddress2, empCity, empState, empZip);
                       MainForm.Employees.Add(newEmp);
                   }
                   //If the path is the employers path, gather the employer tokens, make a new employer, and add it to the main employers ArrayList.
                   else if(path.Contains("Employer"))
                   {
                       string emplrID = tokens.ElementAt(0);
                       string compName = tokens.ElementAt(1);
                       string compEmail = tokens.ElementAt(2);
                       string compPhone = tokens.ElementAt(3);
                       string compAddress = tokens.ElementAt(4);
                       string compAddress2 = tokens.ElementAt(5);
                       string compCity = tokens.ElementAt(6);
                       string compState = tokens.ElementAt(7);
                       string compZip = tokens.ElementAt(8);
                       string compRep = tokens.ElementAt(9);
                       Employer newEmplr = new Employer(emplrID, compName, compEmail, compPhone, compAddress, compAddress2, compCity, compState,
                           compZip, compRep);
                       MainForm.Employers.Add(newEmplr);
                   }
                   //If the path is the field placements path, gather the tokens, make a new F.P., and add it to the respective employee.
                   else if (path.Contains("Field Placement"))
                   {
                       string employerID = tokens.ElementAt(0);
                       string employerName = tokens.ElementAt(1);
                       string employer = employerID + " " + employerName;
                       string employeeID = tokens.ElementAt(2);
                       string employeeName = tokens.ElementAt(3);
                       string employee = employeeID + " " + employeeName;
                       FieldPlacement newFP = new FieldPlacement(employer, employee);
                       MainForm.FieldPlacements.Add(newFP);
                       for (int i = 0; i < MainForm.Employees.Count; i++)
                       {
                           Employee currentEmployee = MainForm.Employees.ElementAt(i);
                           if(currentEmployee.name.Equals(employeeName))
                           {
                           currentEmployee.company = employer;
                           }
                       }
                   }
                   //If the path is the evaluation path, gather the evaluation tokens, make a new evaluation, and add it to the respective employee.
                   else if(path.Contains("Evaluation"))
                   {
                       string evalDate = tokens.ElementAt(0).Replace('_', '/');
                       string evalIdent = tokens.ElementAt(1);
                       string employeeID = tokens.ElementAt(2);
                       string employeeName = tokens.ElementAt(3);
                       string employerID = tokens.ElementAt(4);
                       string employerName = tokens.ElementAt(5);
                       string nextEval = tokens.ElementAt(6);
                       string workQualityScore = tokens.ElementAt(7);
                       string workQualityComments = tokens.ElementAt(8);
                       string workHabitScore = tokens.ElementAt(9);
                       string workHabitComments = tokens.ElementAt(10);
                       string jobKnowledgeScore = tokens.ElementAt(11);
                       string jobKnowledgeComments = tokens.ElementAt(12);
                       string behavior_Score = tokens.ElementAt(13);
                       string behavior_Comments = tokens.ElementAt(14);
                       string averageScore = tokens.ElementAt(15);
                       string overallProgressScore = tokens.ElementAt(16);
                       string overallProgComments = tokens.ElementAt(17);
                       string recommended = tokens.ElementAt(18);
                       for (int i = 0; i < MainForm.Employees.Count; i++)
                       {
                           Employee currentEmp = MainForm.Employees.ElementAt(i);
                           string checkResult = employeeName;
                           string matchResult = currentEmp.name;
                           if (checkResult.Equals(matchResult))
                           {
                               MainForm.Employees.ElementAt(i).employeeEvaluations.Add(
                                   new Evaluation(evalDate, evalIdent, employeeID, employeeName, employerID, employerName, 
                          nextEval,  workQualityScore,  workQualityComments,  workHabitScore,  workHabitComments, 
                          jobKnowledgeScore,  jobKnowledgeComments,  behavior_Score,  behavior_Comments,  averageScore, 
                          overallProgressScore,  overallProgComments,  recommended));
                           }
                       }
                   }
               }
           }
           CSVReader.Close();
       }

        //Import any CSV and add its info to the specified table (DataGridView) and sort by specified column
        public static void readAndBindTableData(string path, DataGridView table, DataGridViewColumn column)
        {
            //Read the file
            StreamReader CSVReader = new StreamReader(path);
            while (!CSVReader.EndOfStream)
            {

                string lineString = CSVReader.ReadLine();
                string[] tokens = lineString.Split(new char[] { ',' });
                if (!(tokens[0].Equals("")))
                {
                    table.Rows.Add(tokens);
                }

            }
            CSVReader.Close();
            table.Sort(column, ListSortDirection.Ascending);
        }

        //Import Employees CSV for use in a class's custom objects (i.e. selection or list boxes)
        public static void readAndBindEmpCustomObject(string path, ComboBox selectionBox)
        {
            //Read the file
            StreamReader CSVReader = new StreamReader(path);
            List<string> theTokenArray = new List<string>();
            foreach(Employee emp in MainForm.Employees)
            {
                string empData = emp.empID + " " + emp.name;
                theTokenArray.Add(empData);            
            }
            theTokenArray.Sort();
            foreach (string token in theTokenArray)
            {
                selectionBox.Items.Add(token);
            }
            CSVReader.Close();

        }
        public static void readAndBindEmpCustomObject(string path, ListBox listBox)
        {
            //Read the file
            StreamReader CSVReader = new StreamReader(path);
            List<string> theTokenArray = new List<string>();
            while (!CSVReader.EndOfStream)
            {

                string lineString = CSVReader.ReadLine();
                string[] tokens = lineString.Split(new char[] { ',' });
                if (!(tokens[0].Equals("")))
                {
                    string firstThree = tokens[0] + " " + tokens[1] + " " + tokens[2];
                    theTokenArray.Add(firstThree);
                }

            }
            theTokenArray.Sort();
            foreach (string token in theTokenArray)
            {
                listBox.Items.Add(token);
            }
            CSVReader.Close();

        }

        //Import Employers CSV for use in a class's custom objects (i.e. selection or list boxes)
        public static void readAndBindEmplerCustomObject(string path, ComboBox selectionBox)
        {
            //Read the file
            StreamReader CSVReader = new StreamReader(path);
            List<string> theTokenArray = new List<string>();
            while (!CSVReader.EndOfStream)
            {

                string lineString = CSVReader.ReadLine();
                string[] tokens = lineString.Split(new char[] { ',' });
                if (!(tokens[0].Equals("")))
                {
                    string firstTwo = tokens[0] + " " + tokens[1];
                    theTokenArray.Add(firstTwo);
                }

            }
            theTokenArray.Sort();
            foreach (string token in theTokenArray)
            {
                selectionBox.Items.Add(token);
            }
            CSVReader.Close();

        }
        public static void readAndBindEmplerCustomObject(string path, ListBox listBox)
        {
            //Read the file
            StreamReader CSVReader = new StreamReader(path);
            List<string> theTokenArray = new List<string>();
            while (!CSVReader.EndOfStream)
            {

                string lineString = CSVReader.ReadLine();
                string[] tokens = lineString.Split(new char[] { ',' });
                if (!(tokens[0].Equals("")))
                {
                    string firstTwo = tokens[0] + " " + tokens[1];
                    theTokenArray.Add(firstTwo);
                }

            }
            theTokenArray.Sort();
            foreach (string token in theTokenArray)
            {
                listBox.Items.Add(token);
            }
            CSVReader.Close();

        }

        //Import Field Placements CSV for use in a class's custom objects (i.e. selection or list boxes)
        public static void readAndBindFieldCustomObject(string path, ComboBox selectionBox)
        {
            //Read the file
            StreamReader CSVReader = new StreamReader(path);
            List<string> theTokenArray = new List<string>();
            while (!CSVReader.EndOfStream)
            {

                string lineString = CSVReader.ReadLine();
                string[] tokens = lineString.Split(new char[] { ',' });
                if (!(tokens[0].Equals("")))
                {
                    string firstFour = tokens[0] + " " + tokens[1] + " | " + tokens[2] + " " + tokens[3];
                    theTokenArray.Add(firstFour);
                }

            }

            foreach (string token in theTokenArray)
            {
                selectionBox.Items.Add(token);
            }
            CSVReader.Close();

        }
        public static void readAndBindFieldCustomObject(string path, ListBox listBox)
        {
            //Read the file
            StreamReader CSVReader = new StreamReader(path);
            List<string> theTokenArray = new List<string>();
            while (!CSVReader.EndOfStream)
            {

                string lineString = CSVReader.ReadLine();
                string[] tokens = lineString.Split(new char[] { ',' });
                if (!(tokens[0].Equals("")))
                {
                    string firstFour = tokens[0] + " " + tokens[1] + " | " + tokens[2] + " " + tokens[3];
                    theTokenArray.Add(firstFour);
                }

            }

            foreach (string token in theTokenArray)
            {
                listBox.Items.Add(token);
            }
            CSVReader.Close();

        }

        //Import Evaluations CSV for use in a class's custom objects (i.e. selection or list boxes)
        public static void readAndBindEvalCustomObject(string path, ComboBox selectionBox)
        {
            //Read the file
            StreamReader CSVReader = new StreamReader(path);
            List<string> theTokenArray = new List<string>();
            while (!CSVReader.EndOfStream)
            {

                string lineString = CSVReader.ReadLine();
                string[] tokens = lineString.Split(new char[] { ',' });
                if (!(tokens[0].Equals("")))
                {
                    string firstThree = tokens[0] + " " + tokens[1] + " " + tokens[3];
                    theTokenArray.Add(firstThree);
                }

            }
            theTokenArray.Sort();
            foreach (string token in theTokenArray)
            {
                selectionBox.Items.Add(token);
            }
            CSVReader.Close();

        }
        public static void readAndBindEvalCustomObject(string path, ListBox listBox)
        {
            //Read the file
            StreamReader CSVReader = new StreamReader(path);
            List<string> theTokenArray = new List<string>();
            while (!CSVReader.EndOfStream)
            {

                string lineString = CSVReader.ReadLine();
                string[] tokens = lineString.Split(new char[] { ',' });
                if (!(tokens[0].Equals("")))
                {
                    string firstThree = tokens[0] + " " + tokens[1] + " " + tokens[3];
                    theTokenArray.Add(firstThree);
                }

            }
            theTokenArray.Sort();
            foreach (string token in theTokenArray)
            {
                listBox.Items.Add(token);
            }
            CSVReader.Close();

        }

        //Import, read, and create a data file from Evaluations, sorting the employees by score, employer, and name
        public static void importReadCreate(string path, int i)
        {
            string sortedPath = @"C:\MMT Temp Services\Sorted Employees.txt";
            StreamWriter fileWriter = new StreamWriter(sortedPath);
            StreamReader CSVReader = new StreamReader(path);
            List<string> theTokenArray = new List<string>();
            while (!CSVReader.EndOfStream)
            {

                string lineString = CSVReader.ReadLine();
                string[] tokens = lineString.Split(new char[] { ',' });
                if (!(tokens[0].Equals("")))
                {
                    string desiredTokens = null;
                    if (i == 1)
                    {
                        desiredTokens = tokens[15] + " " + tokens[5] + " " + tokens[3];
                    }
                    else if (i == 2)
                    {
                        desiredTokens = tokens[5] + " " + tokens[3] + " " + tokens[15];
                    }
                    else if (i == 3)
                    {
                        desiredTokens = tokens[3] + " " + tokens[15] + " " + tokens[5];
                    }
                    theTokenArray.Add(desiredTokens);
                }

            }
            theTokenArray.Sort();
            foreach (string token in theTokenArray)
            {

                fileWriter.WriteLine(token);
            }
            CSVReader.Close();
            fileWriter.Close();

        }

        //Based on a string with the employee name, locates the respective Employee from the main Employees ArrayList
        public static Employee findEmployee(string empName)
        {
            for (int i = 0; i < MainForm.Employees.Count; i++)
            {
                Employee emp = MainForm.Employees.ElementAt(i);
                string matchResult = emp.empID + " " + emp.name;
                if (matchResult.Equals(empName))
                {
                    return emp;
                }

            }
            return null;
        }
        //Based on a string with the employer name, locates the respective Employer from the main Employers ArrayList
        public static Employer findEmployer(string emplrName)
        {
            for (int r = 0; r < MainForm.Employers.Count; r++)
            {
                Employer emplr = MainForm.Employers.ElementAt(r);
                string matchResult = emplr.emplrID + " " + emplr.compName;
                if (matchResult.Equals(emplrName))
                {
                    return emplr;
                }

            }
            return null;
        }
        //Based on a string with the evaluation ID and Employee object, locates the respective evaluation from Employee's evaluation ArrayList
        public static Evaluation findEval(string evalName, Employee emp)
        {
            for (int i = 0; i < emp.employeeEvaluations.Count; i++)
            {
                
                Evaluation eval = emp.employeeEvaluations.ElementAt(i);
                string matchResult = eval.currentEvalDate + " " + eval.evalID + " " + eval.employee;
                if (matchResult.Contains(evalName))
                {
                    return eval;
                }
            }
            return null;
        }
        //Based on a string with the employee object and given listbox, binds the evaluation data to a custom object
        public static void bindEvalData(Employee emp, ListBox evalListBox)
        {
            for (int i = 0; i < emp.employeeEvaluations.Count; i++)
            {

                    string boxData = emp.employeeEvaluations.ElementAt(i).currentEvalDate + " " + emp.employeeEvaluations.ElementAt(i).evalID + " " +
                        emp.employeeEvaluations.ElementAt(i).employee;
                    evalListBox.Items.Add(boxData);
                
            }
        }
    }
}
