using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    public class TipoAlojamiento
    {
        [Key]
        public int IdTipoHabitacion { get; set; }
        public string NombreTipo { get; set; }
    }
}
