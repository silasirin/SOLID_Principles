using OCP.Generate;
using OCP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.AccountType
{
    public class Admin : IUser
    {
        public Admin()
        {
            GenerateAccount = new AdminAccount();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public IAccount GenerateAccount { get; set; }
    }
}
