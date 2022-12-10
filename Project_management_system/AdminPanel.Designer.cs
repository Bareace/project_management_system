
namespace Project_management_system
{
    partial class AdminPanel
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Projects");
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeManagerBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveManager = new System.Windows.Forms.Button();
            this.changeManager = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.createProjectButton = new System.Windows.Forms.Button();
            this.projectButton = new System.Windows.Forms.Button();
            this.AdminPanelControl = new System.Windows.Forms.TabControl();
            this.EmployeeTab = new System.Windows.Forms.TabPage();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseEmployee = new System.Windows.Forms.Button();
            this.empSaveButton = new System.Windows.Forms.Button();
            this.empPassword = new System.Windows.Forms.TextBox();
            this.empUsername = new System.Windows.Forms.TextBox();
            this.empLastname = new System.Windows.Forms.TextBox();
            this.empName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProjectsTab = new System.Windows.Forms.TabPage();
            this.adminPanelTree = new System.Windows.Forms.TreeView();
            this.CloseProjects = new System.Windows.Forms.Button();
            this.CreateProjectTab = new System.Windows.Forms.TabPage();
            this.projectTypeBox = new System.Windows.Forms.ComboBox();
            this.managerBox1 = new System.Windows.Forms.ComboBox();
            this.estFinishDate = new System.Windows.Forms.DateTimePicker();
            this.estStartDate = new System.Windows.Forms.DateTimePicker();
            this.registerDate = new System.Windows.Forms.DateTimePicker();
            this.saveProject = new System.Windows.Forms.Button();
            this.projectNo = new System.Windows.Forms.NumericUpDown();
            this.description = new System.Windows.Forms.TextBox();
            this.projectName = new System.Windows.Forms.TextBox();
            this.CloseCreateProject = new System.Windows.Forms.Button();
            this.pDescription = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminPanelToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.AdminPanelControl.SuspendLayout();
            this.EmployeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ProjectsTab.SuspendLayout();
            this.CreateProjectTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectNo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 110);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Current User: Admin\r\n";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(1119, 15);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(91, 73);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.changeManagerBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.saveManager);
            this.panel2.Controls.Add(this.changeManager);
            this.panel2.Controls.Add(this.employeeButton);
            this.panel2.Controls.Add(this.createProjectButton);
            this.panel2.Controls.Add(this.projectButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 569);
            this.panel2.TabIndex = 0;
            // 
            // changeManagerBox
            // 
            this.changeManagerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeManagerBox.FormattingEnabled = true;
            this.changeManagerBox.Location = new System.Drawing.Point(16, 449);
            this.changeManagerBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeManagerBox.Name = "changeManagerBox";
            this.changeManagerBox.Size = new System.Drawing.Size(160, 24);
            this.changeManagerBox.TabIndex = 28;
            this.changeManagerBox.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Planning";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // saveManager
            // 
            this.saveManager.Location = new System.Drawing.Point(55, 482);
            this.saveManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveManager.Name = "saveManager";
            this.saveManager.Size = new System.Drawing.Size(81, 73);
            this.saveManager.TabIndex = 27;
            this.saveManager.Text = "Save Changes";
            this.saveManager.UseVisualStyleBackColor = true;
            this.saveManager.Visible = false;
            this.saveManager.Click += new System.EventHandler(this.saveManager_Click);
            // 
            // changeManager
            // 
            this.changeManager.Location = new System.Drawing.Point(55, 369);
            this.changeManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeManager.Name = "changeManager";
            this.changeManager.Size = new System.Drawing.Size(81, 73);
            this.changeManager.TabIndex = 27;
            this.changeManager.Text = "Change Manager";
            this.changeManager.UseVisualStyleBackColor = true;
            this.changeManager.Click += new System.EventHandler(this.changeManager_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.employeeButton.Font = new System.Drawing.Font("Lucida Bright", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeButton.Image = global::Project_management_system.Properties.Resources._7664employee;
            this.employeeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.employeeButton.Location = new System.Drawing.Point(0, 258);
            this.employeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(200, 105);
            this.employeeButton.TabIndex = 2;
            this.employeeButton.Text = "Add Employee";
            this.employeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.employeeButton.UseVisualStyleBackColor = false;
            this.employeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // createProjectButton
            // 
            this.createProjectButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.createProjectButton.Font = new System.Drawing.Font("Lucida Bright", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProjectButton.Image = global::Project_management_system.Properties.Resources._1task7664;
            this.createProjectButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createProjectButton.Location = new System.Drawing.Point(0, 146);
            this.createProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(200, 105);
            this.createProjectButton.TabIndex = 3;
            this.createProjectButton.Text = "Create Project";
            this.createProjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.createProjectButton.UseVisualStyleBackColor = false;
            this.createProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
            // 
            // projectButton
            // 
            this.projectButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.projectButton.Font = new System.Drawing.Font("Lucida Bright", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectButton.Image = global::Project_management_system.Properties.Resources._7664;
            this.projectButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.projectButton.Location = new System.Drawing.Point(0, 36);
            this.projectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectButton.Name = "projectButton";
            this.projectButton.Size = new System.Drawing.Size(200, 105);
            this.projectButton.TabIndex = 4;
            this.projectButton.Text = "Projects";
            this.projectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.projectButton.UseVisualStyleBackColor = false;
            this.projectButton.Click += new System.EventHandler(this.ProjectButton_Click);
            // 
            // AdminPanelControl
            // 
            this.AdminPanelControl.Controls.Add(this.EmployeeTab);
            this.AdminPanelControl.Controls.Add(this.ProjectsTab);
            this.AdminPanelControl.Controls.Add(this.CreateProjectTab);
            this.AdminPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPanelControl.Location = new System.Drawing.Point(200, 110);
            this.AdminPanelControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminPanelControl.Name = "AdminPanelControl";
            this.AdminPanelControl.SelectedIndex = 0;
            this.AdminPanelControl.Size = new System.Drawing.Size(1052, 569);
            this.AdminPanelControl.TabIndex = 1;
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.Controls.Add(this.deleteEmployee);
            this.EmployeeTab.Controls.Add(this.dataGridView1);
            this.EmployeeTab.Controls.Add(this.CloseEmployee);
            this.EmployeeTab.Controls.Add(this.empSaveButton);
            this.EmployeeTab.Controls.Add(this.empPassword);
            this.EmployeeTab.Controls.Add(this.empUsername);
            this.EmployeeTab.Controls.Add(this.empLastname);
            this.EmployeeTab.Controls.Add(this.empName);
            this.EmployeeTab.Controls.Add(this.label4);
            this.EmployeeTab.Controls.Add(this.label3);
            this.EmployeeTab.Controls.Add(this.label5);
            this.EmployeeTab.Controls.Add(this.label6);
            this.EmployeeTab.Location = new System.Drawing.Point(4, 25);
            this.EmployeeTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeTab.Size = new System.Drawing.Size(1044, 540);
            this.EmployeeTab.TabIndex = 0;
            this.EmployeeTab.Text = "Employee";
            this.EmployeeTab.UseVisualStyleBackColor = true;
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Location = new System.Drawing.Point(743, 364);
            this.deleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(100, 78);
            this.deleteEmployee.TabIndex = 28;
            this.deleteEmployee.Text = "Delete";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.LastNameColumn,
            this.UsernameColumn,
            this.PasswordColumn});
            this.dataGridView1.Location = new System.Drawing.Point(293, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 293);
            this.dataGridView1.TabIndex = 27;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 125;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.HeaderText = "Last Name";
            this.LastNameColumn.MinimumWidth = 6;
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.ReadOnly = true;
            this.LastNameColumn.Width = 125;
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.HeaderText = "Username";
            this.UsernameColumn.MinimumWidth = 6;
            this.UsernameColumn.Name = "UsernameColumn";
            this.UsernameColumn.ReadOnly = true;
            this.UsernameColumn.Width = 125;
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.HeaderText = "Password";
            this.PasswordColumn.MinimumWidth = 6;
            this.PasswordColumn.Name = "PasswordColumn";
            this.PasswordColumn.ReadOnly = true;
            this.PasswordColumn.Width = 125;
            // 
            // CloseEmployee
            // 
            this.CloseEmployee.Location = new System.Drawing.Point(995, 5);
            this.CloseEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseEmployee.Name = "CloseEmployee";
            this.CloseEmployee.Size = new System.Drawing.Size(41, 39);
            this.CloseEmployee.TabIndex = 24;
            this.CloseEmployee.Text = "X";
            this.CloseEmployee.UseVisualStyleBackColor = true;
            this.CloseEmployee.Click += new System.EventHandler(this.CloseTab);
            // 
            // empSaveButton
            // 
            this.empSaveButton.Location = new System.Drawing.Point(153, 311);
            this.empSaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empSaveButton.Name = "empSaveButton";
            this.empSaveButton.Size = new System.Drawing.Size(100, 86);
            this.empSaveButton.TabIndex = 2;
            this.empSaveButton.Text = "Save";
            this.empSaveButton.UseVisualStyleBackColor = true;
            this.empSaveButton.Click += new System.EventHandler(this.EmpSaveButton_Click);
            // 
            // empPassword
            // 
            this.empPassword.Location = new System.Drawing.Point(153, 260);
            this.empPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empPassword.Name = "empPassword";
            this.empPassword.ReadOnly = true;
            this.empPassword.Size = new System.Drawing.Size(100, 22);
            this.empPassword.TabIndex = 19;
            // 
            // empUsername
            // 
            this.empUsername.Location = new System.Drawing.Point(153, 206);
            this.empUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empUsername.Name = "empUsername";
            this.empUsername.ReadOnly = true;
            this.empUsername.Size = new System.Drawing.Size(100, 22);
            this.empUsername.TabIndex = 20;
            // 
            // empLastname
            // 
            this.empLastname.Location = new System.Drawing.Point(153, 156);
            this.empLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empLastname.Name = "empLastname";
            this.empLastname.Size = new System.Drawing.Size(100, 22);
            this.empLastname.TabIndex = 1;
            this.empLastname.Leave += new System.EventHandler(this.LeaveLastName);
            // 
            // empName
            // 
            this.empName.Location = new System.Drawing.Point(153, 94);
            this.empName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(100, 22);
            this.empName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Name";
            // 
            // ProjectsTab
            // 
            this.ProjectsTab.Controls.Add(this.adminPanelTree);
            this.ProjectsTab.Controls.Add(this.CloseProjects);
            this.ProjectsTab.Location = new System.Drawing.Point(4, 25);
            this.ProjectsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProjectsTab.Name = "ProjectsTab";
            this.ProjectsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProjectsTab.Size = new System.Drawing.Size(1044, 540);
            this.ProjectsTab.TabIndex = 1;
            this.ProjectsTab.Text = "Projects";
            this.ProjectsTab.UseVisualStyleBackColor = true;
            // 
            // adminPanelTree
            // 
            this.adminPanelTree.Location = new System.Drawing.Point(1, 4);
            this.adminPanelTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminPanelTree.Name = "adminPanelTree";
            treeNode2.Name = "Projects";
            treeNode2.Text = "Projects";
            this.adminPanelTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.adminPanelTree.Size = new System.Drawing.Size(991, 530);
            this.adminPanelTree.TabIndex = 26;
            this.adminPanelTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.adminPanelTree_AfterSelect);
            // 
            // CloseProjects
            // 
            this.CloseProjects.Location = new System.Drawing.Point(1000, 4);
            this.CloseProjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseProjects.Name = "CloseProjects";
            this.CloseProjects.Size = new System.Drawing.Size(39, 33);
            this.CloseProjects.TabIndex = 25;
            this.CloseProjects.Text = "X";
            this.CloseProjects.UseVisualStyleBackColor = true;
            this.CloseProjects.Click += new System.EventHandler(this.CloseTab);
            // 
            // CreateProjectTab
            // 
            this.CreateProjectTab.Controls.Add(this.projectTypeBox);
            this.CreateProjectTab.Controls.Add(this.managerBox1);
            this.CreateProjectTab.Controls.Add(this.estFinishDate);
            this.CreateProjectTab.Controls.Add(this.estStartDate);
            this.CreateProjectTab.Controls.Add(this.registerDate);
            this.CreateProjectTab.Controls.Add(this.saveProject);
            this.CreateProjectTab.Controls.Add(this.projectNo);
            this.CreateProjectTab.Controls.Add(this.description);
            this.CreateProjectTab.Controls.Add(this.projectName);
            this.CreateProjectTab.Controls.Add(this.CloseCreateProject);
            this.CreateProjectTab.Controls.Add(this.pDescription);
            this.CreateProjectTab.Controls.Add(this.label19);
            this.CreateProjectTab.Controls.Add(this.label12);
            this.CreateProjectTab.Controls.Add(this.label11);
            this.CreateProjectTab.Controls.Add(this.label10);
            this.CreateProjectTab.Controls.Add(this.label8);
            this.CreateProjectTab.Controls.Add(this.label7);
            this.CreateProjectTab.Controls.Add(this.label2);
            this.CreateProjectTab.Location = new System.Drawing.Point(4, 25);
            this.CreateProjectTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateProjectTab.Name = "CreateProjectTab";
            this.CreateProjectTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateProjectTab.Size = new System.Drawing.Size(1044, 540);
            this.CreateProjectTab.TabIndex = 2;
            this.CreateProjectTab.Text = "Create Project";
            this.CreateProjectTab.UseVisualStyleBackColor = true;
            // 
            // projectTypeBox
            // 
            this.projectTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectTypeBox.FormattingEnabled = true;
            this.projectTypeBox.Items.AddRange(new object[] {
            "Tübitak",
            "Yurtdışı",
            "Kobi"});
            this.projectTypeBox.Location = new System.Drawing.Point(585, 113);
            this.projectTypeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.projectTypeBox.Name = "projectTypeBox";
            this.projectTypeBox.Size = new System.Drawing.Size(160, 24);
            this.projectTypeBox.TabIndex = 33;
            // 
            // managerBox1
            // 
            this.managerBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.managerBox1.FormattingEnabled = true;
            this.managerBox1.Location = new System.Drawing.Point(163, 110);
            this.managerBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.managerBox1.Name = "managerBox1";
            this.managerBox1.Size = new System.Drawing.Size(160, 24);
            this.managerBox1.TabIndex = 33;
            // 
            // estFinishDate
            // 
            this.estFinishDate.Location = new System.Drawing.Point(184, 255);
            this.estFinishDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.estFinishDate.Name = "estFinishDate";
            this.estFinishDate.Size = new System.Drawing.Size(265, 22);
            this.estFinishDate.TabIndex = 32;
            // 
            // estStartDate
            // 
            this.estStartDate.Location = new System.Drawing.Point(184, 209);
            this.estStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.estStartDate.Name = "estStartDate";
            this.estStartDate.Size = new System.Drawing.Size(265, 22);
            this.estStartDate.TabIndex = 32;
            // 
            // registerDate
            // 
            this.registerDate.Enabled = false;
            this.registerDate.Location = new System.Drawing.Point(184, 166);
            this.registerDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerDate.Name = "registerDate";
            this.registerDate.Size = new System.Drawing.Size(265, 22);
            this.registerDate.TabIndex = 32;
            // 
            // saveProject
            // 
            this.saveProject.Location = new System.Drawing.Point(585, 190);
            this.saveProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveProject.Name = "saveProject";
            this.saveProject.Size = new System.Drawing.Size(160, 90);
            this.saveProject.TabIndex = 30;
            this.saveProject.Text = "Save Project";
            this.saveProject.UseVisualStyleBackColor = true;
            this.saveProject.Click += new System.EventHandler(this.saveProject_Click);
            // 
            // projectNo
            // 
            this.projectNo.Location = new System.Drawing.Point(163, 71);
            this.projectNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectNo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.projectNo.Name = "projectNo";
            this.projectNo.Size = new System.Drawing.Size(120, 22);
            this.projectNo.TabIndex = 27;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(585, 50);
            this.description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(100, 22);
            this.description.TabIndex = 26;
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(163, 26);
            this.projectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(100, 22);
            this.projectName.TabIndex = 26;
            // 
            // CloseCreateProject
            // 
            this.CloseCreateProject.Location = new System.Drawing.Point(1000, 5);
            this.CloseCreateProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseCreateProject.Name = "CloseCreateProject";
            this.CloseCreateProject.Size = new System.Drawing.Size(36, 30);
            this.CloseCreateProject.TabIndex = 25;
            this.CloseCreateProject.Text = "X";
            this.CloseCreateProject.UseVisualStyleBackColor = true;
            this.CloseCreateProject.Click += new System.EventHandler(this.CloseTab);
            // 
            // pDescription
            // 
            this.pDescription.AutoSize = true;
            this.pDescription.Location = new System.Drawing.Point(460, 50);
            this.pDescription.Name = "pDescription";
            this.pDescription.Size = new System.Drawing.Size(79, 17);
            this.pDescription.TabIndex = 6;
            this.pDescription.Text = "Description";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(460, 113);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 17);
            this.label19.TabIndex = 6;
            this.label19.Text = "Project Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Estimated Finish Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Estimated Start Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Register Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Manager";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Project No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Project Name";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 679);
            this.Controls.Add(this.AdminPanelControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanelClosed);
            this.Shown += new System.EventHandler(this.HideTabs);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.AdminPanelControl.ResumeLayout(false);
            this.EmployeeTab.ResumeLayout(false);
            this.EmployeeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ProjectsTab.ResumeLayout(false);
            this.CreateProjectTab.ResumeLayout(false);
            this.CreateProjectTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl AdminPanelControl;
        private System.Windows.Forms.TabPage EmployeeTab;
        private System.Windows.Forms.TabPage ProjectsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.Button projectButton;
        private System.Windows.Forms.Button empSaveButton;
        private System.Windows.Forms.TextBox empPassword;
        private System.Windows.Forms.TextBox empUsername;
        private System.Windows.Forms.TextBox empLastname;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage CreateProjectTab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CloseEmployee;
        private System.Windows.Forms.Button CloseProjects;
        private System.Windows.Forms.Button CloseCreateProject;
        private System.Windows.Forms.Label pDescription;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.NumericUpDown projectNo;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
        private System.Windows.Forms.Button saveProject;
        private System.Windows.Forms.DateTimePicker estFinishDate;
        private System.Windows.Forms.DateTimePicker estStartDate;
        private System.Windows.Forms.DateTimePicker registerDate;
        private System.Windows.Forms.ComboBox managerBox1;
        private System.Windows.Forms.ComboBox projectTypeBox;
        private System.Windows.Forms.TreeView adminPanelTree;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.ToolTip adminPanelToolTip;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button changeManager;
        private System.Windows.Forms.ComboBox changeManagerBox;
        private System.Windows.Forms.Button saveManager;
    }
}