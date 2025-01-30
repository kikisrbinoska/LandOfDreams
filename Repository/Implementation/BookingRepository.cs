using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Booking> entities;

        public BookingRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.entities = context.Set<Booking>();
        }

        public List<Booking> GetAllBookings()
        {
            return entities.
                Include(z => z.Apartment)
                .Include(z => z.Destination)
                .Include(z => z.Hotel)
                .ToList();
        }

        public Booking GetDetailsForBooking(BaseEntity id)
        {
                return entities.
                Include(z => z.Apartment)
                .Include(z => z.Destination)
                .Include(z => z.Hotel)
                .SingleOrDefaultAsync(z => z.Id == id.Id)
                .Result;
        }
    }
}
