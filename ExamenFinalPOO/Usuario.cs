using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPOO
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdDepartamento { get; set; }
        public string Contrasenia { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dui { get; set; }
        public string FechaNacimiento { get; set; }
    }
}
