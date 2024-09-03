using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IRepositorioReserva : IRepositorioGenerico<Reservas>
    {
        Task<List<Reservas>> ObenerReservaFechasSedeAlojamiento(DateTime fechaInicio);
    }
}
