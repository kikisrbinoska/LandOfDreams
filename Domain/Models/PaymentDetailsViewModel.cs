using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PaymentDetailsViewModel
    {
        public Reservation? Reservation { get; set; }
        public Payment? Payment { get; set; }
    }
}
