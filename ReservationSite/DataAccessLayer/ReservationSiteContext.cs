using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservationSite.Models;

namespace ReservationSite.DataAccessLayer
{
    public class ReservationSiteContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<AccomodationOwner> AccomodationOwners { get; set; }
        public DbSet<Accomodation> Accomodations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }


        public ReservationSiteContext(DbContextOptions<ReservationSiteContext> options) : base(options)
        {
        }
    }
}
