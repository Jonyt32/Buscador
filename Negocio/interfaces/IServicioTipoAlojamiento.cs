using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.interfaces
{
    public interface IServicioTipoAlojamiento
    {
        Task<IEnumerable<TipoAlojamiento>> ListarTipoAlojamientoAsync();
        Task<TipoAlojamiento> ObtenerTipoAlojamientoPorIdAsync(int id);
        Task<TipoAlojamiento> AgregarTipoAlojamientoAsync(TipoAlojamiento tipo);
        Task ActualizarTipoAlojamientoAsync(TipoAlojamiento tipo);
        Task EliminarTipoAlojamientoAsync(int id);
    }
}
