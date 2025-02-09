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
        private readonly IReservationRepository _repository;
        private readonly IRepository<Reservation> _reservationsRepository;

        public ReservationService(IReservationRepository repository, IRepository<Reservation> reservationsRepository)
        {
            _repository = repository;
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

        public Reservation GetDetailsForReservation(int id)
        {
            return _repository.GetDetailsForReservation(id);
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
