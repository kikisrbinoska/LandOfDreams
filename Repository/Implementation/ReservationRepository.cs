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
    public class ReservationRepository : IReservationRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<Reservation> _entities;

        public ReservationRepository(ApplicationDbContext context)
        {
            _context = context;
            _entities = context.Set<Reservation>();
        }

        public List<Reservation> GetAllReservations()
        {
            return _entities
                .Include(z => z.TotalCost)
                .Include(z => z.TravelEndDate)
                .Include(z => z.NumberOfPeople)
                .Include(z => z.PhoneNumberPrefix)
                .Include(z => z.NumberOfPeople)
                .Include(z => z.BookingDate)
                .Include(z => z.Bookings)
                .Include (z => z.FirstName)
                .Include(z => z.LastName)
                .Include(z => z.Email)
                .Include(z => z.PhoneNumber)
                .ToList();

        }

        public Reservation GetDetailsForReservation(int id)
        {
            return _entities
                .Include(z => z.Bookings)  
                .SingleOrDefault(z => z.Id == id); 
        }

    }
}
