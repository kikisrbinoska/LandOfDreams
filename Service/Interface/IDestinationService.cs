using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IDestinationService
    {
        List<Destination> GetAllDestinations();
        Destination GetDestination(int? id);
        Destination InsertDestination(Destination entity);
        List<Destination> InsertManyDestinations(List<Destination> entities);
        Destination UpdateDestination(Destination entity);
        Destination DeleteDestination(Destination entity);
    }
}
