using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IApartmentService
    {
        List<Apartment> GetAllApartments();
        Apartment GetApartment(int? id);
        Apartment InsertApartment(Apartment entity);
        List<Apartment> InsertManyApartment(List<Apartment> entities);
        Apartment UpdateApartment(Apartment entity);
        Apartment DeleteApartment(Apartment entity);
        List<Apartment> GetApartmentsByDestination(int destinationId);
    }
}
