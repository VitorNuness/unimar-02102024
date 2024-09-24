using System;
using System.Threading.Tasks;
using Hotel.app.Models;
using Hotel.app.Services;
using Microsoft.AspNetCore.Authorization;
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

        
        [Authorize]
        [HttpPost("{idQuarto}/reservas")]
        public async Task<ActionResult<Reserve>> CriarReserva(string idQuarto, [FromBody] ReservaRequest request)
        {
            
            if (request == null || string.IsNullOrEmpty(request.HospedeId) || request.DataReserva == DateTime.MinValue)
            {
                return BadRequest("Dados inválidos.");
            }

            try
            {
                
                var novaReserva = await _reserveService.Create(idQuarto, request.HospedeId, request.DataReserva);
                return CreatedAtAction(nameof(CriarReserva), new { id = novaReserva.Id }, novaReserva);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao criar reserva: {ex.Message}");
            }
        }
    }

    public class ReservaRequest
    {
        public string HospedeId { get; set; } 
        public DateTime DataReserva { get; set; }
    }
}
