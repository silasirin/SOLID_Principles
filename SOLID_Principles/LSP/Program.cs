using LSP.Entity;
using LSP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electronic electronic = new Electronic();
            electronic.Name = "TV";
            electronic.Price = 4322;

            Computer computer = new Computer();
            computer.Name = "PC";
            computer.Price = 10000;

            Product product = new Electronic();
            product.Name = "Computer";
            product.Price = 23000;

            BaseProduct baseProduct = new Computer(); //Nesneler, program calisirken sorun yaratmadan kendi alt ozellikleriyle degistirilebilir olmustur. Bu durumda Liskov Substitution Prensibine uymaktadir.
            baseProduct.Name = "";
            baseProduct.Price = 0;

            Console.Read();
        }
    }
}
