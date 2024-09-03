using Datos.Modelos;
using Microsoft.AspNetCore.Mvc;
using Negocio.interfaces;

namespace BuscadorHotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DisponibilidadController : Controller
    {
        private readonly IServicioDisponibilidad _servicio;

        public DisponibilidadController(IServicioDisponibilidad servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<IEnumerable<Disponibilidad>>> ListarDisponibilidad()
        {
            try
            {
                var disponibilidades = await _servicio.ListarDisponibilidadAsync();
                return Ok(disponibilidades);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<Disponibilidad>> ConsultarDisponibilidadPorId(int id)
        {
            try
            {
                var disponibilidad = await _servicio.ObtenerDisponibilidadPorIdAsync(id);
                return Ok(disponibilidad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Disponibilidad>> AgregarDisponibilidad(Disponibilidad disponibilidad)
        {
            try
            {
                var nuevaDisponibilidad = await _servicio.AgregarDisponibilidadAsync(disponibilidad);
                return Ok(nuevaDisponibilidad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> ActualizarDisponibilidad(Disponibilidad disponibilidad)
        {
            try
            {
                await _servicio.ActualizarDisponibilidadAsync(disponibilidad);
                return Ok("Actualizo Correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<ActionResult> EliminarDisponibilidad(int id)
        {
            try
            {
                await _servicio.EliminarDisponibilidadAsync(id);
                return Ok("Elimino correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
