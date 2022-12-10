using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_management_system
{
    public partial class EmployeeForm : Form
    {
        AdminPanel.Project currentProject;
        int currentProjectNode;
        int currentMileStoneIndex;
        public EmployeeForm()
        {
            InitializeComponent();
            // Pop ups
            toolTip1.SetToolTip(radioInProg, "Check if project is in progress.");
            toolTip1.SetToolTip(radioCompleted, "Check if project is completed.");
            toolTip1.SetToolTip(startDate, "Please choose a valid date.");
            toolTip1.SetToolTip(endDate, "Please choose a valid date.");
            
            EmpTabControl.TabPages.Remove(EmpProjectsTab);
            EmpTabControl.TabPages.Remove(EmpEditTab);

            currentUserLabel.Text = "Current user: " + LoginPanel.currentUser.Username;

            if (LoginPanel.currentUser.IsManager)
            {
                editProjectButton.Visible = true;
                saveProjectButton.Visible = false;
            }
            else
            {
                editProjectButton.Visible = false;
                saveProjectButton.Visible = false;
            }
        }

        private void empProjectButton_Click(object sender, EventArgs e)
        {
            if (EmpTabControl.TabPages.Contains(EmpProjectsTab))
            {
                return;
            }
            else
            {
                EmpTabControl.TabPages.Add(EmpProjectsTab);
                for (int i = 0; i < AdminPanel.projectList.Count; i++)
                {
                    AdminPanel.Project p = AdminPanel.projectList[i] as AdminPanel.Project;
                    if (p.ProjectEmpList.Contains(LoginPanel.currentUser) || p.Manager == LoginPanel.currentUser)
                    {
                        AdminPanel.ProjectTree(empTreeView, p, i);
                    }
                    
                }
                
            }
        }

        private void editProjectButton_Click(object sender, EventArgs e)
        {
            foreach(AdminPanel.Project p1 in AdminPanel.projectList)
            {   
                if (empTreeView.SelectedNode == null)
                {
                    break;
                }
                if (empTreeView.SelectedNode.Text == p1.ProjectName )
                {
                    currentProject = p1;
                    currentProjectNode = empTreeView.SelectedNode.Index;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (currentProject != null)
            {
                if (!currentProject.ProjectEdited) // If project IS NOT edited before.
                {
                    if (EmpTabControl.TabPages.Contains(EmpEditTab))
                    {
                        MessageBox.Show("You can edit one project at a time!");
                        return;
                    }
                    else
                    {
                        EmpTabControl.TabPages.Add(EmpEditTab);
                        saveProjectButton.Visible = true;
                    }
                    foreach (Employee emp in AdminPanel.employeeList)
                    {
                        if (emp.Username == LoginPanel.currentUser.Username)
                        {
                            continue;
                        }
                        projectTeamEmps.Items.Add(emp);
                    }
                    endDate.Enabled = false;
                    milestoneLabel.Text = "Please add a milestone.";
                }
                else // If project IS edited before
                {
                    int index = -1;
                    if (EmpTabControl.TabPages.Contains(EmpEditTab))
                    {
                        MessageBox.Show("You can edit one project at a time!");
                        return;
                    }
                    else
                    {
                        EmpTabControl.TabPages.Add(EmpEditTab);
                        saveProjectButton.Visible = true;
                    }
                    // Show employees.
                    foreach (Employee emp in AdminPanel.employeeList)
                    {
                        if (emp.Username == LoginPanel.currentUser.Username)
                        {
                            continue;
                        }
                        projectTeamEmps.Items.Add(emp);
                        index++;
                        if (currentProject.ProjectEmpList.Contains(emp))
                        {
                            projectTeamEmps.SetItemChecked(index, true);
                        }
                    }
                    // Show milestones.
                    if (currentProject.MileStoneList != null)
                    {
                        foreach(AdminPanel.MileStone ms in currentProject.MileStoneList)
                        {
                            mileStoneBox.Items.Add(ms.MStoneName);
                        }
                    }
                    else
                    {
                        mileStoneBox.Items.Add("Please add milestones and tasks to the project!");
                    }
                    endDate.Enabled = false;
                    milestoneLabel.Text = "Please add a milestone.";
                    // Show project state
                    if (currentProject.State.StateOfTheProject != "Waiting for approval..")
                    {
                        if (currentProject.State.StateOfTheProject != "In Progress...")
                        {
                            radioInProg.Checked = true;
                        }
                        else
                        {
                            radioCompleted.Checked = true;
                        }
                    }
                    // Show Monetary return
                    monetaryReturn.Text = currentProject.MonetaryReturn.ToString();
                    // Show monetary return type
                    if (currentProject.MonetaryReturnType == "Daily")
                    {
                        monRetType.SelectedIndex = 0;
                    }
                    else if (currentProject.MonetaryReturnType == "Weekly")
                    {
                        monRetType.SelectedIndex = 1;
                    }
                    else
                    {
                        monRetType.SelectedIndex = 2;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a valid project!");
            }
        }

        private void logOutButtonEmp_Click(object sender, EventArgs e)
        {
            LoginPanel.currentUser = null;
            EmpTabControl.TabPages.Remove(EmpProjectsTab);
            EmpTabControl.TabPages.Remove(EmpEditTab);
            this.Close();
            FormProvider.LPanel.Show();
        }

        private void saveProjectButton_Click(object sender, EventArgs e)
        {
            if (radioCompleted.Checked)
            {
                if (DateTime.Compare(Convert.ToDateTime(endDate.Value.ToString()), Convert.ToDateTime(startDate.Value.ToString())) > 0 && 
                    monetaryReturn.Text != "" && monRetType.SelectedItems != null)
                {
                    currentProject.StartDate = startDate.Value;
                    currentProject.EndDate = endDate.Value;
                    currentProject.State.StateOfTheProject = "Completed.";
                    currentProject.MonetaryReturn = Convert.ToInt32(monetaryReturn.Text);
                    currentProject.MonetaryReturnType = monRetType.SelectedItem.ToString();
                    foreach(Employee emp1 in projectTeamEmps.CheckedItems)
                    {
                        if (currentProject.ProjectEmpList.Contains(emp1))
                        {
                            continue;
                        }
                        else
                        {
                            currentProject.ProjectEmpList.Add(emp1); // Denensin
                        }
                    }
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[6].Nodes.Clear();
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[6].Nodes.Add(currentProject.StartDate.ToString());
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[7].Nodes.Clear();
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[7].Nodes.Add(currentProject.EndDate.ToString()); 
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[8].Nodes[0].Text = (currentProject.State.StateOfTheProject);
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[9].Nodes.Clear();
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[9].Nodes.Add(currentProject.MonetaryReturn.ToString());
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[9].Nodes.Add(currentProject.MonetaryReturnType);
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[10].Nodes.Clear();
                    foreach (Employee emp in currentProject.ProjectEmpList)
                    {
                        empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[10].Nodes.Add(emp.ToString());
                    }
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[11].Nodes.Clear();
                    foreach (string doc in currentProject.ProjectDocuments)
                    {
                        empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[11].Nodes.Add(doc);
                    }
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[13].Nodes.Clear();
                    for (int i = 0; i < currentProject.MileStoneList.Count; i++)
                    {
                        AdminPanel.MileStone ms = currentProject.MileStoneList[i] as AdminPanel.MileStone;
                        empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[13].Nodes.Add(ms.MStoneName);
                        foreach(Dictionary<string, int> task in ms.TaskList)
                        {
                            empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[13].Nodes[i].Nodes.Add(task.ElementAt(0).Key);
                        }
                    }
                    currentProject.ProjectEdited = true;
                    ClearEmpEditTab();
                    saveProjectButton.Visible = false;

                }
                else
                {
                    MessageBox.Show("!!");
                }
            }
            else
            {
                if (monetaryReturn.Text != "" && monRetType.SelectedItems != null)
                {
                    currentProject.StartDate = startDate.Value;
                    if (radioInProg.Checked)
                    {
                        currentProject.State.StateOfTheProject = "In progres...";
                    }
                    currentProject.MonetaryReturn = Convert.ToInt32(monetaryReturn.Text);
                    currentProject.MonetaryReturnType = monRetType.SelectedItem.ToString();
                    foreach (Employee emp1 in projectTeamEmps.CheckedItems)
                    {
                        if (currentProject.ProjectEmpList.Contains(emp1))
                        {
                            continue;
                        }
                        else
                        {
                            currentProject.ProjectEmpList.Add(emp1); // Denensin
                        }
                    }
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[6].Nodes.Clear();
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[6].Nodes.Add(currentProject.StartDate.ToString());
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[8].Nodes[0].Text = (currentProject.State.StateOfTheProject);
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[9].Nodes.Clear();
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[9].Nodes.Add(currentProject.MonetaryReturn.ToString());
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[9].Nodes.Add(currentProject.MonetaryReturnType);
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[10].Nodes.Clear();
                    foreach (Employee emp in currentProject.ProjectEmpList)
                    {
                        empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[10].Nodes.Add(emp.ToString());
                    }
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[11].Nodes.Clear();
                    foreach (string doc in currentProject.ProjectDocuments)
                    {
                        empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[11].Nodes.Add(doc);
                    }
                    empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[13].Nodes.Clear();
                    for (int i = 0; i < currentProject.MileStoneList.Count; i++)
                    {
                        AdminPanel.MileStone ms = currentProject.MileStoneList[i] as AdminPanel.MileStone;
                        empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[13].Nodes.Add(ms.MStoneName);
                        foreach (Dictionary<string, int> task in ms.TaskList)
                        {
                            empTreeView.Nodes[0].Nodes[currentProjectNode].Nodes[13].Nodes[i].Nodes.Add(task.ElementAt(0).Key);
                        }

                    }
                    currentProject.ProjectEdited = true;
                    ClearEmpEditTab();
                    saveProjectButton.Visible = false;
                }
                else
                {
                    MessageBox.Show("!!");
                }
            }
            
        }

        private void addMilestoneButton_Click(object sender, EventArgs e)
        {
            AdminPanel.MileStone ms = new AdminPanel.MileStone();
            string milestone = richMStoneBox.Text;
            milestoneLabel.Text = milestone + "|| Please write tasks line by line.";
            ms.MStoneName = milestone;
            currentProject.MileStoneList.Add(ms);
            currentMileStoneIndex = currentProject.MileStoneList.Count() - 1;
            saveTasksButton.Enabled = true;
            addMilestoneButton.Enabled = false;
            richMStoneBox.Clear();
            mileStoneBox.Items.Add(ms.MStoneName);
        }

        private void saveTasksButton_Click(object sender, EventArgs e)
        {
            List<char> taskChars = new List<char>();
            for (int i = 0; i < richMStoneBox.Lines.Length; i++)
            {
                foreach (char t in richMStoneBox.Lines[i])
                {
                    taskChars.Add(t);
                }
                string s = string.Join("", taskChars);
                Dictionary<string, int> d = new Dictionary<string, int>();
                if (s != "" && s != " ")
                {
                    d.Add(s, 0);
                    currentProject.MileStoneList[currentMileStoneIndex].TaskList.Add(d);
                }
                taskChars.Clear();
            }
            milestoneLabel.Text = "Please add a milestone";
            saveTasksButton.Enabled = false;
            addMilestoneButton.Enabled = true;
            richMStoneBox.Clear();
        }

        private void addDocumentBut_Click(object sender, EventArgs e)
        {
            List<string> fileList = currentProject.ProjectDocuments;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileList.Add(openFileDialog1.FileName);
            }
        }

        private void CompletedChanged(object sender, EventArgs e)
        {
            if (radioCompleted.Checked)
            {
                endDate.Enabled = true;
            }
            else
            {
                endDate.Enabled = false;
            }
        }
    
        private void ClearEmpEditTab()
        {
            radioCompleted.Checked = false;
            radioInProg.Checked = false;
            startDate.Value = DateTime.Now;
            endDate.Value = DateTime.Now;
            monetaryReturn.Text = "";
            monRetType.SelectedIndex = -1;
            projectTeamEmps.Items.Clear();
            milestoneLabel.Text = "Please add a milestone.";
            addMilestoneButton.Enabled = true;
            saveTasksButton.Enabled = false;
            mileStoneBox.Items.Clear();
            EmpTabControl.TabPages.Remove(EmpEditTab);
        }

        private void editMSButton_Click(object sender, EventArgs e)
        {
            currentMileStoneIndex = mileStoneBox.SelectedIndex;
            addMilestoneButton.Enabled = false;
            saveTasksButton.Enabled = true;
            milestoneLabel.Text = currentProject.MileStoneList[currentMileStoneIndex].MStoneName + "|| Please add tasks.";
            richMStoneBox.Text = currentProject.MileStoneList[currentMileStoneIndex].PrintTaskList();
            mileStoneBox.SelectedIndex = -1;
            currentProject.MileStoneList[currentMileStoneIndex].TaskList.Clear();
        }

        private void mileStoneBoxSIC(object sender, EventArgs e)
        {
            if (mileStoneBox.SelectedIndex == -1)
            {
                editMSButton.Enabled = false;
            }
            else
            {
                editMSButton.Enabled = true;
            }
        }
        
    }
}
