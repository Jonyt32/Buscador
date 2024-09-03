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
    public class ServicioReserva : IServicioReserva
    {
        private readonly IRepositorioReserva _repositorioReserva;
        private readonly IRepositorioGenerico<Disponibilidad> _repoDisponibilidad;

        public ServicioReserva(IRepositorioReserva repositorioReserva, 
            IRepositorioGenerico<Disponibilidad> repoDisponibilidad)
        {
            _repositorioReserva = repositorioReserva;
            _repoDisponibilidad = repoDisponibilidad;
        }
        public async Task<IEnumerable<Reservas>> ListarReservasAsync()
        {
            return await _repositorioReserva.ListarAsync();
        }
        public async Task<Reservas> ConsultarReserva(int idReserva)
        {
            return await _repositorioReserva.ObtenerPorIdAsync(idReserva);
        }
        public async Task<Reservas> AgregarReserva(Reservas reserva) 
        {
            try
            {
                await ValidarAcomodaciones(reserva);

                return await _repositorioReserva.InsertarAsync(reserva); 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private async Task ValidarAcomodaciones(Reservas reserva) 
        {
            try
            {
                Disponibilidad disponible = await _repoDisponibilidad.ObtenerPorIdAsync(reserva.IdDisponibilidad);
                if (reserva.CantidadPersonas > disponible.MaxCupo)
                {
                    throw new Exception($"La acomodación debe ser máximo de: {disponible.MaxCupo} personas por habitacion");
                }
                int cantidadReservada = (await _repositorioReserva.ObenerReservaFechasSedeAlojamiento(reserva.FechaInicio)).Count;
                if (cantidadReservada > disponible.Cantidad)
                {
                    throw new Exception($"No es posible encontar alojamiento entre las fechas {reserva.FechaInicio} y {reserva.FechaFin}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task ActualizarReserva(Reservas reserva)
        {
            try
            {
                await ValidarAcomodaciones(reserva);

                await _repositorioReserva.ActualizarAsync(reserva);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task EliminarReserva(int idReserva)
        {
            try
            {
                await _repositorioReserva.EliminarAsync(idReserva);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
