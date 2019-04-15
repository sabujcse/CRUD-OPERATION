using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstEFApp.Models;
using System.Data.SqlClient;
using System.Data.Entity;

namespace FirstEFApp.DataBaseContext
{
    public class ShopContextDB:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}