using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Message
    {
        public static void Greetings()
        {
            Console.WriteLine("Welcome!\n");
        }
        public static void LoginMessage()
        {
            Console.WriteLine("Login Successful!\n");
        }
        public static void ErrorMessage(string fieldName) 
        {
            Console.WriteLine(fieldName + " can not be null!\n");
        }
        public static void ErrorPackage()
        {
            Console.WriteLine("Please write s, g or p\n");
        }
    }
}
