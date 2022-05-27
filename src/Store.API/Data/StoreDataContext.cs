using Microsoft.EntityFrameworkCore;
using Store.API.Data.Maps;
using Store.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.API.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "StoreDBTest");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductMap());            
        }
    }
}
