using System.ComponentModel.DataAnnotations;
using System;

namespace RoomBookingApp.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public int UserID { get; set; }
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }
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
