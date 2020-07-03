using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPOO
{
    class ConsultaRegistro
    {
        public static List<Registro> getLista()
        {
            string sql = "SELECT * FROM REGISTRO";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Registro> lista = new List<Registro>();
            foreach (DataRow fila in dt.Rows)
            {
                Registro reg = new Registro();
                reg.IdRegistro = Convert.ToInt32(fila[0].ToString());
                reg.IdUsuario = Convert.ToInt32(fila[1].ToString());
                reg.Entrada = Convert.ToBoolean(fila[2].ToString());
                reg.Temperatura = Convert.ToDouble(fila[3].ToString());
                reg.Fecha = Convert.ToDateTime(fila[0].ToString());

                lista.Add(reg);
            }

            return lista;
        }

    }
}
