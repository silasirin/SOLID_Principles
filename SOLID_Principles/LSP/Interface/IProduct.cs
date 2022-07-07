using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Interface
{
    //Urunler adinda bir base classimiz var. Bu base'in ozellikleri:
    public interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
        int Stock { get; set; } 
    }
}
