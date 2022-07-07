using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    //Disardan girilen kitap verisiyle, kitap olusturuluyor. Console'da gosterimi saglaniyor. 
    public class BookRepository
    {
        public static Book AddBooks()
        {
            Book book = new Book();
            Console.WriteLine("Please type the book name.");
            book.BookName = Console.ReadLine();
            Console.WriteLine("Please type the writer's name.");
            book.Writer = Console.ReadLine();
            Console.WriteLine("Please type the number of pages");
            book.Page = Console.ReadLine();
            return book;
            

        }
    }
}
