using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class UserPackages
    {
       public static void UserPackage()
        {
            
            User user = new User();
            Console.WriteLine("Select membership: Standard, Gold, Premium");
            Console.WriteLine("Please type the initial of the membership type.");
            string value = Console.ReadLine(); 

            if (value == "s")
            {
                user.IsStandard=true;
                Console.WriteLine("Membership: Standard\nHave Fun!");
            }
            else if (value =="g")
            {
                user.IsGold=true;
                Console.WriteLine("Membership: Gold\nHave Fun!");
            }
            else if (value =="p")
            {
                user.IsPremium=true;
                Console.WriteLine("Membership: Premium\nHave Fun!");
            }
            else
            {
                Message.ErrorPackage();
            }
            Console.Read();
        }
    }
}
