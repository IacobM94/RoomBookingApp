using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RoomBookingApp.Models
{
    public class User : IdentityUser
    {
        public List<Booking> Bookings { get; set; }
    }
}
