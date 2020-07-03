using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPOO
{
    class ConsultaDepartamento
    {
        public static List<Registro> getLista()
        {
            string sql = "SELECT * FROM DEPARTAMENTO";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Registro> lista = new List<Registro>();
            foreach (DataRow fila in dt.Rows)
            {
                Registro dp = new Registro();
                dp.IdDepartamento = Convert.ToInt32(fila[0].ToString());
                dp.Nombre = fila[1].ToString();
                dp.Ubicacion = fila[2].ToString();

                lista.Add(dp);
            }

            return lista;
        }
    }
}
