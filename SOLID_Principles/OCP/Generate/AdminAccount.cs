using OCP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Generate
{
    //Admin tipinde bir kullanicimiz olsun. IAccount'tan kalitim aliyoruz ki create methodu ile kullanici olarak tanimlayabilelim.
    public class AdminAccount : IAccount
    {
        public User Create(IUser account)
        {
            User user = new User();
            user.FirstName = account.FirstName;
            user.LastName = account.LastName;
            user.Email = account.FirstName.Substring(0, 1).ToLower() + account.LastName.ToLower() + "@odevimvar.com";
            user.IsAdmin = true;
            return user;
        }
    }
}
