using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FloralShopOnline.Entity
{
    public class FloralShopDbcontext : DbContext
    {
        public DbSet<TypeProduct> TypeProducts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=FlowerShopDB;Trusted_Connection=True;");
        }
    }
}
