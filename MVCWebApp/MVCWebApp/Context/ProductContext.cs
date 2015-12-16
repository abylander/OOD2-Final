using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCWebApp.Models;

namespace MVCWebApp.Context
{
    public class ProductContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}