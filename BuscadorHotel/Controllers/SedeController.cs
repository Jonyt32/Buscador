using Datos.Modelos;
using Microsoft.AspNetCore.Mvc;
using Negocio.interfaces;

namespace BuscadorHotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SedeController : Controller
    {
        private readonly IServicioSede _servicio;

        public SedeController(IServicioSede servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<IEnumerable<Sedes>>> ListarSedes()
        {
            try
            {
                var sedes = await _servicio.ListarSedesAsync();
                return Ok(sedes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<Sedes>> ConsultarSedePorId(int id)
        {
            try
            {
                var sede = await _servicio.ObtenerSedePorIdAsync(id);
                return Ok(sede);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Sedes>> AgregarSede(Sedes sede)
        {
            try
            {
                var nuevaSede = await _servicio.AgregarSedeAsync(sede);
                return Ok(nuevaSede);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> ActualizarSede(Sedes sede)
        {
            try
            {
                await _servicio.ActualizarSedeAsync(sede);
                return Ok("Actualizo Correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<ActionResult> EliminarSede(int id)
        {
            try
            {
                await _servicio.EliminarSedeAsync(id);
                return Ok("Elimino correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
