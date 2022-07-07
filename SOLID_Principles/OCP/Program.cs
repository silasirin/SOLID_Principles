using OCP.AccountType;
using OCP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IUser> users = new List<IUser>()
            {
                new Admin{FirstName ="Mahmure",LastName="Okan"},
                new User{FirstName="Sila",LastName="Sirin"}
            };

            List<User> userList = new List<User>();

            foreach (var person in users)
            {
                userList.Add(person.GenerateAccount.Create(person));
            }

            foreach (var user in userList)
            {
                Console.WriteLine($"Ad: {user.FirstName} Soyad: {user.LastName} Email: {user.Email} Admin: {user.IsAdmin}");
            }
            Console.Read();
        }
    }
}
