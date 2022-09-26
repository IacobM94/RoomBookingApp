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

namespace RoomBookingApp.Pages.Bookings
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly RoomBookingApp.Data.ApplicationDbContext _context;

        public IndexModel(RoomBookingApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; }

        public async Task OnGetAsync()
        {
            Booking = await _context.Bookings.Include(p => p.User).Where(a => a.User.UserName == User.Identity.Name).ToListAsync();
        }
    }
}
