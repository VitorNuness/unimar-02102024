using Hotel.app.Controllers.Requests;
using Hotel.app.Models;
using Hotel.app.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.app.Controllers
{
    [ApiController]
    [Route("quartos")]
    public class ReserveController : ControllerBase
    {
        private readonly ReserveService _reserveService;

        public ReserveController(ReserveService reserveService)
        {
            _reserveService = reserveService;
        }

        [HttpPost("{idQuarto}/reservas")]
        public async Task<ActionResult<Reserve>> CriarReserva(string idQuarto, [FromBody] ReserveRequest request)
        {
            try
            {
                Reserve newReserve = await _reserveService.Create(idQuarto, request.HospedeId, DateTime.Parse(request.Date));
                return CreatedAtAction(nameof(CriarReserva), new { id = newReserve.Id }, newReserve);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao criar reserva: {ex.Message}");
            }
        }
    }
}
