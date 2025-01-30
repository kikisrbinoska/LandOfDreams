using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IBookingService
    {
        List<Booking> GetAllBookings();
        Booking GetBooking(int? id);
        Booking InsertBooking(Booking entity);
        List<Booking> InsertManyBookings(List<Booking> entities);
        Booking UpdateBooking(Booking entity);
        Booking DeleteBooking(Booking entity);
        public List<Booking> ApartmentBooking(int? id);
    }
}
