using RoomBookingApp.Data;
using RoomBookingApp.Models;
using System;
using System.Linq;
using System.Net.Mime;

namespace RoomBookingApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
          context.Database.EnsureCreated();
            // Look for any Rooms.
            if (context.Rooms.Any())
            {
                return;   // DB has been seeded
            }

            var Rooms = new Room[]
            {
                new Room{RoomName="North Room",Capacity=20,Floor="Basement"},
                new Room{RoomName="North Room",Capacity=4, Floor="Ground Floor"},
                new Room{RoomName="North Room",Capacity=20, Floor="1st Floor"},
                new Room{RoomName="North Room",Capacity=12, Floor="2nd Floor"},
                new Room{RoomName="North Room",Capacity=40, Floor="3rd Floor"},
                new Room{RoomName="North Room",Capacity=6, Floor="4th Floor"},
                new Room{RoomName="East Room",Capacity=20,Floor="Basement Floor"},
                new Room{RoomName="East Room",Capacity=50,Floor="Ground Floor"},
                new Room{RoomName="East Room",Capacity=10,Floor="1st Floor"},
                new Room{RoomName="East Room",Capacity=6,Floor="2nd Floor"},
                new Room{RoomName="East Room",Capacity=12,Floor="3rd Floor"},
                new Room{RoomName="East Room",Capacity=18,Floor="4th Floor"},
                new Room{RoomName="South Room",Capacity=20,Floor="Basement"},
                new Room{RoomName="South Room",Capacity=30,Floor="Ground Floor"},
                new Room{RoomName="South Room",Capacity=10,Floor="1st Floor"},
                new Room{RoomName="South Room",Capacity=4,Floor="2nd Floor"},
                new Room{RoomName="South Room",Capacity=14,Floor="3rd Floor"},
                new Room{RoomName="South Room",Capacity=16,Floor="4th Floor"},
                new Room{RoomName="West Room",Capacity=6,Floor="Basement"},
                new Room{RoomName="West Room",Capacity=10,Floor="Ground Floor"},
                new Room{RoomName="West Room",Capacity=8,Floor="1st Floor"},
                new Room{RoomName="West Room",Capacity=12,Floor="2nd Floor"},
                new Room{RoomName="West Room",Capacity=40,Floor="3rd Floor"},
                new Room{RoomName="West Room",Capacity=100,Floor="4th Floor"},


            };
            context.Rooms.AddRange(Rooms);
            context.SaveChanges();

            var bookings = new Booking[]
{
                
                new Booking{UserID="2", RoomNumber=2,Date=DateTime.Parse("01-10-2022 00:00:00"),StartTime="10:25",EndTime="18:45",AllDayBooking=true, Subject="Planning & Housing - Meet and greet"},
                new Booking{UserID="3", RoomNumber=5,Date=DateTime.Parse("03-10-2022 00:00:00"),StartTime="12:45",EndTime="13:45",AllDayBooking=false, Subject="IT Meeting - Buying brand new Macbooks"},
                new Booking{UserID="2", RoomNumber=5,Date=DateTime.Parse("11-10-2022 00:00:00"),StartTime="08:45",EndTime="16:45",AllDayBooking=true, Subject="Web Applications Class 2022"},
                new Booking{UserID="3", RoomNumber=12,Date=DateTime.Parse("10-10-2022 00:00:00"),StartTime="18:26",EndTime="19:45",AllDayBooking=false, Subject="HR Meeting - Missing Money"},
                new Booking{UserID="2", RoomNumber=9,Date=DateTime.Parse("05-10-2022 00:00:00"),StartTime="09:30",EndTime="15:15",AllDayBooking=false, Subject="Finance Meeting - Where has the money gone"},
                new Booking{UserID="3", RoomNumber=1,Date=DateTime.Parse("13-10-2022 00:00:00"),StartTime="06:00",EndTime="23:00",AllDayBooking=true, Subject="Directors quick chat"},
                new Booking{UserID="2", RoomNumber=8,Date=DateTime.Parse("15-11-2022 00:00:00"),StartTime="18:30",EndTime="19:00",AllDayBooking=false, Subject="Public Presentation"},

};

            context.Bookings.AddRange(bookings);
            context.SaveChanges();

        }
    }
}