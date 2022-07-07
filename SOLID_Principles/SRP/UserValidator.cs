using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class UserValidator
    {
        //Kullanici adi ve sifre alaninin bos gecilemeyecegini belirten bir method:
        public static bool Validator(User user)
        {
            if (string.IsNullOrWhiteSpace(user.UserName))
            {
                Message.ErrorMessage("User Name");
                return false;
            }
            if(string.IsNullOrWhiteSpace(user.Password))
            {
                Message.ErrorMessage("Password");
                return false;
            }
            return true; //Kullanici adi ve sifre girildiginde true doner.
        }
    }
}
