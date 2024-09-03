using Datos.Modelos;
using Microsoft.AspNetCore.Mvc;
using Negocio.interfaces;

namespace BuscadorHotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarifasController : Controller
    {
        private readonly IServicioTarifa _servicio;

        public TarifasController(IServicioTarifa servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<IEnumerable<Tarifas>>> ListarTarifas()
        {
            try
            {
                var tarifas = await _servicio.ListarTarifasAsync();
                return Ok(tarifas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<Tarifas>> ConsultarTarifaPorId(int id)
        {
            try
            {
                var tarifa = await _servicio.ObtenerTarifaPorIdAsync(id);
                return Ok(tarifa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Tarifas>> AgregarTarifa(Tarifas tarifa)
        {
            try
            {
                var nuevaTarifa = await _servicio.AgregarTarifaAsync(tarifa);
                return Ok(nuevaTarifa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> ActualizarTarifa(Tarifas tarifa)
        {
            try
            {
                await _servicio.ActualizarTarifaAsync(tarifa);
                return Ok("Actualizo Correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<ActionResult> EliminarTarifa(int id)
        {
            try
            {
                await _servicio.EliminarTarifaAsync(id);
                return Ok("Elimino correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
