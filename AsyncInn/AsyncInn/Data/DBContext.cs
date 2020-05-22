using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;

namespace AsyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {

        public AsyncInnDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(new Models.Hotel
            {
                ID = 1,
                HotelName = "Francesco Inn",
                StreetAddress = "123 Hemmingway Ln",
                City = "Washington",
                State = "Washington",
                Country = "United States",
            });

            modelBuilder.Entity<HotelRoom>().HasKey(HotelRoom => new
            {
                HotelRoom.HotelId,
                HotelRoom.RoomNumber
            });

            
        }

        public DbSet<Hotel> Hotel { get; set; }

        public DbSet<HotelRoom> HotelRoom { get; set; }

        public DbSet<Room> Room { get; set; }

        //public DbSet<Amenities> Amenities { get; set; }
    }
}
