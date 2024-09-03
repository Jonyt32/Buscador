using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IRepositorioGenerico<T> where T : class
    {
        Task<IEnumerable<T>> ListarAsync();
        Task<T> ObtenerPorIdAsync(int id);
        Task<T> InsertarAsync(T entidad);
        Task ActualizarAsync(T entidad);
        Task EliminarAsync(int id);
    }
}
