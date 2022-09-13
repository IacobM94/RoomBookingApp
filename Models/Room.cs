using System.ComponentModel.DataAnnotations;
using System;

namespace RoomBookingApp.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        [Display(Name = "Room Name")]
        public string RoomName { get; set; }
        [Display(Name = "Capacity")]
        public int Capacity { get; set; }
        [Display(Name = "Floor")]
        public string Floor { get; set; }
    }
}
