using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookingSite.Models;

namespace BookingSite.Data
{
    public class BookingSiteContext : DbContext
    {
        public BookingSiteContext (DbContextOptions<BookingSiteContext> options)
            : base(options)
        {
        }

        public DbSet<BookingSite.Models.Booking> Booking { get; set; } = default!;
    }
}
