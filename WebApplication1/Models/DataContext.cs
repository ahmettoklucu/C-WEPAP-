using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("ProductManagementDb") { }

        public DbSet<Product> Product { get; set; }
    }
}