using Datos.Interfaces;
using Datos.Modelos;
using Negocio.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public class ServicioTipoAlojamiento : IServicioTipoAlojamiento
    {
        private readonly IRepositorioGenerico<TipoAlojamiento> _repositorio;

        public ServicioTipoAlojamiento(IRepositorioGenerico<TipoAlojamiento> repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task ActualizarTipoAlojamientoAsync(TipoAlojamiento tipo)
        {
            try
            {
                await _repositorio.ActualizarAsync(tipo);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<TipoAlojamiento> AgregarTipoAlojamientoAsync(TipoAlojamiento tipo)
        {
            try
            {
                return await _repositorio.InsertarAsync(tipo);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task EliminarTipoAlojamientoAsync(int id)
        {
            try
            {
                await _repositorio.EliminarAsync(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<TipoAlojamiento>> ListarTipoAlojamientoAsync()
        {
            try
            {
                   return await _repositorio.ListarAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<TipoAlojamiento> ObtenerTipoAlojamientoPorIdAsync(int id)
        {
            try
            {
                return await _repositorio.ObtenerPorIdAsync(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
