using Datos.Modelos;
using Microsoft.AspNetCore.Mvc;
using Negocio.interfaces;

namespace BuscadorHotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly IServicioReserva _servicioReserva;

        public ReservaController(IServicioReserva servicioReserva)
        {
            _servicioReserva = servicioReserva;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<IEnumerable<Reservas>>> ListarReservas()
        {
            try
            {
                var reservas = await _servicioReserva.ListarReservasAsync();
                return Ok(reservas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<Reservas>> ConsultarReserva(int id)
        {
            try
            {
                var reservas = await _servicioReserva.ConsultarReserva(id);
                return Ok(reservas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Reservas>> AgregarReserva(Reservas reserva)
        {
            try
            {
                var reservas = await _servicioReserva.AgregarReserva(reserva);
                return Ok(reservas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> ActualizarReservas(Reservas reserva)
        {
            try
            {
                await _servicioReserva.ActualizarReserva(reserva);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<ActionResult> EliminarReserva(int id)
        {
            try
            {
                await _servicioReserva.EliminarReserva(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
