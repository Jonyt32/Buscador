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
    public class ServicioTarifa : IServicioTarifa
    {
        private readonly IRepositorioGenerico<Tarifas> _repositorio;
        public ServicioTarifa(IRepositorioGenerico<Tarifas> repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task ActualizarTarifaAsync(Tarifas tarifa)
        {
            try
            {
                await _repositorio.ActualizarAsync(tarifa);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Tarifas> AgregarTarifaAsync(Tarifas tarifa)
        {
            try
            {
                return await _repositorio.InsertarAsync(tarifa);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task EliminarTarifaAsync(int id)
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

        public async Task<IEnumerable<Tarifas>> ListarTarifasAsync()
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

        public async Task<Tarifas> ObtenerTarifaPorIdAsync(int id)
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
