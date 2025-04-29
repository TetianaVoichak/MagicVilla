//using MagicVilla_VillaAPI.Migrations;
using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {

        }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Sed ut perspiciatis, quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est, sunt in culpa qui officia deserunt mollit anim id est laborum!",
                    ImageUrl = "",
                    Occupancy=5,
                    Rate=200,
                    Sqft=550,
                    Amenity="",
                    //CreatedDate= DateTime.Now,
                    CreatedDate = new DateTime(2023, 01, 01)
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Premium Pool Villa",
                    Details = "Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet, qui blanditiis praesentium voluptatum deleniti atque corrupti, quos dolores et quas molestias excepturi sint, qui dolorem eum fugiat, quo voluptas nulla pariatur.",
                    ImageUrl = "",
                    Occupancy = 4,
                    Rate = 300,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = new DateTime(2023, 01, 01)
                },
                new Villa()
                {

                    Id = 3,
                    Name = "Luxury Pool Villa",
                    Details = "Sed ut perspiciatis, quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est, sunt in culpa qui officia deserunt mollit anim id est laborum!",
                    ImageUrl = "",
                    Occupancy = 4,
                    Rate = 300,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = new DateTime(2023, 01, 01)
                },
                new Villa()
                {

                    Id = 4,
                    Name = "Diamond Villa",
                    Details = "Et harum quidem rerum facilis est et expedita distinctio, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ImageUrl = "",
                    Occupancy = 4,
                    Rate = 550,
                    Sqft = 900,
                    Amenity = "",
                    CreatedDate = new DateTime(2023, 01, 01)
                },
                new Villa()
                 {

                     Id = 5,
                     Name = "Diamond Pool Villa",
                     Details = "Excepteur sint occaecat cupidatat non proident, consectetur adipiscing elit, quae ab.",
                     ImageUrl = "",
                     Occupancy = 4,
                     Rate = 660,
                     Sqft = 1100,
                     Amenity = "",
                    CreatedDate = new DateTime(2023, 01, 01)
                }
            );

        }
        
    }
}
