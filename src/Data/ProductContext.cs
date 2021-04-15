using ContosoCrafts.WebSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCrafts.WebSite.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> ProductTable { get; set; }
    }
}
