using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    public class Tarifas
    {
        [Key]
        public int IdTarifa { get; set; }
        public string NombreTarifa { get; set; }
        public decimal Porcentual { get; set; }
    }
}
