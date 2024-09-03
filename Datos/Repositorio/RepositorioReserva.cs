using Datos.Context;
using Datos.Interfaces;
using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorio
{
    public class RepositorioReserva : RepositorioGenerico<Reservas>, IRepositorioReserva
    {
        public RepositorioReserva(AppDbContext contexto) : base(contexto)
        {
        }

        public async Task<List<Reservas>> ObenerReservaFechasSedeAlojamiento(DateTime fechaInicio)
        {
            try
            {
                return _dbSet.Where(x => (x.FechaInicio >= fechaInicio && x.FechaFin <= fechaInicio)).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
