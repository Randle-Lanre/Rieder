using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RiederBackend.Entities;

namespace RiederBackend
{
    public class ApplicationDbContext :DbContext
    {

        public ApplicationDbContext([NotNullAttribute] DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Bicycle> Bicycles { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Seller> Sellers { get; set; }



    }
}
