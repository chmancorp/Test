using BinnacleService.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinnacleService.Data.DataAccess
{
    public class BinnacleDbContext : DbContext
    {
        private DbSet<EntityTest> _entityTest;

        public BinnacleDbContext(DbContextOptions<BinnacleDbContext> options) : base(options) { }

        public DbSet<EntityTest> EntityTest { get => _entityTest; set => _entityTest = value; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityTest>().ToTable("EntityDemo");
        }
    }
}
