using OCP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Generate
{
    public class UserAccount: IAccount
    {
        //User olusturma methodu:
        public User Create(IUser account)
        {
            User user = new User();
            user.FirstName = account.FirstName;
            user.LastName = account.LastName;
            user.Email = account.FirstName.Substring(0, 1).ToLower() + account.LastName.ToLower() + "@odevimvar.com";
            user.IsAdmin = false;

            return user;
        }
    }
}
