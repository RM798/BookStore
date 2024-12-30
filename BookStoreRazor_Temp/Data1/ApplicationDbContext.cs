using BookStoreRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreRazor_Temp.Data1
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> CategoryRecordRazor{ get; set; }

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
