using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CortezFBLA
{
    public partial class HelpWindow : Form
    {
        public HelpWindow()
        {
            InitializeComponent();
        }
               

       //Methods that show and hide each help panel as the previous and next buttons are pressed
        private void introHelpNextButton_Click(object sender, EventArgs e)
        {
            introHelpPanel.Hide();
        }        
        
        private void employeeHelpPrevButton_Click(object sender, EventArgs e)
        {
            introHelpPanel.Show();
            introHelpPanel.BringToFront();
        }

        private void employeeHelpNextButton_Click(object sender, EventArgs e)
        {
            employeeHelpPanel.Hide();
        }
        
        private void employerHelpPrevbutton_Click(object sender, EventArgs e)
        {
            employeeHelpPanel.Show();
            employeeHelpPanel.BringToFront();
        }

        private void employerHelpNextButton_Click(object sender, EventArgs e)
        {
            employerHelpPanel.Hide();
        } 
        
        private void fieldHelpPrevButton_Click(object sender, EventArgs e)
        {
            employerHelpPanel.Show();
            employerHelpPanel.BringToFront();
        }

        private void fieldHelpNextButton_Click(object sender, EventArgs e)
        {
            fieldHelpPanel.Hide();
        }

        private void evalHelpPrevButton_Click(object sender, EventArgs e)
        {
            fieldHelpPanel.Show();
            fieldHelpPanel.BringToFront();
        }

        private void evalHelpNextButton_Click(object sender, EventArgs e)
        {
            evalHelpPanel.Hide();
        }

        private void reportHelpPrevButton_Click(object sender, EventArgs e)
        {
            evalHelpPanel.Show();
            evalHelpPanel.BringToFront();
        }

        private void reportHelpNextButton_Click(object sender, EventArgs e)
        {
            reportHelpPanel.Hide();
        }
        
        private void getStartedPrevButton_Click(object sender, EventArgs e)
        {
            reportHelpPanel.Show();
            reportHelpPanel.BringToFront();
        }

        private void getStartedFinishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }








       

      
    }
}
