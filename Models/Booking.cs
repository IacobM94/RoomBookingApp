using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace RoomBookingApp.Models
{
    public class Booking
    {
        public User User { get; set; }
        [Key]
        public int BookingID { get; set; }
        [ForeignKey("User")]
        public string UserID { get; set; }
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
        [Display(Name = "Start Time")]
        public string StartTime { get; set; }
        [Display(Name = "End Time")]
        public string EndTime { get; set; }
        [Display(Name = "All Day Booking")]
        public bool AllDayBooking { get; set; }
        [Display(Name = "Subject")]
        public string Subject { get; set; }
       
    }
}
