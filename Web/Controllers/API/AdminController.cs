using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.X509;
using Service.Interface;

namespace Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public AdminController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("[action]")]
        public List<Reservation> GetAllReservations()
        {
            return this._reservationService.GetAllReservations();
        }

        [HttpGet("[action]/{id}")]
        public Reservation GetDetails(int id)
        {
            return this._reservationService.GetDetailsForReservation(id);
        }

    }
}
