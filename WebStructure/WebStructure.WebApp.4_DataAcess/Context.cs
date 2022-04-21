using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStructure.Common.Models;
using WebStructure.WebApp._4_DataAcess.Entity;
using WebStructure.WebApp._4_DataAcess.EntityConfiguration;

namespace WebStructure.WebApp._4_DataAcess
{
    public class Context : DbContext
        {
            public DbSet<CarEntity>? CarDbSet { get; set; }

            public Context(DbContextOptions options) : base(options)
            {
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new CarConfiguration());
            }
        }
    
}
