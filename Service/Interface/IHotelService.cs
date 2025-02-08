using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IHotelService
    {
        List<Hotel> GetAllHotels();
        Hotel GetHotel(int? id);
        Hotel InsertHotel(Hotel entity);
        List<Hotel> InsertManyHotels(List<Hotel> entities);
        Hotel UpdateHotel(Hotel entity);
        Hotel DeleteHotel(Hotel entity);
        List<Hotel> GetHotelsByDestination(int destinationId);
    }
}
