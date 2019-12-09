﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class CrmContext : DbContext
    {
        public CrmContext() : base("DConnection") { }
        public DbSet<Check> Checks { get; set; }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
