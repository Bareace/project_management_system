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
    public partial class LoginPanel : Form
    {
        public static Employee currentUser = new Employee(); // Current user
        Employee empDef1 = new Employee("a", "a", "a", "a", true);
        Employee empDef2 = new Employee("Jesse", "Pink", "JessePink2", "PinkJesse2", false);
        Employee empDef3 = new Employee("Saul", "Good", "SaulGood3", "GoodSaul3", false);

        public LoginPanel()
        {
            InitializeComponent();
            AdminPanel.employeeList.Add(empDef1);
            AdminPanel.employeeList.Add(empDef2);
            AdminPanel.employeeList.Add(empDef3);
            AdminPanel.countList.Add(1);
            AdminPanel.countList.Add(1);
            AdminPanel.countList.Add(1);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "admin" && passwordBox.Text == "ttt") // admin girisi
            {
                FormProvider.APanel.Show();
                this.Hide();
            }
            else if (CheckUser(AdminPanel.employeeList, usernameBox.Text, passwordBox.Text))// Admin degilse ve employeeList de varsa
            {
                new EmployeeForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!!");
            }
            usernameBox.Text = "";
            passwordBox.Text = "";
            
        }
        
        // Checking the username and password.
        public bool CheckUser(List<object> list, string userN, string passW)
        {
            
            for (int i = 0; i < list.Count; i++)
            {
                Employee emp1 = list[i] as Employee;
                if ((emp1.Username == userN) && (emp1.Password == passW))
                {
                    currentUser = emp1;
                    return true;
                }
                else { continue; }
            }
            return false;
        }
    
    }
}
