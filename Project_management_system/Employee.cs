using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_management_system
{
    public class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsManager { get; set; }

        public Employee(string Name, string LastName, string Username, string Password, bool IsManager)
        {
            this.Name = Name; this.LastName = LastName; this.Username = Username; this.Password = Password; this.IsManager = IsManager;
        }
        public Employee()
        { }
        public override string ToString()
        {
            return this.Username;
        }
        
    }
}
