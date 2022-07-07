using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class User: IComment
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public void AddComment(string comment)
        {
           Console.WriteLine("User Name: "+ UserName + "\nComment: " + comment +"\n**************************");
        }
        public User Admin { get; set; }
    }
}
