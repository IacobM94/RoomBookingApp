using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RoomBookingApp.Models;
using Microsoft.AspNetCore.Identity;

namespace RoomBookingApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RoomBookingApp.Models.Room> Rooms { get; set; }
        public DbSet<RoomBookingApp.Models.Booking> Bookings { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<IdentityRole>().HasData(new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = "ADMIN",
                    NormalizedName = "ADMIN" ,
                    Name = "ADMIN"
                },
            });
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "2",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "ADMIN@Outlook.com",
                    NormalizedEmail = "ADMIN@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    PasswordHash = hasher.HashPassword(null, "Password1!"),
                },
                new User
                {
                    Id = "3",
                    UserName = "TestUser",
                    NormalizedUserName = "TESTUSER",
                    Email = "TESTUSER@Outlook.com",
                    NormalizedEmail = "TESTUSER@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled =true,
                    AccessFailedCount = 0,
                    PasswordHash = hasher.HashPassword(null, "Password1!"),
                }
            );
                
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {

                    RoleId = "ADMIN",
                    UserId = "2",

                }
            );


        }



        }
}
