using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.interfaces
{
    public interface IServicioDisponibilidad
    {
        Task<IEnumerable<Disponibilidad>> ListarDisponibilidadAsync();
        Task<Disponibilidad> ObtenerDisponibilidadPorIdAsync(int id);
        Task<Disponibilidad> AgregarDisponibilidadAsync(Disponibilidad disponibilidad);
        Task ActualizarDisponibilidadAsync(Disponibilidad disponibilidad);
        Task EliminarDisponibilidadAsync(int id);
    }
}
