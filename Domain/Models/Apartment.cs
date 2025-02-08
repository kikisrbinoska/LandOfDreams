using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Apartment : BaseEntity
    {
        public string Name { get; set; }
        public string? Location { get; set; }
        public int Price { get; set; }
        public string? Map { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public int DestinationId    { get; set; }
        public Destination Destination { get; set; }
        public virtual List<Review>? Reviews { get; set; }
        public virtual List<Booking>? Bookings { get; set; } 
    }
}
