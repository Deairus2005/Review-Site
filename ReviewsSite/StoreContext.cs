using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb; Database=UniversityDB_062021; Trusted_Connection=True";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product(1, "Hand Soap", "handSoap.png", "Personal Hygiene"),
                new Product(2, "Deodorant", "deodorant.png", "Personal Hygiene"),
                new Product(3, "Shampoo", "shampoo.png", "Health Beauty"),
                new Product(4, "Facial Cleanser", "facialCleanser.png", "Health Beauty"),
                new Product(5, "Cotton Swabs", "cottonSwabs.png", "Personal Hygiene")
                );
            modelBuilder.Entity<Review>().HasData(
               new Review(1, 1, "Hand Soap", "Gentle on the hands and smells pretty!",3 ),
               new Review(2, 2, "Deodorant", "Left me stanky and moist!  Terrible.", 3),
               new Review(3, 3, "Shampoo", "Gentle on the hands and smells pretty!", 3),
               new Review(4, 4, "Facial Cleanser", "Left me stanky and moist!  Terrible.", 3),
               new Review(5, 5, "Cotton Swabs", "Gentle on the hands and smells pretty!", 3)
             );
        }
        
    }
}
