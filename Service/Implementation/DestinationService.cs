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
    public class DestinationService : IDestinationService
    {
        private readonly IRepository<Destination> _destionationRepository;

        public DestinationService(IRepository<Destination> destionationRepository)
        {
            _destionationRepository = destionationRepository;
        }

        public Destination DeleteDestination(Destination entity)
        {
            return _destionationRepository.Delete(entity);
        }

        public List<Destination> GetAllDestinations()
        {
            return _destionationRepository.GetAll().ToList();
        }

        public Destination GetDestination(int? id)
        {
            return _destionationRepository.Get(id);
        }

        public Destination InsertDestination(Destination entity)
        {
            return _destionationRepository.Insert(entity);
        }

        public List<Destination> InsertManyDestinations(List<Destination> entities)
        {
            return _destionationRepository.InsertMany(entities);
        }

        public Destination UpdateDestination(Destination entity)
        {
            return _destionationRepository.Update(entity);
        }
    }
}
