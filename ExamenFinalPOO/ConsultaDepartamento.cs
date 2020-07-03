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
        public static List<Departamento> getLista()
        {
            string sql = "SELECT * FROM DEPARTAMENTO";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Departamento> lista = new List<Departamento>();
            foreach (DataRow fila in dt.Rows)
            {
                Departamento dp = new Departamento();
                dp.IdDepartamento = Convert.ToInt32(fila[0].ToString());
                dp.Nombre = fila[1].ToString();
                dp.Ubicacion = fila[2].ToString();

                lista.Add(dp);
            }

            return lista;
        }
    }
}
