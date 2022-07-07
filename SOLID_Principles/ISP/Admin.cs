using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Admin : User, IManaged
    {
        public void AddUser(User user)
        {
            Console.WriteLine(user.UserName + " adli kullanici eklendi.\nMevcut sifre: "+ user.Password + "\n**************************");
        }

        public void RemoveUser(User user)
        {
            Console.WriteLine(user.UserName + " adli kullanici silindi.\n**************************");
        }
    }
}
