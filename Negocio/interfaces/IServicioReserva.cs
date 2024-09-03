using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.interfaces
{
    public interface IServicioReserva
    {
        Task<IEnumerable<Reservas>> ListarReservasAsync();
        Task<Reservas> ConsultarReserva(int idReserva);
        Task<Reservas> AgregarReserva(Reservas reserva);
        Task ActualizarReserva(Reservas reserva);
        Task EliminarReserva(int idReserva);

    }
}
