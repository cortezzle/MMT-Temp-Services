namespace CortezFBLA
{
    partial class NewFieldPlacement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employerSelectPanel = new System.Windows.Forms.Panel();
            this.LinkNextButton = new System.Windows.Forms.Button();
            this.employerListbox = new System.Windows.Forms.ListBox();
            this.selectEmployerLabel = new System.Windows.Forms.Label();
            this.LinkCancelButton = new System.Windows.Forms.Button();
            this.employeeSelectPanel = new System.Windows.Forms.Panel();
            this.linkButton = new System.Windows.Forms.Button();
            this.employeeListbox = new System.Windows.Forms.ListBox();
            this.selectEmployeeLabel = new System.Windows.Forms.Label();
            this.employerSelectPanel.SuspendLayout();
            this.employeeSelectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employerSelectPanel
            // 
            this.employerSelectPanel.Controls.Add(this.LinkNextButton);
            this.employerSelectPanel.Controls.Add(this.employerListbox);
            this.employerSelectPanel.Controls.Add(this.selectEmployerLabel);
            this.employerSelectPanel.Location = new System.Drawing.Point(0, 0);
            this.employerSelectPanel.Name = "employerSelectPanel";
            this.employerSelectPanel.Size = new System.Drawing.Size(340, 543);
            this.employerSelectPanel.TabIndex = 0;
            // 
            // LinkNextButton
            // 
            this.LinkNextButton.BackColor = System.Drawing.Color.DarkRed;
            this.LinkNextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.LinkNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LinkNextButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkNextButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LinkNextButton.Location = new System.Drawing.Point(242, 494);
            this.LinkNextButton.Name = "LinkNextButton";
            this.LinkNextButton.Size = new System.Drawing.Size(75, 23);
            this.LinkNextButton.TabIndex = 2;
            this.LinkNextButton.Text = "Next";
            this.LinkNextButton.UseVisualStyleBackColor = false;
            this.LinkNextButton.Click += new System.EventHandler(this.LinkNextButton_Click);
            // 
            // employerListbox
            // 
            this.employerListbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employerListbox.FormattingEnabled = true;
            this.employerListbox.Items.AddRange(new object[] {
            ""});
            this.employerListbox.Location = new System.Drawing.Point(22, 84);
            this.employerListbox.Name = "employerListbox";
            this.employerListbox.Size = new System.Drawing.Size(207, 433);
            this.employerListbox.TabIndex = 1;
            this.employerListbox.SelectedIndexChanged += new System.EventHandler(this.employerListbox_SelectedIndexChanged);
            // 
            // selectEmployerLabel
            // 
            this.selectEmployerLabel.AutoSize = true;
            this.selectEmployerLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectEmployerLabel.Location = new System.Drawing.Point(19, 47);
            this.selectEmployerLabel.Name = "selectEmployerLabel";
            this.selectEmployerLabel.Size = new System.Drawing.Size(233, 13);
            this.selectEmployerLabel.TabIndex = 0;
            this.selectEmployerLabel.Text = "First, select an employer from the list below:";
            // 
            // LinkCancelButton
            // 
            this.LinkCancelButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LinkCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.LinkCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LinkCancelButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkCancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LinkCancelButton.Location = new System.Drawing.Point(264, 3);
            this.LinkCancelButton.Name = "LinkCancelButton";
            this.LinkCancelButton.Size = new System.Drawing.Size(75, 23);
            this.LinkCancelButton.TabIndex = 3;
            this.LinkCancelButton.Text = "Cancel";
            this.LinkCancelButton.UseVisualStyleBackColor = false;
            this.LinkCancelButton.Click += new System.EventHandler(this.LinkCancelButton_Click);
            // 
            // employeeSelectPanel
            // 
            this.employeeSelectPanel.Controls.Add(this.LinkCancelButton);
            this.employeeSelectPanel.Controls.Add(this.linkButton);
            this.employeeSelectPanel.Controls.Add(this.employeeListbox);
            this.employeeSelectPanel.Controls.Add(this.selectEmployeeLabel);
            this.employeeSelectPanel.Location = new System.Drawing.Point(334, 0);
            this.employeeSelectPanel.Name = "employeeSelectPanel";
            this.employeeSelectPanel.Size = new System.Drawing.Size(340, 543);
            this.employeeSelectPanel.TabIndex = 1;
            // 
            // linkButton
            // 
            this.linkButton.BackColor = System.Drawing.Color.DarkRed;
            this.linkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.linkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.linkButton.Location = new System.Drawing.Point(237, 482);
            this.linkButton.Name = "linkButton";
            this.linkButton.Size = new System.Drawing.Size(94, 35);
            this.linkButton.TabIndex = 2;
            this.linkButton.Text = "Link";
            this.linkButton.UseVisualStyleBackColor = false;
            this.linkButton.Visible = false;
            this.linkButton.Click += new System.EventHandler(this.linkButton_Click);
            // 
            // employeeListbox
            // 
            this.employeeListbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeListbox.FormattingEnabled = true;
            this.employeeListbox.Items.AddRange(new object[] {
            ""});
            this.employeeListbox.Location = new System.Drawing.Point(21, 84);
            this.employeeListbox.Name = "employeeListbox";
            this.employeeListbox.Size = new System.Drawing.Size(207, 433);
            this.employeeListbox.TabIndex = 1;
            this.employeeListbox.Visible = false;
            this.employeeListbox.SelectedIndexChanged += new System.EventHandler(this.employeeListbox_SelectedIndexChanged);
            // 
            // selectEmployeeLabel
            // 
            this.selectEmployeeLabel.AutoSize = true;
            this.selectEmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectEmployeeLabel.Location = new System.Drawing.Point(18, 47);
            this.selectEmployeeLabel.Name = "selectEmployeeLabel";
            this.selectEmployeeLabel.Size = new System.Drawing.Size(202, 13);
            this.selectEmployeeLabel.TabIndex = 3;
            this.selectEmployeeLabel.Text = "Now, select an employee to be linked:";
            this.selectEmployeeLabel.Visible = false;
            // 
            // NewFieldPlacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 543);
            this.Controls.Add(this.employeeSelectPanel);
            this.Controls.Add(this.employerSelectPanel);
            this.MaximizeBox = false;
            this.Name = "NewFieldPlacement";
            this.Text = "NewFieldPlacement";
            this.employerSelectPanel.ResumeLayout(false);
            this.employerSelectPanel.PerformLayout();
            this.employeeSelectPanel.ResumeLayout(false);
            this.employeeSelectPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel employerSelectPanel;
        private System.Windows.Forms.Panel employeeSelectPanel;
        private System.Windows.Forms.Label selectEmployerLabel;
        private System.Windows.Forms.ListBox employerListbox;
        private System.Windows.Forms.ListBox employeeListbox;
        private System.Windows.Forms.Label selectEmployeeLabel;
        private System.Windows.Forms.Button LinkNextButton;
        private System.Windows.Forms.Button linkButton;
        private System.Windows.Forms.Button LinkCancelButton;
    }
}