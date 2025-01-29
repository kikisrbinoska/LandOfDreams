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
    public class ApartmentService : IApartmentService
    {
        private readonly IRepository<Apartment> _apartmentRepository;

        public ApartmentService(IRepository<Apartment> apartmentRepository)
        {
            _apartmentRepository = apartmentRepository;
        }

        public Apartment DeleteApartment(Apartment entity)
        {
            return _apartmentRepository.Delete(entity);
        }

        public List<Apartment> GetAllApartments()
        {
            return _apartmentRepository.GetAll().ToList();
        }

        public Apartment GetApartment(int? id)
        {
            return _apartmentRepository.Get(id);
        }

        public Apartment InsertApartment(Apartment entity)
        {
            return _apartmentRepository.Insert(entity);
        }

        public List<Apartment> InsertManyApartment(List<Apartment> entities)
        {
            return _apartmentRepository.InsertMany(entities);
        }

        public Apartment UpdateApartment(Apartment entity)
        {
           return _apartmentRepository.Update(entity);
        }
    }
}
