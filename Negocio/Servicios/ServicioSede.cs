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
    public class ServicioSede : IServicioSede
    {
        private readonly IRepositorioGenerico<Sedes> _repositorio;

        public ServicioSede(IRepositorioGenerico<Sedes> repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task ActualizarSedeAsync(Sedes sede)
        {
            try
            {
                await _repositorio.ActualizarAsync(sede);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Sedes> AgregarSedeAsync(Sedes sede)
        {
            try
            {
                return await _repositorio.InsertarAsync(sede);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task EliminarSedeAsync(int id)
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

        public async Task<IEnumerable<Sedes>> ListarSedesAsync()
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

        public async Task<Sedes> ObtenerSedePorIdAsync(int id)
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
