using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookingSite.Data;
using BookingSite.Models;

namespace BookingSite.Views.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly BookingSite.Data.BookingSiteContext _context;

        public IndexModel(BookingSite.Data.BookingSiteContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Booking = await _context.Booking.ToListAsync();
        }
    }
}
