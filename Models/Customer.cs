using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstEFApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Code { get; set; }

        public string Address { get; set;}

        public string Email { get; set; }
    }
}