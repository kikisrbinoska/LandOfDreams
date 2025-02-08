using Domain.Models;
using Repository.Implementation;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class HotelService : IHotelService
    {
        private readonly IRepository<Hotel> _hotelRepository;

        public HotelService(IRepository<Hotel> hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public Hotel DeleteHotel(Hotel entity)
        {
           return _hotelRepository.Delete(entity);
        }

        public List<Hotel> GetAllHotels()
        {
           return _hotelRepository.GetAll().ToList();
        }

        public Hotel GetHotel(int? id)
        {
            return _hotelRepository.Get(id);
        }


        public Hotel InsertHotel(Hotel entity)
        {
            return _hotelRepository.Insert(entity);
        }

        public List<Hotel> InsertManyHotels(List<Hotel> entities)
        {
            return _hotelRepository.InsertMany(entities);
        }

        public Hotel UpdateHotel(Hotel entity)
        {
            return _hotelRepository.Update(entity);
        }

        public List<Hotel> GetHotelsByDestination(int destinationId)
        {
            return _hotelRepository.GetAll().Where(a => a.DestinationId == destinationId).ToList();

        }
    }
}
