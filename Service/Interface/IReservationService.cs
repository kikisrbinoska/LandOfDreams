using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IReservationService
    {
        List<Reservation> GetAllReservations();
        Reservation GetReservation(int? id);
        Reservation InsertReservation(Reservation entity);
        List<Reservation> InsertManyReservations(List<Reservation> entities);
        Reservation UpdateReservation(Reservation entity);
        Reservation DeleteReservation(Reservation entity);
    }
}
