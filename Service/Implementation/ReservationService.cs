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
    public class ReservationService : IReservationService
    {
        private readonly IRepository<Reservation> _reservationsRepository;

        public ReservationService(IRepository<Reservation> reservationsRepository)
        {
            _reservationsRepository = reservationsRepository;
        }

        public Reservation DeleteReservation(Reservation entity)
        {
            return _reservationsRepository.Delete(entity);
        }

        public List<Reservation> GetAllReservations()
        {
            return _reservationsRepository.GetAll().ToList();
        }

        public Reservation GetReservation(int? id)
        {
            return _reservationsRepository.Get(id);
        }

        public List<Reservation> InsertManyReservations(List<Reservation> entities)
        {
            return _reservationsRepository.InsertMany(entities);
        }

        public Reservation InsertReservation(Reservation entity)
        {
            return _reservationsRepository.Insert(entity);
        }

        public Reservation UpdateReservation(Reservation entity)
        {
            return _reservationsRepository.Update(entity);
        }
    }
}
