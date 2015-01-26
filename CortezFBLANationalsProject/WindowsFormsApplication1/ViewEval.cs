using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CortezFBLA
{
    public partial class ViewEval : Form
    {
        static string mmtMainPath = @"C:\MMT Temp Services\";
        public static Employee emp;
        public static Evaluation desiredEval;
        public static string selectedEval;
        Font printFont;
        string printFilePath;


        public ViewEval(Employee newEmployee)
        {
            emp = newEmployee;
            InitializeComponent();
    
            Tools.bindEvalData(emp, evalListBox);
            evalForLabel.Text = emp.name;
        }

        private void ViewEval_Load(object sender, EventArgs e)
        {

        }
        //When you select another evaluation, populate the boxes with the information from the selected evaluation.
        private void evalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEval = (string)evalListBox.SelectedItem;
            desiredEval = Tools.findEval(selectedEval, emp);
            idLabel.Text = desiredEval.evalID;
            empNameLabel.Text = emp.company;
            dateEvaledLabel.Text = desiredEval.currentEvalDate;
            workQualScoreLabel.Text = desiredEval.workQualScore;
            workQualBox.Text = desiredEval.workQualComments.Replace('|', ',');
            workHabScoreLabel.Text = desiredEval.workHabScore;
            workHabBox.Text = desiredEval.workHabComments.Replace('|', ',');
            jobKnowScoreLabel.Text = desiredEval.jobKnowScore;
            jobKnowBox.Text = desiredEval.jobKnowComments.Replace('|', ',');
            behaviorScoreLabel.Text = desiredEval.behaviorScore;
            behaviorBox.Text = desiredEval.behaviorComments.Replace('|', ',');
            overallProgScoreLabel.Text = desiredEval.overallProgScore;
            overallProgBox.Text = desiredEval.overallProgressComments.Replace('|', ',');
            avgScoreLabel.Text = desiredEval.avgScore;
            recommendLabel.Text = desiredEval.recommend;
            nextEvalLabel.Text = desiredEval.nextEvalDate;
        }

        //When you click the print button, print out the evaluation info in report form.
        private void printEvalButton_Click(object sender, EventArgs e)
        {
            printFilePath = mmtMainPath + ViewEval.selectedEval.Replace('/', '_') + ".txt";
            StreamWriter writer = new StreamWriter(printFilePath);
            writer.WriteLine("Evaluation ID: " + ViewEval.desiredEval.evalID);
            writer.WriteLine();
            writer.WriteLine("Employer: " + ViewEval.emp.company);
            writer.WriteLine();
            writer.WriteLine("Date Evaluated: " + ViewEval.desiredEval.currentEvalDate);
            writer.WriteLine();
            writer.WriteLine("Work Quality");
            writer.WriteLine();
            writer.WriteLine("Score: " + ViewEval.desiredEval.workQualScore);
            writer.WriteLine();
            writer.WriteLine("Comments: " + ViewEval.desiredEval.workQualComments.Replace('|', ','));
            writer.WriteLine();
            writer.WriteLine("Work Habits");
            writer.WriteLine();
            writer.WriteLine("Score: " + ViewEval.desiredEval.workHabScore);
            writer.WriteLine();
            writer.WriteLine("Comments: " + ViewEval.desiredEval.workHabComments.Replace('|', ','));
            writer.WriteLine();
            writer.WriteLine("Job Knowledge");
            writer.WriteLine();
            writer.WriteLine("Score: " + ViewEval.desiredEval.jobKnowScore);
            writer.WriteLine();
            writer.WriteLine("Comments: " + ViewEval.desiredEval.jobKnowComments.Replace('|', ','));
            writer.WriteLine();
            writer.WriteLine("Behavior");
            writer.WriteLine();
            writer.WriteLine("Score: " + ViewEval.desiredEval.behaviorScore);
            writer.WriteLine();
            writer.WriteLine("Comments: " + ViewEval.desiredEval.behaviorComments.Replace('|', ','));
            writer.WriteLine();
            writer.WriteLine("Overall Progress");
            writer.WriteLine();
            writer.WriteLine("Score: " + ViewEval.desiredEval.overallProgScore);
            writer.WriteLine();
            writer.WriteLine("Comments: " + ViewEval.desiredEval.overallProgressComments.Replace('|', ','));
            writer.WriteLine();
            writer.WriteLine();
            writer.WriteLine("Average Score: " + ViewEval.desiredEval.avgScore);
            writer.WriteLine();
            writer.WriteLine("Would Recommend? : " + ViewEval.desiredEval.recommend);
            writer.WriteLine();
            writer.WriteLine("Next Evaluation Date: " + ViewEval.desiredEval.nextEvalDate);
            writer.WriteLine();
            writer.Close();

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            PrintDialog printDiagBox = new PrintDialog();
            printFont = new System.Drawing.Font("Arial", 10);
            printDiagBox.Document = printDoc;
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
        
        //Print document event handler
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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



        

    }
}
