using Datos.Modelos;
using Microsoft.AspNetCore.Mvc;
using Negocio.interfaces;

namespace BuscadorHotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoAlojamientoController : Controller
    {
        private readonly IServicioTipoAlojamiento _servicio;

        public TipoAlojamientoController(IServicioTipoAlojamiento servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<IEnumerable<TipoAlojamiento>>> ListarTipoAlojamiento()
        {
            try
            {
                var tiposAlojamientos = await _servicio.ListarTipoAlojamientoAsync();
                return Ok(tiposAlojamientos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<Sedes>> ConsultarTipoAlojamientoPorId(int id)
        {
            try
            {
                var tipoAlojamiento = await _servicio.ObtenerTipoAlojamientoPorIdAsync(id);
                return Ok(tipoAlojamiento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<TipoAlojamiento>> AgregarTipoAlojamiento(TipoAlojamiento tipo)
        {
            try
            {
                var nuevoTipo = await _servicio.AgregarTipoAlojamientoAsync(tipo);
                return Ok(nuevoTipo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> ActualizarTipoAlojamiento(TipoAlojamiento tipo)
        {
            try
            {
                await _servicio.ActualizarTipoAlojamientoAsync(tipo);
                return Ok("Actualizo Correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<ActionResult> EliminarTipoAlojamiento(int id)
        {
            try
            {
                await _servicio.EliminarTipoAlojamientoAsync(id);
                return Ok("Elimino correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
