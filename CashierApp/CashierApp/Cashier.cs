using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp
{
    public class Cashier : User
    {
        private string department;

        public Cashier(string name, string dept, string uName, string password) : base (name, uName, password) 
        {
            this.department = dept;
        }

        public override bool validateLogin(string uName, string password)
        {
            uName = "admin";
            password = "admin";

            return user_name.Equals(uName) && user_password.Equals(password);

        }

        public string getDepartment()
        {
            return department = " It Department";

        }
    }
}
