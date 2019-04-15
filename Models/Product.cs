using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstEFApp.Models
{
    public class Product
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public string Code { get; set;}
        public double Price { get; set;}
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        
    }
}