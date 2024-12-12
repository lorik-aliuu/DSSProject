using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Premium Pool Villa",
                    Description = "A lavish villa with a private pool, lush views, and unmatched elegance",
                    imageUrl = "",
                    Occupancy = 4,
                    SquareFoot = 470,
                },
                new Villa
                {
                    Id = 2,
                    Name = "Azure Heaven",
                    Description = "A tranquil escape with endless blue skies and a shimmering private pool",
                    imageUrl = "",
                    Occupancy = 6,
                    SquareFoot = 520,
                }
            );
        }
    }
}