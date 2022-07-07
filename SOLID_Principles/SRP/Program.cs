using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Karsilama
            Message.Greetings();

            //Bilgilendirme
            User user = UserRepository.Login();

            //Dogrulama
            bool isValid = UserValidator.Validator(user);

            if (!isValid)
            {
                
                Console.Read();
                return;
            }
            else
            {
                Message.LoginMessage();
            }

            //Paket Secimi
            UserPackages.UserPackage();
            Console.Read();
            


            #region Books
            ////Ayri ayri tanimlanan tum methodlarin cagirilmasi

            //    //Karsilama
            //    Message2.Greetings();

            //    //Bilgilerin girilmesi
            //    Book book = BookRepository.AddBooks();

            //    //Kaydetme
            //    BookCreator.Create(book);
            //    Console.Read();

            #endregion
        }
    }
}
