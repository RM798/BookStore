﻿using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> CategoryRecord { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Category>().HasData(
        //            new Category { Id=1, Name="Action", DisplayOrder = 1},
        //            new Category { Id=2, Name="Scifi", DisplayOrder=2},
        //            new Category { Id=3, Name="History", DisplayOrder=4}
        //        );
        //}
    }
}
