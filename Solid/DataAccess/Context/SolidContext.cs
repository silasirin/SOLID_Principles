using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class SolidContext: DbContext
    {
        public SolidContext()
        {
            Database.Connection.ConnectionString = "server=localhost\\SQLEXPRESS;database=SolidHomeworkDb;Trusted_Connection=true";
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
