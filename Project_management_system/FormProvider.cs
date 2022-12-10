using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_management_system
{
    class FormProvider
    {
        public static LoginPanel LPanel
        {
            get
            {
                if (loginPanel == null)
                {
                    loginPanel = new LoginPanel();
                }
                return loginPanel;
            }
        }
        private static LoginPanel loginPanel;


        public static AdminPanel APanel
        {
            get
            {
                if (adminPanel == null)
                {
                    adminPanel = new AdminPanel();
                }
                return adminPanel;
            }
        }
        private static AdminPanel adminPanel;
    }   
}
