using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.interfaces
{
    public interface IServicioSede
    {
        Task<IEnumerable<Sedes>> ListarSedesAsync();
        Task<Sedes> ObtenerSedePorIdAsync(int id);
        Task<Sedes> AgregarSedeAsync(Sedes sede);
        Task ActualizarSedeAsync(Sedes sede);
        Task EliminarSedeAsync(int id);
    }
}
