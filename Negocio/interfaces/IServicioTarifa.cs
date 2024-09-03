using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.interfaces
{
    public interface IServicioTarifa
    {
        Task<IEnumerable<Tarifas>> ListarTarifasAsync();
        Task<Tarifas> ObtenerTarifaPorIdAsync(int id);
        Task<Tarifas> AgregarTarifaAsync(Tarifas tarifa);
        Task ActualizarTarifaAsync(Tarifas tarifa);
        Task EliminarTarifaAsync(int id);
    }
}
