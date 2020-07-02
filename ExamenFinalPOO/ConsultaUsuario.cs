using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPOO
{
    class ConsultaUsuario
    {
        public static List<Usuario> getLista()
        {
            string sql = "SELECT * FROM USUARIO";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Usuario> lista = new List<Usuario>();
            foreach (DataRow fila in dt.Rows)
            {
                Usuario usu = new Usuario();
                usu.IdUsuario = Convert.ToInt32(fila[0].ToString());
                usu.IdDepartamento = Convert.ToInt32(fila[1].ToString());
                usu.Nombre = fila[2].ToString();
                usu.Apellido = fila[3].ToString();
                usu.Dui = fila[4].ToString();
                usu.Contrasenia = fila[5].ToString();
                usu.FechaNacimiento = fila[6].ToString();

                lista.Add(usu);
            }

            return lista;
        }
    }
}
