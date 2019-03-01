using Microsoft.EntityFrameworkCore;
using MvcVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcVirtualPets
{
    public class PetContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=AAWCCIVPAPets;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>().HasData(
                new Pet() { PetId = 1, Name = "Roscoe", Description ="Big dog."},
                new Pet() { PetId = 2, Name = "Biggs", Description = "Really big dog."},
                new Pet() { PetId = 3, Name = "Bella", Description = "Tiny dog." }
                );
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
