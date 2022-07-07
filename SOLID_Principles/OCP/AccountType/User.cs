using OCP.Generate;
using OCP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    //User'in base ozelliklerini interface'ten kalitim aldirirken, Admin olup olmadigini kontrol edebilmek icin bool tipinde bir parametre olusturuyoruz.
    public class User : IUser
    {
        public User()
        {
            GenerateAccount = new UserAccount();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public IAccount GenerateAccount { get; set; }
        public bool IsAdmin { get; set; }
    }
}
