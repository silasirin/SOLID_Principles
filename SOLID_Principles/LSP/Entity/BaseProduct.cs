using LSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Entity
{
    public class BaseProduct : IProduct
    {
        //BaseProduct, Product'in ozelliklerini ve varsa tanimlanan methodlarini miras alir. 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
