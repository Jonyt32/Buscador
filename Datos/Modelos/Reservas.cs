using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    public class Reservas
    {
        [Key]
        public int IdReserva { get; set; }
        public int IdDisponibilidad { get; set; }
        public int IdTarifa { get; set; }
        public string NombrePersona { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int CantidadPersonas { get; set; }
        
    }
}
