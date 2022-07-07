using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class UserRepository
    {
        //user tipinde kullanici girisi yapabilmek icin olusturulan method:
        public static User Login()
        {
            User user = new User();

            Console.WriteLine("User Name:\n");
            user.UserName = Console.ReadLine();

            Console.WriteLine("Password:\n");
            user.Password = Console.ReadLine();

            return user;
        }
    }
}
