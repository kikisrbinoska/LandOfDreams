using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Destination : BaseEntity
    {
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public virtual List<Booking>? Bookings { get; set; }
    }
}
