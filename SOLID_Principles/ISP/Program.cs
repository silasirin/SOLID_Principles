using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.UserName = "Mahmus";
            user.Password = "123asd";
            user.AddComment("haha cok guzel foto");

            User user1 = new User();
            user1.UserName = "DeliCocuk";
            user1.Password = "123as213";
            user1.AddComment("cok cirkin cikmissin");

            User user2 = new User();
            user2.UserName = "BenimAdimAylin";
            user2.Password = "Aylin456";

            Admin admin = new Admin();
            admin.UserName = "Silaylay";
            admin.Password = "sila123as";
            admin.AddUser(user2);
            admin.RemoveUser(user1);

            Console.WriteLine();

            Console.Read();
        }
    }
}
