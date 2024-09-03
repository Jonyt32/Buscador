using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    public class Sedes
    {
        [Key]
        public int IdSede { get; set; }
        public string NombreSede { get; set; }
    }
}
