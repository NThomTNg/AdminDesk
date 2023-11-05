﻿using AdminDesk.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdminDesk.DataAccess
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Dyr>().ToTable("Dyr").HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder);
        }

        
        public DbSet<Dyr> Dyr { get; set; }
    }
}
