using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPOO
{
    class Registro
    {
        public int IdRegistro { get; set; }
        public int IdUsuario { get; set; }
        public bool Entrada { get; set; }
        public double Temperatura { get; set; }
        public DateTime Fecha { get; set; }
    }
}
