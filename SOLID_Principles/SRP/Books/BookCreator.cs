using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    //Disardan girilen kitap bilgisinin okundugu bir method. Boylece kitap ekleme methodu ve eklenen kitabi gorme methodu birbirinden ayri oluyor. Her class ve method tek bir amac icin kullaniliyor.
    public class BookCreator
    {
        public static void Create(Book book)
        {
            Console.WriteLine("Book Name: "+ book.BookName + "\nWriter: " + book.Writer + "\nNumber of Page:" + book.Page);
        }
    }
}
