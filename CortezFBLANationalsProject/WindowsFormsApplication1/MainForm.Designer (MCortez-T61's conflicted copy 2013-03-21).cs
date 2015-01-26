namespace CortezFBLA
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.homeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldPlacementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byEvaluationScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byEmployerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byEmployeeFirstNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentsBar = new System.Windows.Forms.ListView();
            this.currentTab = new System.Windows.Forms.TabControl();
            this.primaryTab = new System.Windows.Forms.TabPage();
            this.fieldTab = new System.Windows.Forms.TabPage();
            this.fieldTable = new System.Windows.Forms.DataGridView();
            this.emplerIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleeIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerTab = new System.Windows.Forms.TabPage();
            this.employersTable = new System.Windows.Forms.DataGridView();
            this.identColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bizColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesTab = new System.Windows.Forms.TabPage();
            this.employeesTable = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationTab = new System.Windows.Forms.TabPage();
            this.homeView = new System.Windows.Forms.Panel();
            this.homeViewHeader = new System.Windows.Forms.Label();
            this.fieldButton = new System.Windows.Forms.Button();
            this.employerButton = new System.Windows.Forms.Button();
            this.evalButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.evalTable = new System.Windows.Forms.DataGridView();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empLastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.reportsTab = new System.Windows.Forms.TabPage();
            this.reportsPanel = new System.Windows.Forms.Panel();
            this.empReportPanel = new System.Windows.Forms.Panel();
            this.companyLabel = new System.Windows.Forms.Label();
            this.employerLabel = new System.Windows.Forms.Label();
            this.theZipLabel = new System.Windows.Forms.Label();
            this.theStateLabel = new System.Windows.Forms.Label();
            this.theCityLabel = new System.Windows.Forms.Label();
            this.sAddress2Label = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.cPhoneLabel = new System.Windows.Forms.Label();
            this.hPhoneLabel = new System.Windows.Forms.Label();
            this.emailAddLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.identLabel = new System.Windows.Forms.Label();
            this.empZipBox = new System.Windows.Forms.TextBox();
            this.empStateBox = new System.Windows.Forms.TextBox();
            this.empCityBox = new System.Windows.Forms.TextBox();
            this.empAddressBox = new System.Windows.Forms.TextBox();
            this.empAddressbox2 = new System.Windows.Forms.TextBox();
            this.empHPhoneBox = new System.Windows.Forms.TextBox();
            this.empCPhoneBox = new System.Windows.Forms.TextBox();
            this.empEmailBox = new System.Windows.Forms.TextBox();
            this.empFNameBox = new System.Windows.Forms.TextBox();
            this.empLNameBox = new System.Windows.Forms.TextBox();
            this.empIDBox = new System.Windows.Forms.TextBox();
            this.repPrintButton = new System.Windows.Forms.Button();
            this.repSaveButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.evalRepTab = new System.Windows.Forms.TabPage();
            this.evalRepList = new System.Windows.Forms.ListBox();
            this.empRepTab = new System.Windows.Forms.TabPage();
            this.empRepList = new System.Windows.Forms.ListBox();
            this.emplerRepTab = new System.Windows.Forms.TabPage();
            this.emplerRepList = new System.Windows.Forms.ListBox();
            this.fieldPlacementRepTab = new System.Windows.Forms.TabPage();
            this.fieldPlacementRepList = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.importEmployeeCSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emplrPanel = new System.Windows.Forms.Panel();
            this.bizNameLabel = new System.Windows.Forms.Label();
            this.compNameBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.bizPhoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.bizRepLabel = new System.Windows.Forms.Label();
            this.compZipBox = new System.Windows.Forms.TextBox();
            this.compStateBox = new System.Windows.Forms.TextBox();
            this.compCityBox = new System.Windows.Forms.TextBox();
            this.compAddressBox = new System.Windows.Forms.TextBox();
            this.compAddress2Box = new System.Windows.Forms.TextBox();
            this.compPhoneBox = new System.Windows.Forms.TextBox();
            this.compEmailBox = new System.Windows.Forms.TextBox();
            this.compRepBox = new System.Windows.Forms.TextBox();
            this.identifierLabel = new System.Windows.Forms.Label();
            this.emplrIDBox = new System.Windows.Forms.TextBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.currentTab.SuspendLayout();
            this.fieldTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldTable)).BeginInit();
            this.employerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employersTable)).BeginInit();
            this.employeesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).BeginInit();
            this.evaluationTab.SuspendLayout();
            this.homeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evalTable)).BeginInit();
            this.mainTab.SuspendLayout();
            this.reportsTab.SuspendLayout();
            this.reportsPanel.SuspendLayout();
            this.empReportPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.evalRepTab.SuspendLayout();
            this.empRepTab.SuspendLayout();
            this.emplerRepTab.SuspendLayout();
            this.fieldPlacementRepTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importEmployeeCSVBindingSource)).BeginInit();
            this.emplrPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Gray;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.homeButton.Location = new System.Drawing.Point(1, 21);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(151, 36);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.printToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.viewReportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.employerToolStripMenuItem,
            this.evaluationToolStripMenuItem,
            this.fieldPlacementToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.employeeToolStripMenuItem.Text = "Employee (Ctrl+N)";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.newEmployeeToolStripMenuItem_Click);
            // 
            // employerToolStripMenuItem
            // 
            this.employerToolStripMenuItem.Name = "employerToolStripMenuItem";
            this.employerToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.employerToolStripMenuItem.Text = "Employer (Ctrl+Shift+N))";
            this.employerToolStripMenuItem.Click += new System.EventHandler(this.newEmployerToolStripMenuItem_Click);
            // 
            // evaluationToolStripMenuItem
            // 
            this.evaluationToolStripMenuItem.Name = "evaluationToolStripMenuItem";
            this.evaluationToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.evaluationToolStripMenuItem.Text = "Evaluation(Ctrl+E)";
            this.evaluationToolStripMenuItem.Click += new System.EventHandler(this.newEvaluationToolStripMenuItem_Click);
            // 
            // fieldPlacementToolStripMenuItem
            // 
            this.fieldPlacementToolStripMenuItem.Name = "fieldPlacementToolStripMenuItem";
            this.fieldPlacementToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.fieldPlacementToolStripMenuItem.Text = "Field Placement(Ctrl+L)";
            this.fieldPlacementToolStripMenuItem.Click += new System.EventHandler(this.newFieldPlacementToolStripMenuItem_Click);
            // 
            // viewReportToolStripMenuItem
            // 
            this.viewReportToolStripMenuItem.Name = "viewReportToolStripMenuItem";
            this.viewReportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.viewReportToolStripMenuItem.Text = "View Reports   (Ctrl+R)";
            this.viewReportToolStripMenuItem.Click += new System.EventHandler(this.viewReportToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allEmployeesToolStripMenuItem,
            this.individualReportsToolStripMenuItem});
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem1.Text = "Print";
            // 
            // allEmployeesToolStripMenuItem
            // 
            this.allEmployeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byEvaluationScoreToolStripMenuItem,
            this.byEmployerNameToolStripMenuItem,
            this.byEmployeeFirstNameToolStripMenuItem});
            this.allEmployeesToolStripMenuItem.Name = "allEmployeesToolStripMenuItem";
            this.allEmployeesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.allEmployeesToolStripMenuItem.Text = "All Employees";
            // 
            // byEvaluationScoreToolStripMenuItem
            // 
            this.byEvaluationScoreToolStripMenuItem.Name = "byEvaluationScoreToolStripMenuItem";
            this.byEvaluationScoreToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.byEvaluationScoreToolStripMenuItem.Text = "By Evaluation Score";
            this.byEvaluationScoreToolStripMenuItem.Click += new System.EventHandler(this.byEvaluationScoreToolStripMenuItem_Click);
            // 
            // byEmployerNameToolStripMenuItem
            // 
            this.byEmployerNameToolStripMenuItem.Name = "byEmployerNameToolStripMenuItem";
            this.byEmployerNameToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.byEmployerNameToolStripMenuItem.Text = "By Employer Name";
            this.byEmployerNameToolStripMenuItem.Click += new System.EventHandler(this.byEmployerNameToolStripMenuItem_Click);
            // 
            // byEmployeeFirstNameToolStripMenuItem
            // 
            this.byEmployeeFirstNameToolStripMenuItem.Name = "byEmployeeFirstNameToolStripMenuItem";
            this.byEmployeeFirstNameToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.byEmployeeFirstNameToolStripMenuItem.Text = "by Employee First Name";
            this.byEmployeeFirstNameToolStripMenuItem.Click += new System.EventHandler(this.byEmployeeFirstNameToolStripMenuItem_Click);
            // 
            // individualReportsToolStripMenuItem
            // 
            this.individualReportsToolStripMenuItem.Name = "individualReportsToolStripMenuItem";
            this.individualReportsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.individualReportsToolStripMenuItem.Text = "Individual Reports";
            this.individualReportsToolStripMenuItem.Click += new System.EventHandler(this.individualReportsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // recentsBar
            // 
            this.recentsBar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentsBar.Location = new System.Drawing.Point(0, 59);
            this.recentsBar.Name = "recentsBar";
            this.recentsBar.Size = new System.Drawing.Size(151, 572);
            this.recentsBar.TabIndex = 5;
            this.recentsBar.UseCompatibleStateImageBehavior = false;
            this.recentsBar.View = System.Windows.Forms.View.List;
            // 
            // currentTab
            // 
            this.currentTab.Controls.Add(this.primaryTab);
            this.currentTab.Location = new System.Drawing.Point(154, 44);
            this.currentTab.Name = "currentTab";
            this.currentTab.SelectedIndex = 0;
            this.currentTab.Size = new System.Drawing.Size(692, 584);
            this.currentTab.TabIndex = 5;
            this.currentTab.Click += new System.EventHandler(this.currentTab_Click);
            // 
            // primaryTab
            // 
            this.primaryTab.Location = new System.Drawing.Point(4, 22);
            this.primaryTab.Name = "primaryTab";
            this.primaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.primaryTab.Size = new System.Drawing.Size(684, 558);
            this.primaryTab.TabIndex = 1;
            this.primaryTab.Text = "tabPage6";
            this.primaryTab.UseVisualStyleBackColor = true;
            // 
            // fieldTab
            // 
            this.fieldTab.Controls.Add(this.fieldTable);
            this.fieldTab.Location = new System.Drawing.Point(4, 22);
            this.fieldTab.Name = "fieldTab";
            this.fieldTab.Padding = new System.Windows.Forms.Padding(3);
            this.fieldTab.Size = new System.Drawing.Size(688, 581);
            this.fieldTab.TabIndex = 3;
            this.fieldTab.Text = "Field Placements";
            this.fieldTab.UseVisualStyleBackColor = true;
            // 
            // fieldTable
            // 
            this.fieldTable.AllowUserToAddRows = false;
            this.fieldTable.AllowUserToDeleteRows = false;
            this.fieldTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fieldTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emplerIDColumn,
            this.EmployerColumn,
            this.empleeIDColumn,
            this.EmployeeColumn});
            this.fieldTable.Location = new System.Drawing.Point(-4, 20);
            this.fieldTable.Name = "fieldTable";
            this.fieldTable.Size = new System.Drawing.Size(692, 558);
            this.fieldTable.TabIndex = 0;
            // 
            // emplerIDColumn
            // 
            this.emplerIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emplerIDColumn.HeaderText = "ID";
            this.emplerIDColumn.Name = "emplerIDColumn";
            this.emplerIDColumn.ReadOnly = true;
            // 
            // EmployerColumn
            // 
            this.EmployerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployerColumn.HeaderText = "Employer";
            this.EmployerColumn.Name = "EmployerColumn";
            this.EmployerColumn.ReadOnly = true;
            // 
            // empleeIDColumn
            // 
            this.empleeIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empleeIDColumn.HeaderText = "ID";
            this.empleeIDColumn.Name = "empleeIDColumn";
            this.empleeIDColumn.ReadOnly = true;
            // 
            // EmployeeColumn
            // 
            this.EmployeeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeColumn.HeaderText = "Employee";
            this.EmployeeColumn.Name = "EmployeeColumn";
            this.EmployeeColumn.ReadOnly = true;
            // 
            // employerTab
            // 
            this.employerTab.Controls.Add(this.employersTable);
            this.employerTab.Location = new System.Drawing.Point(4, 22);
            this.employerTab.Name = "employerTab";
            this.employerTab.Padding = new System.Windows.Forms.Padding(3);
            this.employerTab.Size = new System.Drawing.Size(688, 581);
            this.employerTab.TabIndex = 2;
            this.employerTab.Text = "Employers";
            this.employerTab.UseVisualStyleBackColor = true;
            // 
            // employersTable
            // 
            this.employersTable.AllowUserToAddRows = false;
            this.employersTable.AllowUserToDeleteRows = false;
            this.employersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identColumn,
            this.bizColumn});
            this.employersTable.Location = new System.Drawing.Point(-4, 20);
            this.employersTable.Name = "employersTable";
            this.employersTable.Size = new System.Drawing.Size(692, 558);
            this.employersTable.TabIndex = 0;
            // 
            // identColumn
            // 
            this.identColumn.FillWeight = 76.14214F;
            this.identColumn.HeaderText = "ID";
            this.identColumn.Name = "identColumn";
            this.identColumn.ReadOnly = true;
            this.identColumn.Width = 163;
            // 
            // bizColumn
            // 
            this.bizColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bizColumn.FillWeight = 111.9289F;
            this.bizColumn.HeaderText = "Company Name";
            this.bizColumn.Name = "bizColumn";
            this.bizColumn.ReadOnly = true;
            // 
            // employeesTab
            // 
            this.employeesTab.Controls.Add(this.employeesTable);
            this.employeesTab.Location = new System.Drawing.Point(4, 22);
            this.employeesTab.Name = "employeesTab";
            this.employeesTab.Padding = new System.Windows.Forms.Padding(3);
            this.employeesTab.Size = new System.Drawing.Size(688, 581);
            this.employeesTab.TabIndex = 1;
            this.employeesTab.Text = "Employees";
            this.employeesTab.UseVisualStyleBackColor = true;
            // 
            // employeesTable
            // 
            this.employeesTable.AllowUserToAddRows = false;
            this.employeesTable.AllowUserToDeleteRows = false;
            this.employeesTable.AllowUserToResizeColumns = false;
            this.employeesTable.AllowUserToResizeRows = false;
            this.employeesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.lastNameColumn,
            this.firstNameColumn});
            this.employeesTable.Location = new System.Drawing.Point(-4, 20);
            this.employeesTable.Name = "employeesTable";
            this.employeesTable.Size = new System.Drawing.Size(692, 558);
            this.employeesTable.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idColumn.FillWeight = 76.14214F;
            this.idColumn.Frozen = true;
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 162;
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.FillWeight = 111.9289F;
            this.lastNameColumn.HeaderText = "Last";
            this.lastNameColumn.Name = "lastNameColumn";
            this.lastNameColumn.ReadOnly = true;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.FillWeight = 111.9289F;
            this.firstNameColumn.HeaderText = "First";
            this.firstNameColumn.Name = "firstNameColumn";
            this.firstNameColumn.ReadOnly = true;
            // 
            // evaluationTab
            // 
            this.evaluationTab.Controls.Add(this.homeView);
            this.evaluationTab.Controls.Add(this.evalTable);
            this.evaluationTab.Location = new System.Drawing.Point(4, 22);
            this.evaluationTab.Name = "evaluationTab";
            this.evaluationTab.Padding = new System.Windows.Forms.Padding(3);
            this.evaluationTab.Size = new System.Drawing.Size(688, 581);
            this.evaluationTab.TabIndex = 0;
            this.evaluationTab.Text = "Evaluations";
            this.evaluationTab.UseVisualStyleBackColor = true;
            // 
            // homeView
            // 
            this.homeView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeView.BackColor = System.Drawing.SystemColors.Control;
            this.homeView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.homeView.Controls.Add(this.homeViewHeader);
            this.homeView.Controls.Add(this.fieldButton);
            this.homeView.Controls.Add(this.employerButton);
            this.homeView.Controls.Add(this.evalButton);
            this.homeView.Controls.Add(this.employeeButton);
            this.homeView.ForeColor = System.Drawing.SystemColors.InfoText;
            this.homeView.Location = new System.Drawing.Point(0, 0);
            this.homeView.Name = "homeView";
            this.homeView.Size = new System.Drawing.Size(696, 584);
            this.homeView.TabIndex = 0;
            // 
            // homeViewHeader
            // 
            this.homeViewHeader.AutoSize = true;
            this.homeViewHeader.BackColor = System.Drawing.Color.Transparent;
            this.homeViewHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeViewHeader.ForeColor = System.Drawing.SystemColors.MenuText;
            this.homeViewHeader.Location = new System.Drawing.Point(116, 99);
            this.homeViewHeader.Name = "homeViewHeader";
            this.homeViewHeader.Size = new System.Drawing.Size(410, 45);
            this.homeViewHeader.TabIndex = 5;
            this.homeViewHeader.Text = "What would you like to do?";
            this.homeViewHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fieldButton
            // 
            this.fieldButton.BackColor = System.Drawing.Color.Gray;
            this.fieldButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fieldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fieldButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fieldButton.Location = new System.Drawing.Point(124, 355);
            this.fieldButton.Name = "fieldButton";
            this.fieldButton.Size = new System.Drawing.Size(120, 63);
            this.fieldButton.TabIndex = 3;
            this.fieldButton.Text = "New Field Placement";
            this.fieldButton.UseVisualStyleBackColor = false;
            this.fieldButton.Click += new System.EventHandler(this.fieldButton_Click);
            // 
            // employerButton
            // 
            this.employerButton.BackColor = System.Drawing.Color.Gray;
            this.employerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.employerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employerButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employerButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.employerButton.Location = new System.Drawing.Point(406, 217);
            this.employerButton.Name = "employerButton";
            this.employerButton.Size = new System.Drawing.Size(120, 63);
            this.employerButton.TabIndex = 2;
            this.employerButton.Text = "New Employer";
            this.employerButton.UseVisualStyleBackColor = false;
            this.employerButton.Click += new System.EventHandler(this.employerButton_Click);
            // 
            // evalButton
            // 
            this.evalButton.BackColor = System.Drawing.Color.Gray;
            this.evalButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.evalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evalButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evalButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.evalButton.Location = new System.Drawing.Point(406, 355);
            this.evalButton.Name = "evalButton";
            this.evalButton.Size = new System.Drawing.Size(120, 63);
            this.evalButton.TabIndex = 1;
            this.evalButton.Text = "New Evaluation";
            this.evalButton.UseVisualStyleBackColor = false;
            this.evalButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.BackColor = System.Drawing.Color.Gray;
            this.employeeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.employeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeButton.Location = new System.Drawing.Point(124, 217);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(120, 63);
            this.employeeButton.TabIndex = 0;
            this.employeeButton.Text = "New Employee";
            this.employeeButton.UseVisualStyleBackColor = false;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // evalTable
            // 
            this.evalTable.AllowUserToAddRows = false;
            this.evalTable.AllowUserToDeleteRows = false;
            this.evalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.evalTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.evalIDColumn,
            this.empLastNameColumn,
            this.empNameColumn});
            this.evalTable.Location = new System.Drawing.Point(-4, 20);
            this.evalTable.Name = "evalTable";
            this.evalTable.Size = new System.Drawing.Size(692, 558);
            this.evalTable.TabIndex = 0;
            // 
            // dateColumn
            // 
            this.dateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateColumn.HeaderText = "Date Evaluated";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // evalIDColumn
            // 
            this.evalIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.evalIDColumn.HeaderText = "ID";
            this.evalIDColumn.Name = "evalIDColumn";
            this.evalIDColumn.ReadOnly = true;
            this.evalIDColumn.Width = 43;
            // 
            // empLastNameColumn
            // 
            this.empLastNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empLastNameColumn.HeaderText = "Employee ID";
            this.empLastNameColumn.Name = "empLastNameColumn";
            this.empLastNameColumn.ReadOnly = true;
            // 
            // empNameColumn
            // 
            this.empNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empNameColumn.HeaderText = "Name";
            this.empNameColumn.Name = "empNameColumn";
            this.empNameColumn.ReadOnly = true;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.evaluationTab);
            this.mainTab.Controls.Add(this.employeesTab);
            this.mainTab.Controls.Add(this.employerTab);
            this.mainTab.Controls.Add(this.fieldTab);
            this.mainTab.Controls.Add(this.reportsTab);
            this.mainTab.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTab.Location = new System.Drawing.Point(153, 24);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(696, 607);
            this.mainTab.TabIndex = 2;
            this.mainTab.Click += new System.EventHandler(this.mainTab_Click);
            // 
            // reportsTab
            // 
            this.reportsTab.Controls.Add(this.reportsPanel);
            this.reportsTab.Location = new System.Drawing.Point(4, 22);
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Padding = new System.Windows.Forms.Padding(3);
            this.reportsTab.Size = new System.Drawing.Size(688, 581);
            this.reportsTab.TabIndex = 4;
            this.reportsTab.Text = "Reports";
            this.reportsTab.UseVisualStyleBackColor = true;
            // 
            // reportsPanel
            // 
            this.reportsPanel.Controls.Add(this.emplrPanel);
            this.reportsPanel.Controls.Add(this.empReportPanel);
            this.reportsPanel.Controls.Add(this.repPrintButton);
            this.reportsPanel.Controls.Add(this.repSaveButton);
            this.reportsPanel.Controls.Add(this.tabControl1);
            this.reportsPanel.Location = new System.Drawing.Point(-4, 20);
            this.reportsPanel.Name = "reportsPanel";
            this.reportsPanel.Size = new System.Drawing.Size(692, 558);
            this.reportsPanel.TabIndex = 0;
            // 
            // empReportPanel
            // 
            this.empReportPanel.Controls.Add(this.companyLabel);
            this.empReportPanel.Controls.Add(this.employerLabel);
            this.empReportPanel.Controls.Add(this.theZipLabel);
            this.empReportPanel.Controls.Add(this.theStateLabel);
            this.empReportPanel.Controls.Add(this.theCityLabel);
            this.empReportPanel.Controls.Add(this.sAddress2Label);
            this.empReportPanel.Controls.Add(this.address1Label);
            this.empReportPanel.Controls.Add(this.cPhoneLabel);
            this.empReportPanel.Controls.Add(this.hPhoneLabel);
            this.empReportPanel.Controls.Add(this.emailAddLabel);
            this.empReportPanel.Controls.Add(this.lNameLabel);
            this.empReportPanel.Controls.Add(this.fNameLabel);
            this.empReportPanel.Controls.Add(this.identLabel);
            this.empReportPanel.Controls.Add(this.empZipBox);
            this.empReportPanel.Controls.Add(this.empStateBox);
            this.empReportPanel.Controls.Add(this.empCityBox);
            this.empReportPanel.Controls.Add(this.empAddressBox);
            this.empReportPanel.Controls.Add(this.empAddressbox2);
            this.empReportPanel.Controls.Add(this.empHPhoneBox);
            this.empReportPanel.Controls.Add(this.empCPhoneBox);
            this.empReportPanel.Controls.Add(this.empEmailBox);
            this.empReportPanel.Controls.Add(this.empFNameBox);
            this.empReportPanel.Controls.Add(this.empLNameBox);
            this.empReportPanel.Controls.Add(this.empIDBox);
            this.empReportPanel.Location = new System.Drawing.Point(264, 24);
            this.empReportPanel.Name = "empReportPanel";
            this.empReportPanel.Size = new System.Drawing.Size(422, 483);
            this.empReportPanel.TabIndex = 4;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(11, 432);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(26, 13);
            this.companyLabel.TabIndex = 45;
            this.companyLabel.Text = "N/A";
            // 
            // employerLabel
            // 
            this.employerLabel.AutoSize = true;
            this.employerLabel.Location = new System.Drawing.Point(11, 413);
            this.employerLabel.Name = "employerLabel";
            this.employerLabel.Size = new System.Drawing.Size(57, 13);
            this.employerLabel.TabIndex = 44;
            this.employerLabel.Text = "Employer:";
            // 
            // theZipLabel
            // 
            this.theZipLabel.AutoSize = true;
            this.theZipLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theZipLabel.Location = new System.Drawing.Point(10, 357);
            this.theZipLabel.Name = "theZipLabel";
            this.theZipLabel.Size = new System.Drawing.Size(53, 13);
            this.theZipLabel.TabIndex = 43;
            this.theZipLabel.Text = "Zip Code";
            // 
            // theStateLabel
            // 
            this.theStateLabel.AutoSize = true;
            this.theStateLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theStateLabel.Location = new System.Drawing.Point(223, 312);
            this.theStateLabel.Name = "theStateLabel";
            this.theStateLabel.Size = new System.Drawing.Size(33, 13);
            this.theStateLabel.TabIndex = 42;
            this.theStateLabel.Text = "State";
            // 
            // theCityLabel
            // 
            this.theCityLabel.AutoSize = true;
            this.theCityLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theCityLabel.Location = new System.Drawing.Point(10, 312);
            this.theCityLabel.Name = "theCityLabel";
            this.theCityLabel.Size = new System.Drawing.Size(26, 13);
            this.theCityLabel.TabIndex = 41;
            this.theCityLabel.Text = "City";
            // 
            // sAddress2Label
            // 
            this.sAddress2Label.AutoSize = true;
            this.sAddress2Label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAddress2Label.Location = new System.Drawing.Point(220, 265);
            this.sAddress2Label.Name = "sAddress2Label";
            this.sAddress2Label.Size = new System.Drawing.Size(90, 13);
            this.sAddress2Label.TabIndex = 40;
            this.sAddress2Label.Text = "Street Address 2";
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1Label.Location = new System.Drawing.Point(10, 265);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(81, 13);
            this.address1Label.TabIndex = 39;
            this.address1Label.Text = "Street Address";
            // 
            // cPhoneLabel
            // 
            this.cPhoneLabel.AutoSize = true;
            this.cPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPhoneLabel.Location = new System.Drawing.Point(220, 210);
            this.cPhoneLabel.Name = "cPhoneLabel";
            this.cPhoneLabel.Size = new System.Drawing.Size(62, 13);
            this.cPhoneLabel.TabIndex = 38;
            this.cPhoneLabel.Text = "Cell Phone";
            // 
            // hPhoneLabel
            // 
            this.hPhoneLabel.AutoSize = true;
            this.hPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hPhoneLabel.Location = new System.Drawing.Point(10, 210);
            this.hPhoneLabel.Name = "hPhoneLabel";
            this.hPhoneLabel.Size = new System.Drawing.Size(73, 13);
            this.hPhoneLabel.TabIndex = 37;
            this.hPhoneLabel.Text = "Home Phone";
            // 
            // emailAddLabel
            // 
            this.emailAddLabel.AutoSize = true;
            this.emailAddLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddLabel.Location = new System.Drawing.Point(10, 154);
            this.emailAddLabel.Name = "emailAddLabel";
            this.emailAddLabel.Size = new System.Drawing.Size(83, 13);
            this.emailAddLabel.TabIndex = 36;
            this.emailAddLabel.Text = "E-Mail Address";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLabel.Location = new System.Drawing.Point(220, 91);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lNameLabel.TabIndex = 35;
            this.lNameLabel.Text = "Last Name";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.Location = new System.Drawing.Point(7, 91);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(61, 13);
            this.fNameLabel.TabIndex = 34;
            this.fNameLabel.Text = "First Name";
            // 
            // identLabel
            // 
            this.identLabel.AutoSize = true;
            this.identLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identLabel.Location = new System.Drawing.Point(153, 13);
            this.identLabel.Name = "identLabel";
            this.identLabel.Size = new System.Drawing.Size(106, 13);
            this.identLabel.TabIndex = 33;
            this.identLabel.Text = "Employee Identifier";
            // 
            // empZipBox
            // 
            this.empZipBox.Location = new System.Drawing.Point(10, 373);
            this.empZipBox.Name = "empZipBox";
            this.empZipBox.Size = new System.Drawing.Size(176, 22);
            this.empZipBox.TabIndex = 32;
            // 
            // empStateBox
            // 
            this.empStateBox.Location = new System.Drawing.Point(223, 328);
            this.empStateBox.Name = "empStateBox";
            this.empStateBox.Size = new System.Drawing.Size(161, 22);
            this.empStateBox.TabIndex = 31;
            // 
            // empCityBox
            // 
            this.empCityBox.Location = new System.Drawing.Point(10, 328);
            this.empCityBox.Name = "empCityBox";
            this.empCityBox.Size = new System.Drawing.Size(176, 22);
            this.empCityBox.TabIndex = 30;
            // 
            // empAddressBox
            // 
            this.empAddressBox.Location = new System.Drawing.Point(10, 281);
            this.empAddressBox.Name = "empAddressBox";
            this.empAddressBox.Size = new System.Drawing.Size(176, 22);
            this.empAddressBox.TabIndex = 28;
            // 
            // empAddressbox2
            // 
            this.empAddressbox2.Location = new System.Drawing.Point(223, 281);
            this.empAddressbox2.Name = "empAddressbox2";
            this.empAddressbox2.Size = new System.Drawing.Size(161, 22);
            this.empAddressbox2.TabIndex = 29;
            // 
            // empHPhoneBox
            // 
            this.empHPhoneBox.Location = new System.Drawing.Point(10, 226);
            this.empHPhoneBox.Name = "empHPhoneBox";
            this.empHPhoneBox.Size = new System.Drawing.Size(176, 22);
            this.empHPhoneBox.TabIndex = 26;
            // 
            // empCPhoneBox
            // 
            this.empCPhoneBox.Location = new System.Drawing.Point(223, 226);
            this.empCPhoneBox.Name = "empCPhoneBox";
            this.empCPhoneBox.Size = new System.Drawing.Size(161, 22);
            this.empCPhoneBox.TabIndex = 27;
            // 
            // empEmailBox
            // 
            this.empEmailBox.Location = new System.Drawing.Point(10, 170);
            this.empEmailBox.Name = "empEmailBox";
            this.empEmailBox.Size = new System.Drawing.Size(176, 22);
            this.empEmailBox.TabIndex = 25;
            // 
            // empFNameBox
            // 
            this.empFNameBox.Location = new System.Drawing.Point(10, 107);
            this.empFNameBox.Name = "empFNameBox";
            this.empFNameBox.Size = new System.Drawing.Size(176, 22);
            this.empFNameBox.TabIndex = 23;
            // 
            // empLNameBox
            // 
            this.empLNameBox.Location = new System.Drawing.Point(223, 107);
            this.empLNameBox.Name = "empLNameBox";
            this.empLNameBox.Size = new System.Drawing.Size(161, 22);
            this.empLNameBox.TabIndex = 24;
            // 
            // empIDBox
            // 
            this.empIDBox.Location = new System.Drawing.Point(119, 29);
            this.empIDBox.Name = "empIDBox";
            this.empIDBox.Size = new System.Drawing.Size(181, 22);
            this.empIDBox.TabIndex = 22;
            // 
            // repPrintButton
            // 
            this.repPrintButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.repPrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repPrintButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.repPrintButton.Location = new System.Drawing.Point(526, 513);
            this.repPrintButton.Name = "repPrintButton";
            this.repPrintButton.Size = new System.Drawing.Size(75, 23);
            this.repPrintButton.TabIndex = 3;
            this.repPrintButton.Text = "Print";
            this.repPrintButton.UseVisualStyleBackColor = false;
            this.repPrintButton.Click += new System.EventHandler(this.repPrintButton_Click);
            // 
            // repSaveButton
            // 
            this.repSaveButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.repSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repSaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.repSaveButton.Location = new System.Drawing.Point(365, 513);
            this.repSaveButton.Name = "repSaveButton";
            this.repSaveButton.Size = new System.Drawing.Size(75, 23);
            this.repSaveButton.TabIndex = 2;
            this.repSaveButton.Text = "Save";
            this.repSaveButton.UseVisualStyleBackColor = false;
            this.repSaveButton.Click += new System.EventHandler(this.repSaveButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.evalRepTab);
            this.tabControl1.Controls.Add(this.empRepTab);
            this.tabControl1.Controls.Add(this.emplerRepTab);
            this.tabControl1.Controls.Add(this.fieldPlacementRepTab);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(253, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // evalRepTab
            // 
            this.evalRepTab.Controls.Add(this.evalRepList);
            this.evalRepTab.Location = new System.Drawing.Point(4, 22);
            this.evalRepTab.Name = "evalRepTab";
            this.evalRepTab.Size = new System.Drawing.Size(245, 530);
            this.evalRepTab.TabIndex = 2;
            this.evalRepTab.Text = "Evaluations";
            this.evalRepTab.UseVisualStyleBackColor = true;
            // 
            // evalRepList
            // 
            this.evalRepList.FormattingEnabled = true;
            this.evalRepList.Location = new System.Drawing.Point(0, 0);
            this.evalRepList.Name = "evalRepList";
            this.evalRepList.Size = new System.Drawing.Size(245, 537);
            this.evalRepList.TabIndex = 0;
            this.evalRepList.SelectedIndexChanged += new System.EventHandler(this.evalRepList_SelectedIndexChanged);
            // 
            // empRepTab
            // 
            this.empRepTab.Controls.Add(this.empRepList);
            this.empRepTab.Location = new System.Drawing.Point(4, 22);
            this.empRepTab.Name = "empRepTab";
            this.empRepTab.Padding = new System.Windows.Forms.Padding(3);
            this.empRepTab.Size = new System.Drawing.Size(245, 530);
            this.empRepTab.TabIndex = 0;
            this.empRepTab.Text = "Employees";
            this.empRepTab.UseVisualStyleBackColor = true;
            // 
            // empRepList
            // 
            this.empRepList.FormattingEnabled = true;
            this.empRepList.Location = new System.Drawing.Point(0, 0);
            this.empRepList.Name = "empRepList";
            this.empRepList.Size = new System.Drawing.Size(245, 537);
            this.empRepList.TabIndex = 1;
            this.empRepList.SelectedIndexChanged += new System.EventHandler(this.empRepList_SelectedIndexChanged);
            // 
            // emplerRepTab
            // 
            this.emplerRepTab.Controls.Add(this.emplerRepList);
            this.emplerRepTab.Location = new System.Drawing.Point(4, 22);
            this.emplerRepTab.Name = "emplerRepTab";
            this.emplerRepTab.Padding = new System.Windows.Forms.Padding(3);
            this.emplerRepTab.Size = new System.Drawing.Size(245, 530);
            this.emplerRepTab.TabIndex = 1;
            this.emplerRepTab.Text = "Employers";
            this.emplerRepTab.UseVisualStyleBackColor = true;
            // 
            // emplerRepList
            // 
            this.emplerRepList.FormattingEnabled = true;
            this.emplerRepList.Location = new System.Drawing.Point(0, 0);
            this.emplerRepList.Name = "emplerRepList";
            this.emplerRepList.Size = new System.Drawing.Size(245, 537);
            this.emplerRepList.TabIndex = 1;
            this.emplerRepList.SelectedIndexChanged += new System.EventHandler(this.emplerRepList_SelectedIndexChanged);
            // 
            // fieldPlacementRepTab
            // 
            this.fieldPlacementRepTab.Controls.Add(this.fieldPlacementRepList);
            this.fieldPlacementRepTab.Location = new System.Drawing.Point(4, 22);
            this.fieldPlacementRepTab.Name = "fieldPlacementRepTab";
            this.fieldPlacementRepTab.Size = new System.Drawing.Size(245, 530);
            this.fieldPlacementRepTab.TabIndex = 3;
            this.fieldPlacementRepTab.Text = "F.P.";
            this.fieldPlacementRepTab.UseVisualStyleBackColor = true;
            // 
            // fieldPlacementRepList
            // 
            this.fieldPlacementRepList.FormattingEnabled = true;
            this.fieldPlacementRepList.Location = new System.Drawing.Point(0, 0);
            this.fieldPlacementRepList.Name = "fieldPlacementRepList";
            this.fieldPlacementRepList.Size = new System.Drawing.Size(245, 537);
            this.fieldPlacementRepList.TabIndex = 1;
            this.fieldPlacementRepList.SelectedIndexChanged += new System.EventHandler(this.fieldPlacementRepList_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPage);
            // 
            // emplrPanel
            // 
            this.emplrPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emplrPanel.Controls.Add(this.bizNameLabel);
            this.emplrPanel.Controls.Add(this.compNameBox);
            this.emplrPanel.Controls.Add(this.zipLabel);
            this.emplrPanel.Controls.Add(this.stateLabel);
            this.emplrPanel.Controls.Add(this.cityLabel);
            this.emplrPanel.Controls.Add(this.address2Label);
            this.emplrPanel.Controls.Add(this.addressLabel);
            this.emplrPanel.Controls.Add(this.bizPhoneLabel);
            this.emplrPanel.Controls.Add(this.emailLabel);
            this.emplrPanel.Controls.Add(this.bizRepLabel);
            this.emplrPanel.Controls.Add(this.compZipBox);
            this.emplrPanel.Controls.Add(this.compStateBox);
            this.emplrPanel.Controls.Add(this.compCityBox);
            this.emplrPanel.Controls.Add(this.compAddressBox);
            this.emplrPanel.Controls.Add(this.compAddress2Box);
            this.emplrPanel.Controls.Add(this.compPhoneBox);
            this.emplrPanel.Controls.Add(this.compEmailBox);
            this.emplrPanel.Controls.Add(this.compRepBox);
            this.emplrPanel.Controls.Add(this.identifierLabel);
            this.emplrPanel.Controls.Add(this.emplrIDBox);
            this.emplrPanel.Location = new System.Drawing.Point(264, 24);
            this.emplrPanel.Name = "emplrPanel";
            this.emplrPanel.Size = new System.Drawing.Size(422, 483);
            this.emplrPanel.TabIndex = 6;
            // 
            // bizNameLabel
            // 
            this.bizNameLabel.AutoSize = true;
            this.bizNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bizNameLabel.Location = new System.Drawing.Point(164, 80);
            this.bizNameLabel.Name = "bizNameLabel";
            this.bizNameLabel.Size = new System.Drawing.Size(87, 13);
            this.bizNameLabel.TabIndex = 67;
            this.bizNameLabel.Text = "Company Name";
            // 
            // compNameBox
            // 
            this.compNameBox.Location = new System.Drawing.Point(119, 96);
            this.compNameBox.Name = "compNameBox";
            this.compNameBox.Size = new System.Drawing.Size(181, 22);
            this.compNameBox.TabIndex = 49;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.Location = new System.Drawing.Point(10, 290);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(53, 13);
            this.zipLabel.TabIndex = 66;
            this.zipLabel.Text = "Zip Code";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(226, 241);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(33, 13);
            this.stateLabel.TabIndex = 65;
            this.stateLabel.Text = "State";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(10, 241);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(26, 13);
            this.cityLabel.TabIndex = 64;
            this.cityLabel.Text = "City";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Label.Location = new System.Drawing.Point(223, 194);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(90, 13);
            this.address2Label.TabIndex = 63;
            this.address2Label.Text = "Street Address 2";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(10, 194);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(81, 13);
            this.addressLabel.TabIndex = 62;
            this.addressLabel.Text = "Street Address";
            // 
            // bizPhoneLabel
            // 
            this.bizPhoneLabel.AutoSize = true;
            this.bizPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bizPhoneLabel.Location = new System.Drawing.Point(223, 146);
            this.bizPhoneLabel.Name = "bizPhoneLabel";
            this.bizPhoneLabel.Size = new System.Drawing.Size(91, 13);
            this.bizPhoneLabel.TabIndex = 61;
            this.bizPhoneLabel.Text = "Company Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(10, 146);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(134, 13);
            this.emailLabel.TabIndex = 60;
            this.emailLabel.Text = "Company E-Mail Address";
            // 
            // bizRepLabel
            // 
            this.bizRepLabel.AutoSize = true;
            this.bizRepLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bizRepLabel.Location = new System.Drawing.Point(140, 372);
            this.bizRepLabel.Name = "bizRepLabel";
            this.bizRepLabel.Size = new System.Drawing.Size(134, 13);
            this.bizRepLabel.TabIndex = 59;
            this.bizRepLabel.Text = "Company Representative";
            // 
            // compZipBox
            // 
            this.compZipBox.Location = new System.Drawing.Point(10, 306);
            this.compZipBox.Name = "compZipBox";
            this.compZipBox.Size = new System.Drawing.Size(181, 22);
            this.compZipBox.TabIndex = 56;
            // 
            // compStateBox
            // 
            this.compStateBox.Location = new System.Drawing.Point(226, 257);
            this.compStateBox.Name = "compStateBox";
            this.compStateBox.Size = new System.Drawing.Size(181, 22);
            this.compStateBox.TabIndex = 55;
            // 
            // compCityBox
            // 
            this.compCityBox.Location = new System.Drawing.Point(10, 257);
            this.compCityBox.Name = "compCityBox";
            this.compCityBox.Size = new System.Drawing.Size(181, 22);
            this.compCityBox.TabIndex = 54;
            // 
            // compAddressBox
            // 
            this.compAddressBox.Location = new System.Drawing.Point(10, 210);
            this.compAddressBox.Name = "compAddressBox";
            this.compAddressBox.Size = new System.Drawing.Size(181, 22);
            this.compAddressBox.TabIndex = 52;
            // 
            // compAddress2Box
            // 
            this.compAddress2Box.Location = new System.Drawing.Point(226, 210);
            this.compAddress2Box.Name = "compAddress2Box";
            this.compAddress2Box.Size = new System.Drawing.Size(181, 22);
            this.compAddress2Box.TabIndex = 53;
            // 
            // compPhoneBox
            // 
            this.compPhoneBox.Location = new System.Drawing.Point(223, 162);
            this.compPhoneBox.Name = "compPhoneBox";
            this.compPhoneBox.Size = new System.Drawing.Size(181, 22);
            this.compPhoneBox.TabIndex = 51;
            // 
            // compEmailBox
            // 
            this.compEmailBox.Location = new System.Drawing.Point(10, 162);
            this.compEmailBox.Name = "compEmailBox";
            this.compEmailBox.Size = new System.Drawing.Size(181, 22);
            this.compEmailBox.TabIndex = 50;
            // 
            // compRepBox
            // 
            this.compRepBox.Location = new System.Drawing.Point(119, 388);
            this.compRepBox.Name = "compRepBox";
            this.compRepBox.Size = new System.Drawing.Size(181, 22);
            this.compRepBox.TabIndex = 57;
            // 
            // identifierLabel
            // 
            this.identifierLabel.AutoSize = true;
            this.identifierLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifierLabel.Location = new System.Drawing.Point(149, 13);
            this.identifierLabel.Name = "identifierLabel";
            this.identifierLabel.Size = new System.Drawing.Size(104, 13);
            this.identifierLabel.TabIndex = 58;
            this.identifierLabel.Text = "Employer Identifier";
            // 
            // emplrIDBox
            // 
            this.emplrIDBox.Location = new System.Drawing.Point(119, 29);
            this.emplrIDBox.Name = "emplrIDBox";
            this.emplrIDBox.Size = new System.Drawing.Size(181, 22);
            this.emplrIDBox.TabIndex = 48;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(CortezFBLA.Program);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(847, 630);
            this.Controls.Add(this.recentsBar);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.currentTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MMT Temp Services";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.currentTab.ResumeLayout(false);
            this.fieldTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fieldTable)).EndInit();
            this.employerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employersTable)).EndInit();
            this.employeesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).EndInit();
            this.evaluationTab.ResumeLayout(false);
            this.homeView.ResumeLayout(false);
            this.homeView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evalTable)).EndInit();
            this.mainTab.ResumeLayout(false);
            this.reportsTab.ResumeLayout(false);
            this.reportsPanel.ResumeLayout(false);
            this.empReportPanel.ResumeLayout(false);
            this.empReportPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.evalRepTab.ResumeLayout(false);
            this.empRepTab.ResumeLayout(false);
            this.emplerRepTab.ResumeLayout(false);
            this.fieldPlacementRepTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importEmployeeCSVBindingSource)).EndInit();
            this.emplrPanel.ResumeLayout(false);
            this.emplrPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListView recentsBar;
        private System.Windows.Forms.ToolStripMenuItem viewReportToolStripMenuItem;
        private System.Windows.Forms.TabControl currentTab;
        private System.Windows.Forms.TabPage fieldTab;
        private System.Windows.Forms.TabPage employerTab;
        private System.Windows.Forms.TabPage employeesTab;
        private System.Windows.Forms.TabPage evaluationTab;
        private System.Windows.Forms.Panel homeView;
        private System.Windows.Forms.Button fieldButton;
        private System.Windows.Forms.Button employerButton;
        private System.Windows.Forms.Button evalButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage primaryTab;
        private System.Windows.Forms.Label homeViewHeader;
        private System.Windows.Forms.DataGridView employeesTable;
        private System.Windows.Forms.DataGridView employersTable;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldPlacementToolStripMenuItem;
        private System.Windows.Forms.DataGridView fieldTable;
        private System.Windows.Forms.BindingSource importEmployeeCSVBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplerIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleeIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bizColumn;
        private System.Windows.Forms.TabPage reportsTab;
        private System.Windows.Forms.DataGridView evalTable;
        private System.Windows.Forms.Panel reportsPanel;
        private System.Windows.Forms.Button repPrintButton;
        private System.Windows.Forms.Button repSaveButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage evalRepTab;
        private System.Windows.Forms.ListBox evalRepList;
        private System.Windows.Forms.TabPage empRepTab;
        private System.Windows.Forms.ListBox empRepList;
        private System.Windows.Forms.TabPage emplerRepTab;
        private System.Windows.Forms.ListBox emplerRepList;
        private System.Windows.Forms.TabPage fieldPlacementRepTab;
        private System.Windows.Forms.ListBox fieldPlacementRepList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byEvaluationScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byEmployerNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byEmployeeFirstNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualReportsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empLastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameColumn;
        private System.Windows.Forms.Panel empReportPanel;
        private System.Windows.Forms.Label theZipLabel;
        private System.Windows.Forms.Label theStateLabel;
        private System.Windows.Forms.Label theCityLabel;
        private System.Windows.Forms.Label sAddress2Label;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label cPhoneLabel;
        private System.Windows.Forms.Label hPhoneLabel;
        private System.Windows.Forms.Label emailAddLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label identLabel;
        private System.Windows.Forms.TextBox empZipBox;
        private System.Windows.Forms.TextBox empStateBox;
        private System.Windows.Forms.TextBox empCityBox;
        private System.Windows.Forms.TextBox empAddressBox;
        private System.Windows.Forms.TextBox empAddressbox2;
        private System.Windows.Forms.TextBox empHPhoneBox;
        private System.Windows.Forms.TextBox empCPhoneBox;
        private System.Windows.Forms.TextBox empEmailBox;
        private System.Windows.Forms.TextBox empFNameBox;
        private System.Windows.Forms.TextBox empLNameBox;
        private System.Windows.Forms.TextBox empIDBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label employerLabel;
        private System.Windows.Forms.Panel emplrPanel;
        private System.Windows.Forms.Label bizNameLabel;
        private System.Windows.Forms.TextBox compNameBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label bizPhoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label bizRepLabel;
        private System.Windows.Forms.TextBox compZipBox;
        private System.Windows.Forms.TextBox compStateBox;
        private System.Windows.Forms.TextBox compCityBox;
        private System.Windows.Forms.TextBox compAddressBox;
        private System.Windows.Forms.TextBox compAddress2Box;
        private System.Windows.Forms.TextBox compPhoneBox;
        private System.Windows.Forms.TextBox compEmailBox;
        private System.Windows.Forms.TextBox compRepBox;
        private System.Windows.Forms.Label identifierLabel;
        private System.Windows.Forms.TextBox emplrIDBox;

    }
}

