using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_WF_TEST.windows;

namespace DB_WF_TEST.modules
{
    class GenForms
    {
        public static void LoginWindow()
        {

        }
        public static void AdminWindow()
        {
            AdminWindow AdminWindow = new AdminWindow();
            AdminWindow.Show();
        }
        public static void MemberWindow()
        {
            MemberWindow MemberWindow = new MemberWindow();
            MemberWindow.Show();
        }

    }
}