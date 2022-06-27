using Microsoft.EntityFrameworkCore;

namespace HotelListingV2.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Malaysia",
                    ShortName = "MY"
                },
                new Country
                {
                    Id = 2,
                    Name = "Bangladesh",
                    ShortName = "BD"
                },
                new Country
                {
                    Id = 3,
                    Name = "Singapore",
                    ShortName = "SG"
                }
           );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id=1,
                    Name= "The Ritz-Carlton",
                    Address = "Kuala Lumpur",
                    CountryId=1,
                    Rating=5.6
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Pan Pacific Sonargaon",
                    Address = "Dhaka",
                    CountryId = 2,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Marina Bay Sands",
                    Address = "Singapore",
                    CountryId = 3,
                    Rating = 6.6
                }
                );
        }
    }
}