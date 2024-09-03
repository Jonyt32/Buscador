using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    public class Disponibilidad
    {
        [Key]
        public int IdDisponibilidad { get; set; }
        public int IdSede { get; set; }
        public int IdTipoHabitacion { get; set; }
        public int MaxCupo { get; set; }
        public int Cantidad { get; set; }
    }
}
