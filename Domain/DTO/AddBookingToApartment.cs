using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class AddBookingToApartment
    {
        public DateTime? BookingDate { get; set; } = DateTime.Now.Date;
        public DateTime? TravelEndDate { get; set; }
        public int? NumberOfPeople { get; set; }
        public double? TotalCost { get; set; }
        public Booking Bookings { get; set; }
        public int ApartmentId { get; set; }
    }
}
