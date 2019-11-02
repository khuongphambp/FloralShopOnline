﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FloralShop.Entity
{
    public class FloralShopDbContext : DbContext
    {
        public DbSet<TypeProduct> TypeProducts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=FloralShopDB1;Trusted_Connection=True;");
        }
    }
}
