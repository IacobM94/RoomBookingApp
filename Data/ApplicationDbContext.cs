using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RoomBookingApp.Models;

namespace RoomBookingApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RoomBookingApp.Models.Room> Room { get; set; }
        public DbSet<RoomBookingApp.Models.Booking> Booking { get; set; }
    }
}
