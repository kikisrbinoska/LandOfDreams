using Domain.Models;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IReservationRepository
    {
        List<Reservation> GetAllReservations();
        Reservation GetDetailsForReservation(int id);
    }
}
