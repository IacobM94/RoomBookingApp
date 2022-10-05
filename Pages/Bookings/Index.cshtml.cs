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

        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Booking> Booking { get;set; }

        public async Task OnGetAsync(string sortOrder)
        {
            
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Booking> bookingsIQ = from b in _context.Bookings select b;

            switch (sortOrder)
            {
                
                case "Date":
                    bookingsIQ = bookingsIQ.OrderBy(b => b.Date);
                    break;
                case "date_desc":
                    bookingsIQ = bookingsIQ.OrderByDescending(b => b.Date);
                    break;
                default:
                    bookingsIQ = bookingsIQ.OrderBy(b => b.Date);
                    break;
            }

            Booking = await _context.Bookings.Include(p => p.User).Where(a => a.User.UserName == User.Identity.Name).ToListAsync();
        }
    }
}
