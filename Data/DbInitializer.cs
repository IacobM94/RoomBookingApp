using RoomBookingApp.Data;
using RoomBookingApp.Models;
using System;
using System.Linq;

namespace RoomBookingApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Look for any Rooms.
            if (context.Room.Any())
            {
                return;   // DB has been seeded
            }

            var Rooms = new Room[]
            {
                new Room{RoomNumber=1,RoomName="East Wing",Capacity=50,Floor="Basement"},
                new Room{RoomNumber=2,RoomName="North Wing",Capacity=50,Floor="Basement"},
                new Room{RoomNumber=3,RoomName="West Wing",Capacity=50,Floor="Basement"},
                new Room{RoomNumber=4,RoomName="South Wing",Capacity=50,Floor="Basement"},
                new Room{RoomNumber=5,RoomName="East Wing",Capacity=50,Floor="Ground Floor"},
                new Room{RoomNumber=6,RoomName="North Wing",Capacity=50,Floor="1st Floor"},
                new Room{RoomNumber=7,RoomName="West Wing",Capacity=50,Floor="2nd Floor"},
                new Room{RoomNumber=8,RoomName="South Wing",Capacity=50,Floor="3rd FLoor"},
            };

            context.Room.AddRange(Rooms);
            context.SaveChanges();
        }
    }
}