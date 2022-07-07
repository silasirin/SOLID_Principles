using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Category: BaseEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        //Bir kategoride birden fazla urun vardir.
        public List<Product> Products { get; set; }

    }
}
