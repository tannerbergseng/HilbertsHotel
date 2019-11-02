using HilbertsHotel.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace HilbertsHotel
{
    public class HotelContext : DbContext
    {
        public HotelContext()
            : base("name=HotelContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
    }
}