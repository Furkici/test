using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entity;



namespace DataAccess.Context
{
    public class MarketContext:DbContext
    {
        public MarketContext()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-IOIAUL56;Database=MarketDatabase;Trusted_Connection=True;";
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

    }
}
