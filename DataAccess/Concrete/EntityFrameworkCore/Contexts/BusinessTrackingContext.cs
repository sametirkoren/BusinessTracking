using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete.EntityFrameworkCore.Mapping;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class BusinessTrackingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=BusinessTracking; integrated security=true;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        public DbSet<Work> Works { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
