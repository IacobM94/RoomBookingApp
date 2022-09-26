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
                new Room{RoomName="101", Capacity=2, Floor="Ground Floor"},
                new Room{RoomName="102",Capacity=50,Floor="Ground Floor"},
                new Room{RoomName="N1",Capacity=50,Floor="Basement"},
                new Room{RoomName="N2",Capacity=50,Floor="Basement"},
                new Room{RoomName="N3",Capacity=50,Floor="Ground Floor"},
                new Room{RoomName="E1.1",Capacity=50,Floor="1st Floor"},
                new Room{RoomName="E2.1",Capacity=50,Floor="2nd Floor"},
                new Room{RoomName="E2.2",Capacity=50,Floor="2nd Floor"}
            };
            context.Rooms.AddRange(Rooms);
            context.SaveChanges();
        }
    }
}