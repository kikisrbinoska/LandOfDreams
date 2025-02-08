using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Review : BaseEntity
    {
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required]
        public int Rating { get; set; }
        public int? ApartmentId { get; set; } 
        public virtual Apartment? Apartment { get; set; }
        public int? HotelId { get; set; } 
        public virtual Hotel? Hotel { get; set; }
    }
}
