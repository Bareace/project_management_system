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
    public partial class AdminPanel : Form
    {
        public static List<object> employeeList = new List<object>();
        public static List<object> projectList = new List<object>();
        public static List<int> countList = new List<int>();
        private Project cProject;
        private int cProjectNode;
        private Employee cEmp;
        
        public AdminPanel()
        {
            InitializeComponent();
            adminPanelToolTip.SetToolTip(description, "Project description, purpose and content");
            adminPanelToolTip.SetToolTip(managerBox1, "Choose a manager from employees.");
            adminPanelToolTip.SetToolTip(estStartDate, "Please choose a valid date.");
            adminPanelToolTip.SetToolTip(estFinishDate, "Please choose a valid date.");
        }

        public class Project
        {
            public string ProjectName { get; set; }
            public int ProjectNo { get; set; }
            public Employee Manager { get; set; }

            public List<Employee> ProjectEmpList; // Dursun
            public string Description { get; set; }
            public ProjectType PType { get; set; }
            public DateTime RegDate { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public DateTime EstimatedStartDate { get; set; }
            public DateTime EstimatedEndDate { get; set; }
            public ProjectState State { get; set; }
            public List<string> ProjectDocuments { get; set; }
            public List<MileStone> MileStoneList { get; set; }
            public int MonetaryReturn { get; set; }
            public string MonetaryReturnType { get; set; }
            public bool ProjectEdited { get; set; } = false;

        }
        public class MileStone
        {
            public string MStoneName { get; set; }
            public List<Dictionary<string, int>> TaskList { get; set; }
            public MileStone()
            {
                this.TaskList = new List<Dictionary<string, int>>();

            }
            public string PrintTaskList()
            {
                string ret = "";
                for (int i = 0; i < this.TaskList.Count; i++)
                {
                    ret = ret + this.TaskList[i].ElementAt(0).Key + "\n";
                }
                return ret;
            }
        }
        public class ProjectState
        {
            public string StateOfTheProject { get; set; }
            public ProjectState()
            {
                this.StateOfTheProject = "Waiting for approval..";
            }
        }

        public class ProjectType
        {
            public string type { get; set; }
            public ProjectType(string type)
            {
                this.type = type;
            }
        }
        
        private void EmpSaveButton_Click(object sender, EventArgs e)
        {
            if (empName.Text != "" && empLastname.Text != "")
            {
                Employee Emp1 = new Employee();
                Emp1.Name = empName.Text;
                Emp1.LastName = empLastname.Text;
                Emp1.Username = empUsername.Text;
                Emp1.Password = empPassword.Text;
                Emp1.IsManager = false;
                employeeList.Add(Emp1);
                managerBox1.Items.Add(Emp1.Username);
                countList.Add(1);
                dataGridView1.Rows.Add(empName.Text, empLastname.Text, empUsername.Text, empPassword.Text);
                ClearAddEmployee();
            }
            else
            {
                MessageBox.Show("Fill in the required fields!");
            }
        }

        private void LeaveLastName(object sender, EventArgs e)
        {
            empUsername.Text = empName.Text + empLastname.Text + (countList.Count + 1);
            empPassword.Text = empLastname.Text + empName.Text + (countList.Count + 1);
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            if (AdminPanelControl.TabPages.Contains(EmployeeTab))
            {
                return;
            }
            else
            {
                AdminPanelControl.TabPages.Add(EmployeeTab);
                for (int i = 0; i < employeeList.Count; i++)
                {
                    Employee dgEmp = employeeList[i] as Employee;
                    dataGridView1.Rows.Add(dgEmp.Name, dgEmp.LastName, dgEmp.Username, dgEmp.Password);
                }
            }
            
        }

        // Hide tab control tabs at the opening.
        private void HideTabs(object sender, EventArgs e)
        {
            AdminPanelControl.TabPages.Remove(EmployeeTab);
            AdminPanelControl.TabPages.Remove(ProjectsTab);
            adminPanelTree.Nodes[0].Nodes.Clear();
            AdminPanelControl.TabPages.Remove(CreateProjectTab);
        }

        private void ProjectButton_Click(object sender, EventArgs e)
        {
            if (AdminPanelControl.TabPages.Contains(ProjectsTab))
            {
                return;
            }
            else
            {
                AdminPanelControl.TabPages.Add(ProjectsTab);

                for (int i = 0; i < projectList.Count; i++)
                {
                    Project p = projectList[i] as Project;
                    ProjectTree(adminPanelTree, p, i);
                }
            }
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            if (AdminPanelControl.TabPages.Contains(CreateProjectTab))
            {
                return;
            }
            else
            {
                AdminPanelControl.TabPages.Add(CreateProjectTab);
                managerBox1.Items.Clear();
                for (int i = 0; i < employeeList.Count; i++)
                {
                    Employee cpEmp = employeeList[i] as Employee;
                    managerBox1.Items.Add(cpEmp.Username);
                }
                registerDate.Value = DateTime.Now;
                estStartDate.Value = DateTime.Now;
                estFinishDate.Value = DateTime.Now;
            }
            
        }

        // Closing tabs.
        private void CloseTab(object sender, EventArgs e)
        {
            Button CBtn = (Button)sender;
            string CurrentTabName = CBtn.Name;
            if (CurrentTabName == "CloseEmployee")
            {
                AdminPanelControl.TabPages.Remove(EmployeeTab);
                dataGridView1.Rows.Clear();
                ClearAddEmployee();
            }
            else if (CurrentTabName == "CloseProjects")
            {
                AdminPanelControl.TabPages.Remove(ProjectsTab);
                adminPanelTree.Nodes[0].Nodes.Clear();
                changeManagerBox.Visible = false;
                changeManagerBox.SelectedItem = null;
                saveManager.Visible = false;
            }
            else if (CurrentTabName == "CloseCreateProject")
            {
                AdminPanelControl.TabPages.Remove(CreateProjectTab);
                ClearCreateProject();
            }
        }

        // Executes if admin panel is closed
        private void AdminPanelClosed(object sender, FormClosedEventArgs e)
        {
            // FormProvider.LPanel.Close();
        }

        // Method to delete an employee
        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                int currentRow = dataGridView1.CurrentCell.RowIndex;
                Employee emp = employeeList[currentRow] as Employee;
                if (emp.IsManager)
                {
                    MessageBox.Show("Employee that you are trying to delete is currently manager in a project. " +
                        "Please be sure that the employee you are trying to delete is not a manager!", "Warning!!");
                    return;
                }
                else
                {

                    foreach (Project pd in projectList)
                    {
                        for (int i = 0; i < pd.ProjectEmpList.Count; i++)
                        {
                            Employee emppp = pd.ProjectEmpList[i] as Employee;
                            if (emppp == emp)
                            {
                                pd.ProjectEmpList.Remove(emp);
                            }
                        }
                    }
                    AdminPanelControl.TabPages.Remove(ProjectsTab);
                    adminPanelTree.Nodes[0].Nodes.Clear();
                    dataGridView1.Rows.RemoveAt(currentRow);
                    employeeList.RemoveAt(currentRow);
                    countList[currentRow] = 0;
                    AdminPanelControl.TabPages.Remove(CreateProjectTab);
                }
                
                
            }
            catch 
            {
                MessageBox.Show(" Wrong row selection.");
            }
        }
       
        // Method to clear the text boxes in employee.
        private void ClearAddEmployee()
        {
            empName.Text = "";
            empLastname.Text = "";
            empUsername.Text = "";
            empPassword.Text = "";
        }

        private void saveProject_Click(object sender, EventArgs e)
        {
            if (projectName.Text != "" && projectNo.Value != 0 && managerBox1.SelectedIndex != -1 && description.Text != "" && projectTypeBox.SelectedIndex != -1 
                && DateTime.Compare(Convert.ToDateTime(estFinishDate.Value.ToString()), Convert.ToDateTime(estStartDate.Value.ToString())) > 0 
                && DateTime.Compare(Convert.ToDateTime(estStartDate.Value.ToString()), DateTime.Now) > 0)
            {
                Project p1 = new Project();
                p1.ProjectName = projectName.Text;
                p1.ProjectNo = Convert.ToInt32(projectNo.Value);
                foreach (Employee emp in employeeList)
                {
                    if (emp.Username == managerBox1.SelectedItem.ToString())
                    {
                        emp.IsManager = true;
                        p1.Manager = emp;
                    }
                }
                p1.EstimatedStartDate = estStartDate.Value;
                p1.EstimatedEndDate = estFinishDate.Value;
                p1.Description = description.Text;
                ProjectType pt = new ProjectType(projectTypeBox.SelectedItem.ToString());
                p1.PType = pt;
                
                ProjectState ps = new ProjectState();
                p1.State = ps;
                p1.RegDate = DateTime.Now;

                if (AdminPanelControl.TabPages.Contains(ProjectsTab))
                {
                    ProjectTree(adminPanelTree, p1, projectList.Count);
                }
                
                p1.MileStoneList = new List<MileStone>();
                p1.ProjectEmpList = new List<Employee>();
                p1.ProjectDocuments = new List<string>();
                projectList.Add(p1); // Adding project to project list 
                MessageBox.Show("Project saved!", "Success!");
            }
            if (projectName.Text == "" || projectNo.Value == 0 || managerBox1.SelectedIndex == -1 || description.Text == "" || projectTypeBox.SelectedIndex == -1)
            {
                MessageBox.Show("Fill in all blank fields!!");
                return;
            }
            else if (DateTime.Compare(Convert.ToDateTime(estStartDate.Value.ToString()), Convert.ToDateTime(estFinishDate.Value.ToString())) >= 0)
            {
                MessageBox.Show("Estimated end date cannot be earlier than estimated start date!");
                return;
            }
            else if (DateTime.Compare(Convert.ToDateTime(estStartDate.Value.ToString()), DateTime.Now) <= 0)
            {
                MessageBox.Show("Estimated start date cannot be earlier than register date!");
                return;
            }
            ClearCreateProject();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginPanel.currentUser = null;
            AdminPanelControl.TabPages.Remove(ProjectsTab);
            adminPanelTree.Nodes[0].Nodes.Clear();
            AdminPanelControl.TabPages.Remove(CreateProjectTab);
            dataGridView1.Rows.Clear();
            AdminPanelControl.TabPages.Remove(EmployeeTab);
            FormProvider.APanel.Hide();
            FormProvider.LPanel.Show();
        }

        public static void ProjectTree(TreeView tv, Project tp, int pIndex)
        {
            if (tp.ProjectEdited)
            {
                tv.Nodes[0].Nodes.Add(new TreeNode(tp.ProjectName));
                tv.Nodes[0].BackColor = Color.Yellow;
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project No: " + tp.ProjectNo)); // Node  0
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Manager")); // Node  1
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Description")); // Node 2
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Registration Date")); // Node  3
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Est. Start Date")); // Node 4
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Est. End Date")); // Node  5
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Start Date")); // Node 6
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project End Date")); // Node 7
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project State")); // Node 8
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Monetary Return")); // Node 9
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Team")); // Node 10
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Documentations")); // Node  11
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Type")); // Node 12
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Milestones and Tasks")); // Node  13

                tv.Nodes[0].Nodes[pIndex].Nodes[1].Nodes.Add(new TreeNode(tp.Manager.Name + " " + tp.Manager.LastName));
                tv.Nodes[0].Nodes[pIndex].Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Username: " + tp.Manager.Username));
                tv.Nodes[0].Nodes[pIndex].Nodes[2].Nodes.Add(new TreeNode(tp.Description));
                tv.Nodes[0].Nodes[pIndex].Nodes[3].Nodes.Add(new TreeNode(tp.RegDate.ToString()));
                tv.Nodes[0].Nodes[pIndex].Nodes[4].Nodes.Add(new TreeNode(tp.EstimatedStartDate.ToString()));
                tv.Nodes[0].Nodes[pIndex].Nodes[5].Nodes.Add(new TreeNode(tp.EstimatedEndDate.ToString()));
                tv.Nodes[0].Nodes[pIndex].Nodes[8].Nodes.Add(new TreeNode(tp.State.StateOfTheProject));
                tv.Nodes[0].Nodes[pIndex].Nodes[12].Nodes.Add(new TreeNode(tp.PType.type));

                tv.Nodes[0].Nodes[pIndex].Nodes[6].Nodes.Add(new TreeNode(tp.StartDate.ToString()));
                if (tp.EndDate != DateTime.MinValue)
                {
                    tv.Nodes[0].Nodes[pIndex].Nodes[7].Nodes.Add(new TreeNode(tp.EndDate.ToString()));
                }
                tv.Nodes[0].Nodes[pIndex].Nodes[9].Nodes.Add(new TreeNode(tp.MonetaryReturn.ToString()));
                tv.Nodes[0].Nodes[pIndex].Nodes[9].Nodes.Add(new TreeNode(tp.MonetaryReturnType));
                if (tp.ProjectEmpList != null)
                {
                    foreach (Employee emp in tp.ProjectEmpList)
                    {
                        tv.Nodes[0].Nodes[pIndex].Nodes[10].Nodes.Add(new TreeNode(emp.ToString()));
                    }
                }
                if (tp.ProjectDocuments != null)
                {
                    foreach(string s in tp.ProjectDocuments)
                    {
                        tv.Nodes[0].Nodes[pIndex].Nodes[11].Nodes.Add(new TreeNode(s));
                    }
                }
                if (tp.MileStoneList != null)
                {
                    for(int i = 0; i < tp.MileStoneList.Count; i++)
                    {
                        MileStone ms = tp.MileStoneList[i] as MileStone;
                        tv.Nodes[0].Nodes[pIndex].Nodes[13].Nodes.Add(new TreeNode(ms.MStoneName));
                        if (ms.TaskList != null)
                        {
                            foreach(Dictionary<string, int> task in ms.TaskList)
                            {
                                tv.Nodes[0].Nodes[pIndex].Nodes[13].Nodes[i].Nodes.Add(new TreeNode(task.ElementAt(0).Key));
                            }
                        }
                    }
                }
            }
            else
            {
                tv.Nodes[0].Nodes.Add(new TreeNode(tp.ProjectName));
                tv.Nodes[0].BackColor = Color.Yellow;
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project No: " + tp.ProjectNo)); // Node  0
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Manager")); // Node  1
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Description")); // Node 2
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Registration Date")); // Node  3
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Est. Start Date")); // Node 4
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Est. End Date")); // Node  5
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Start Date")); // Node 6
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project End Date")); // Node 7
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project State")); // Node 8
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Monetary Return")); // Node 9
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Team")); // Node 10
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Documentations")); // Node  11
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Type")); // Node 12
                tv.Nodes[0].Nodes[pIndex].Nodes.Add(new TreeNode("Project Milestones and Tasks")); // Node  13

                tv.Nodes[0].Nodes[pIndex].Nodes[1].Nodes.Add(new TreeNode(tp.Manager.Name + " " + tp.Manager.LastName));
                tv.Nodes[0].Nodes[pIndex].Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Username: " + tp.Manager.Username));
                tv.Nodes[0].Nodes[pIndex].Nodes[2].Nodes.Add(new TreeNode(tp.Description));
                tv.Nodes[0].Nodes[pIndex].Nodes[3].Nodes.Add(new TreeNode(tp.RegDate.ToString()));
                tv.Nodes[0].Nodes[pIndex].Nodes[4].Nodes.Add(new TreeNode(tp.EstimatedStartDate.ToString()));
                tv.Nodes[0].Nodes[pIndex].Nodes[5].Nodes.Add(new TreeNode(tp.EstimatedEndDate.ToString()));
                tv.Nodes[0].Nodes[pIndex].Nodes[8].Nodes.Add(new TreeNode(tp.State.StateOfTheProject));
                tv.Nodes[0].Nodes[pIndex].Nodes[12].Nodes.Add(new TreeNode(tp.PType.type));
            }
        }

        private void changeManager_Click(object sender, EventArgs e)
        {
            foreach(Project p in projectList)
            {
                if (adminPanelTree.SelectedNode == null)
                {
                    break;
                }
                if (adminPanelTree.SelectedNode.Text == p.ProjectName)
                {
                    cProject = p;
                    cProjectNode = adminPanelTree.SelectedNode.Index;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (cProject != null)
            {
                changeManagerBox.Visible = true;
                saveManager.Visible = true;

                foreach(Employee empx in employeeList)
                {
                    changeManagerBox.Items.Add(empx.Username);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid project.");
            }
        }

        private void saveManager_Click(object sender, EventArgs e)
        {
            foreach(Employee emps in employeeList)
            {
                if (emps.Username == changeManagerBox.SelectedItem.ToString())
                {
                    emps.IsManager = true;
                    cProject.Manager.IsManager = false;
                    cProject.Manager = emps;
                    if (cProject.ProjectEmpList.Contains(emps))
                    {
                        cProject.ProjectEmpList.Remove(emps);
                    }
                }
            }
            adminPanelTree.Nodes[0].Nodes.Clear();
            for (int i = 0; i < projectList.Count; i++)
            {
                Project pt = projectList[i] as Project;
                ProjectTree(adminPanelTree, pt, i);
            }
            cProject = null;
            cProjectNode = -1;
            changeManagerBox.Items.Clear();
            saveManager.Visible = false;
            changeManagerBox.Visible = false;
        }
        
        private void ClearCreateProject()
        {
            projectName.Text = "";
            projectNo.Value = 0;
            description.Text = "";
            managerBox1.SelectedItem = null;
            projectTypeBox.SelectedItem = null;
            registerDate.Value = DateTime.Now;
            estFinishDate.Value = DateTime.Now;
            estStartDate.Value = DateTime.Now;
        }

        private void adminPanelTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
