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
    public class ServicioDisponibilidad : IServicioDisponibilidad
    {
        private readonly IRepositorioGenerico<Disponibilidad> _repositorio;
        public ServicioDisponibilidad(IRepositorioGenerico<Disponibilidad> repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task ActualizarDisponibilidadAsync(Disponibilidad disponibilidad)
        {
            try
            {
                await _repositorio.ActualizarAsync(disponibilidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Disponibilidad> AgregarDisponibilidadAsync(Disponibilidad disponibilidad)
        {
            try
            {
               return await _repositorio.InsertarAsync(disponibilidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task EliminarDisponibilidadAsync(int id)
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

        public async Task<IEnumerable<Disponibilidad>> ListarDisponibilidadAsync()
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

        public async Task<Disponibilidad> ObtenerDisponibilidadPorIdAsync(int id)
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
