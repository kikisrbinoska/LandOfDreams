using Domain.Models;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class BookingService : IBookingService
    {
        private readonly IRepository<Booking> _bookingRepository;

        public BookingService(IRepository<Booking> bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        public List<Booking> ApartmentBooking(int? id)
        {
            return _bookingRepository.GetAll().Where(z => z.ApartmentId == id).ToList();
        }

        public Booking DeleteBooking(Booking entity)
        {
            return _bookingRepository.Delete(entity);
        }

        public List<Booking> GetAllBookings()
        {
            return _bookingRepository.GetAll().ToList();
        }

        public Booking GetBooking(int? id)
        {
            return _bookingRepository.Get(id);
        }

        public Booking InsertBooking(Booking entity)
        {
            return _bookingRepository.Insert(entity);
        }

        public List<Booking> InsertManyBookings(List<Booking> entities)
        {
            return _bookingRepository.InsertMany(entities);
        }

        public Booking UpdateBooking(Booking entity)
        {
            return _bookingRepository.Update(entity);
        }
    }
}
