﻿using Microsoft.EntityFrameworkCore;
using Restaurants.Domain.Entities;

namespace Restaurants.Infrastructure.Persistence
{
    internal class RestaurantsDbContext : DbContext
    {
        internal DbSet<Restaurant> Restaurants { get; set; }
        internal DbSet<Dish> Dishes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RestaurantsDb;Trusted_Connection=True;");
        }
    }
}
