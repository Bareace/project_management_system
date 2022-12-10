
namespace Project_management_system
{
    partial class EmployeeForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Projects");
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveProjectButton = new System.Windows.Forms.Button();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.logOutButtonEmp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editProjectButton = new System.Windows.Forms.Button();
            this.empProjectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpTabControl = new System.Windows.Forms.TabControl();
            this.EmpProjectsTab = new System.Windows.Forms.TabPage();
            this.empTreeView = new System.Windows.Forms.TreeView();
            this.EmpEditTab = new System.Windows.Forms.TabPage();
            this.monetaryReturn = new System.Windows.Forms.MaskedTextBox();
            this.addDocumentBut = new System.Windows.Forms.Button();
            this.milestoneLabel = new System.Windows.Forms.Label();
            this.editMSButton = new System.Windows.Forms.Button();
            this.saveTasksButton = new System.Windows.Forms.Button();
            this.addMilestoneButton = new System.Windows.Forms.Button();
            this.richMStoneBox = new System.Windows.Forms.RichTextBox();
            this.mileStoneBox = new System.Windows.Forms.ListBox();
            this.monRetType = new System.Windows.Forms.ListBox();
            this.projectTeamEmps = new System.Windows.Forms.CheckedListBox();
            this.StateBox = new System.Windows.Forms.GroupBox();
            this.radioCompleted = new System.Windows.Forms.RadioButton();
            this.radioInProg = new System.Windows.Forms.RadioButton();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.EmpTabControl.SuspendLayout();
            this.EmpProjectsTab.SuspendLayout();
            this.EmpEditTab.SuspendLayout();
            this.StateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveProjectButton);
            this.panel1.Controls.Add(this.currentUserLabel);
            this.panel1.Controls.Add(this.logOutButtonEmp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 119);
            this.panel1.TabIndex = 0;
            // 
            // saveProjectButton
            // 
            this.saveProjectButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.saveProjectButton.Font = new System.Drawing.Font("Lucida Bright", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("saveProjectButton.Image")));
            this.saveProjectButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveProjectButton.Location = new System.Drawing.Point(205, 9);
            this.saveProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveProjectButton.Name = "saveProjectButton";
            this.saveProjectButton.Size = new System.Drawing.Size(165, 105);
            this.saveProjectButton.TabIndex = 6;
            this.saveProjectButton.Text = "Save Project";
            this.saveProjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveProjectButton.UseVisualStyleBackColor = false;
            this.saveProjectButton.Visible = false;
            this.saveProjectButton.Click += new System.EventHandler(this.saveProjectButton_Click);
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Location = new System.Drawing.Point(16, 28);
            this.currentUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(89, 17);
            this.currentUserLabel.TabIndex = 8;
            this.currentUserLabel.Text = "Current User";
            // 
            // logOutButtonEmp
            // 
            this.logOutButtonEmp.Location = new System.Drawing.Point(1152, 28);
            this.logOutButtonEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOutButtonEmp.Name = "logOutButtonEmp";
            this.logOutButtonEmp.Size = new System.Drawing.Size(91, 73);
            this.logOutButtonEmp.TabIndex = 1;
            this.logOutButtonEmp.Text = "Log Out";
            this.logOutButtonEmp.UseVisualStyleBackColor = true;
            this.logOutButtonEmp.Click += new System.EventHandler(this.logOutButtonEmp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.editProjectButton);
            this.panel2.Controls.Add(this.empProjectButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 591);
            this.panel2.TabIndex = 0;
            // 
            // editProjectButton
            // 
            this.editProjectButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.editProjectButton.Font = new System.Drawing.Font("Lucida Bright", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProjectButton.Image = global::Project_management_system.Properties.Resources._1task7664;
            this.editProjectButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editProjectButton.Location = new System.Drawing.Point(3, 145);
            this.editProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editProjectButton.Name = "editProjectButton";
            this.editProjectButton.Size = new System.Drawing.Size(191, 118);
            this.editProjectButton.TabIndex = 6;
            this.editProjectButton.Text = "Edit Project";
            this.editProjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editProjectButton.UseVisualStyleBackColor = false;
            this.editProjectButton.Visible = false;
            this.editProjectButton.Click += new System.EventHandler(this.editProjectButton_Click);
            // 
            // empProjectButton
            // 
            this.empProjectButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.empProjectButton.Font = new System.Drawing.Font("Lucida Bright", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empProjectButton.Image = global::Project_management_system.Properties.Resources._7664;
            this.empProjectButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.empProjectButton.Location = new System.Drawing.Point(3, 36);
            this.empProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empProjectButton.Name = "empProjectButton";
            this.empProjectButton.Size = new System.Drawing.Size(195, 105);
            this.empProjectButton.TabIndex = 5;
            this.empProjectButton.Text = "Projects";
            this.empProjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.empProjectButton.UseVisualStyleBackColor = false;
            this.empProjectButton.Click += new System.EventHandler(this.empProjectButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planning";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // EmpTabControl
            // 
            this.EmpTabControl.Controls.Add(this.EmpProjectsTab);
            this.EmpTabControl.Controls.Add(this.EmpEditTab);
            this.EmpTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpTabControl.Location = new System.Drawing.Point(200, 119);
            this.EmpTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpTabControl.Name = "EmpTabControl";
            this.EmpTabControl.SelectedIndex = 0;
            this.EmpTabControl.Size = new System.Drawing.Size(1127, 591);
            this.EmpTabControl.TabIndex = 1;
            // 
            // EmpProjectsTab
            // 
            this.EmpProjectsTab.Controls.Add(this.empTreeView);
            this.EmpProjectsTab.Location = new System.Drawing.Point(4, 25);
            this.EmpProjectsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpProjectsTab.Name = "EmpProjectsTab";
            this.EmpProjectsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpProjectsTab.Size = new System.Drawing.Size(1119, 562);
            this.EmpProjectsTab.TabIndex = 0;
            this.EmpProjectsTab.Text = "Projects";
            this.EmpProjectsTab.UseVisualStyleBackColor = true;
            // 
            // empTreeView
            // 
            this.empTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empTreeView.Location = new System.Drawing.Point(4, 4);
            this.empTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empTreeView.Name = "empTreeView";
            treeNode1.Name = "EmpProjects";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            treeNode1.Text = "Projects";
            this.empTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.empTreeView.Size = new System.Drawing.Size(1111, 554);
            this.empTreeView.TabIndex = 7;
            // 
            // EmpEditTab
            // 
            this.EmpEditTab.Controls.Add(this.monetaryReturn);
            this.EmpEditTab.Controls.Add(this.addDocumentBut);
            this.EmpEditTab.Controls.Add(this.milestoneLabel);
            this.EmpEditTab.Controls.Add(this.editMSButton);
            this.EmpEditTab.Controls.Add(this.saveTasksButton);
            this.EmpEditTab.Controls.Add(this.addMilestoneButton);
            this.EmpEditTab.Controls.Add(this.richMStoneBox);
            this.EmpEditTab.Controls.Add(this.mileStoneBox);
            this.EmpEditTab.Controls.Add(this.monRetType);
            this.EmpEditTab.Controls.Add(this.projectTeamEmps);
            this.EmpEditTab.Controls.Add(this.StateBox);
            this.EmpEditTab.Controls.Add(this.endDate);
            this.EmpEditTab.Controls.Add(this.startDate);
            this.EmpEditTab.Controls.Add(this.label7);
            this.EmpEditTab.Controls.Add(this.label6);
            this.EmpEditTab.Controls.Add(this.label5);
            this.EmpEditTab.Controls.Add(this.label4);
            this.EmpEditTab.Controls.Add(this.label9);
            this.EmpEditTab.Controls.Add(this.label8);
            this.EmpEditTab.Controls.Add(this.label3);
            this.EmpEditTab.Controls.Add(this.label2);
            this.EmpEditTab.Location = new System.Drawing.Point(4, 25);
            this.EmpEditTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpEditTab.Name = "EmpEditTab";
            this.EmpEditTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpEditTab.Size = new System.Drawing.Size(1119, 562);
            this.EmpEditTab.TabIndex = 1;
            this.EmpEditTab.Text = "EditProject";
            this.EmpEditTab.UseVisualStyleBackColor = true;
            // 
            // monetaryReturn
            // 
            this.monetaryReturn.Location = new System.Drawing.Point(175, 198);
            this.monetaryReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monetaryReturn.Mask = "0000000000000";
            this.monetaryReturn.Name = "monetaryReturn";
            this.monetaryReturn.Size = new System.Drawing.Size(132, 22);
            this.monetaryReturn.TabIndex = 43;
            this.monetaryReturn.ValidatingType = typeof(int);
            // 
            // addDocumentBut
            // 
            this.addDocumentBut.Location = new System.Drawing.Point(691, 34);
            this.addDocumentBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDocumentBut.Name = "addDocumentBut";
            this.addDocumentBut.Size = new System.Drawing.Size(129, 64);
            this.addDocumentBut.TabIndex = 42;
            this.addDocumentBut.Text = "Add Document";
            this.addDocumentBut.UseVisualStyleBackColor = true;
            this.addDocumentBut.Click += new System.EventHandler(this.addDocumentBut_Click);
            // 
            // milestoneLabel
            // 
            this.milestoneLabel.AutoSize = true;
            this.milestoneLabel.Location = new System.Drawing.Point(668, 148);
            this.milestoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.milestoneLabel.Name = "milestoneLabel";
            this.milestoneLabel.Size = new System.Drawing.Size(54, 17);
            this.milestoneLabel.TabIndex = 41;
            this.milestoneLabel.Text = "label10";
            // 
            // editMSButton
            // 
            this.editMSButton.Enabled = false;
            this.editMSButton.Location = new System.Drawing.Point(992, 405);
            this.editMSButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editMSButton.Name = "editMSButton";
            this.editMSButton.Size = new System.Drawing.Size(103, 85);
            this.editMSButton.TabIndex = 40;
            this.editMSButton.Text = "Edit Milestone";
            this.editMSButton.UseVisualStyleBackColor = true;
            this.editMSButton.Click += new System.EventHandler(this.editMSButton_Click);
            // 
            // saveTasksButton
            // 
            this.saveTasksButton.Enabled = false;
            this.saveTasksButton.Location = new System.Drawing.Point(992, 272);
            this.saveTasksButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveTasksButton.Name = "saveTasksButton";
            this.saveTasksButton.Size = new System.Drawing.Size(103, 85);
            this.saveTasksButton.TabIndex = 40;
            this.saveTasksButton.Text = "Save Tasks";
            this.saveTasksButton.UseVisualStyleBackColor = true;
            this.saveTasksButton.Click += new System.EventHandler(this.saveTasksButton_Click);
            // 
            // addMilestoneButton
            // 
            this.addMilestoneButton.Location = new System.Drawing.Point(992, 177);
            this.addMilestoneButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addMilestoneButton.Name = "addMilestoneButton";
            this.addMilestoneButton.Size = new System.Drawing.Size(103, 87);
            this.addMilestoneButton.TabIndex = 2;
            this.addMilestoneButton.Text = "Add Milestone";
            this.addMilestoneButton.UseVisualStyleBackColor = true;
            this.addMilestoneButton.Click += new System.EventHandler(this.addMilestoneButton_Click);
            // 
            // richMStoneBox
            // 
            this.richMStoneBox.Location = new System.Drawing.Point(672, 167);
            this.richMStoneBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richMStoneBox.Name = "richMStoneBox";
            this.richMStoneBox.Size = new System.Drawing.Size(311, 229);
            this.richMStoneBox.TabIndex = 39;
            this.richMStoneBox.Text = "";
            // 
            // mileStoneBox
            // 
            this.mileStoneBox.FormattingEnabled = true;
            this.mileStoneBox.ItemHeight = 16;
            this.mileStoneBox.Location = new System.Drawing.Point(672, 405);
            this.mileStoneBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mileStoneBox.Name = "mileStoneBox";
            this.mileStoneBox.Size = new System.Drawing.Size(311, 132);
            this.mileStoneBox.TabIndex = 38;
            this.mileStoneBox.SelectedIndexChanged += new System.EventHandler(this.mileStoneBoxSIC);
            // 
            // monRetType
            // 
            this.monRetType.FormattingEnabled = true;
            this.monRetType.ItemHeight = 16;
            this.monRetType.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Annual"});
            this.monRetType.Location = new System.Drawing.Point(175, 265);
            this.monRetType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monRetType.Name = "monRetType";
            this.monRetType.Size = new System.Drawing.Size(148, 68);
            this.monRetType.TabIndex = 38;
            // 
            // projectTeamEmps
            // 
            this.projectTeamEmps.FormattingEnabled = true;
            this.projectTeamEmps.Location = new System.Drawing.Point(167, 350);
            this.projectTeamEmps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.projectTeamEmps.Name = "projectTeamEmps";
            this.projectTeamEmps.Size = new System.Drawing.Size(204, 174);
            this.projectTeamEmps.TabIndex = 37;
            // 
            // StateBox
            // 
            this.StateBox.Controls.Add(this.radioCompleted);
            this.StateBox.Controls.Add(this.radioInProg);
            this.StateBox.Location = new System.Drawing.Point(167, 107);
            this.StateBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StateBox.Name = "StateBox";
            this.StateBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StateBox.Size = new System.Drawing.Size(267, 71);
            this.StateBox.TabIndex = 36;
            this.StateBox.TabStop = false;
            this.StateBox.Text = "States";
            // 
            // radioCompleted
            // 
            this.radioCompleted.AutoSize = true;
            this.radioCompleted.Location = new System.Drawing.Point(132, 34);
            this.radioCompleted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioCompleted.Name = "radioCompleted";
            this.radioCompleted.Size = new System.Drawing.Size(96, 21);
            this.radioCompleted.TabIndex = 0;
            this.radioCompleted.TabStop = true;
            this.radioCompleted.Text = "Completed";
            this.radioCompleted.UseVisualStyleBackColor = true;
            this.radioCompleted.CheckedChanged += new System.EventHandler(this.CompletedChanged);
            // 
            // radioInProg
            // 
            this.radioInProg.AutoSize = true;
            this.radioInProg.Location = new System.Drawing.Point(8, 34);
            this.radioInProg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioInProg.Name = "radioInProg";
            this.radioInProg.Size = new System.Drawing.Size(113, 21);
            this.radioInProg.TabIndex = 0;
            this.radioInProg.TabStop = true;
            this.radioInProg.Text = "In Progress...";
            this.radioInProg.UseVisualStyleBackColor = true;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(167, 75);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(265, 22);
            this.endDate.TabIndex = 34;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(167, 27);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(265, 22);
            this.startDate.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 354);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Project Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monetary Return Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monetary Return";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Project End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 167);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Project Milestones and Tasks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(469, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Project Documentations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Project Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project State";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 710);
            this.Controls.Add(this.EmpTabControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.EmpTabControl.ResumeLayout(false);
            this.EmpProjectsTab.ResumeLayout(false);
            this.EmpEditTab.ResumeLayout(false);
            this.EmpEditTab.PerformLayout();
            this.StateBox.ResumeLayout(false);
            this.StateBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button empProjectButton;
        private System.Windows.Forms.Button editProjectButton;
        private System.Windows.Forms.TabControl EmpTabControl;
        private System.Windows.Forms.TabPage EmpProjectsTab;
        private System.Windows.Forms.TabPage EmpEditTab;
        private System.Windows.Forms.TreeView empTreeView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.GroupBox StateBox;
        private System.Windows.Forms.RadioButton radioCompleted;
        private System.Windows.Forms.RadioButton radioInProg;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckedListBox projectTeamEmps;
        private System.Windows.Forms.Button logOutButtonEmp;
        private System.Windows.Forms.ListBox monRetType;
        private System.Windows.Forms.RichTextBox richMStoneBox;
        private System.Windows.Forms.Button saveTasksButton;
        private System.Windows.Forms.Button addMilestoneButton;
        private System.Windows.Forms.Button saveProjectButton;
        private System.Windows.Forms.Label milestoneLabel;
        private System.Windows.Forms.Button addDocumentBut;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox monetaryReturn;
        private System.Windows.Forms.ListBox mileStoneBox;
        private System.Windows.Forms.Button editMSButton;
        private System.Windows.Forms.Label currentUserLabel;
    }
}

