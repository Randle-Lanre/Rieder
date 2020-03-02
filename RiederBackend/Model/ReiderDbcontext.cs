using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RiederBackend.Model
{
    public class ReiderDbcontext : DbContext
    {
        public ReiderDbcontext(DbContextOptions<ReiderDbcontext> options): base (options)
        {
            
        }

        public DbSet<bicycle> Bicycles { get; set; }

        
    }
}
