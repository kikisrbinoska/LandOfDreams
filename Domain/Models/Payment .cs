using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Payment : BaseEntity
    {
        [Required]
        [StringLength(16, MinimumLength = 13, ErrorMessage = "Card number must be between 13 and 16 digits.")]
        public string CardNumber { get; set; }

        [Required]
        public string CardholderName { get; set; }

        [Required]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Expiration date must be in MM/YY format.")]
        public string ExpirationDate { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "CVV must be 3 digits.")]
        public string CVV { get; set; }

        [Required]
        public string PhoneNumberPrefix { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public double Amount { get; set; }
    }
}
