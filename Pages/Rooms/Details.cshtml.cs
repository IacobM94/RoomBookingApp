using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RoomBookingApp.Data;
using RoomBookingApp.Models;

namespace RoomBookingApp.Pages.Rooms
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly RoomBookingApp.Data.ApplicationDbContext _context;

        public DetailsModel(RoomBookingApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Room Room { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Room = await _context.Room.FirstOrDefaultAsync(m => m.RoomNumber == id);

            if (Room == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
