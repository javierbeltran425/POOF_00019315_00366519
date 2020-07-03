using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalPOO
{
    public class Proxy
    {
        public interface ISujeto
        {
            void Peticion(Usuario empleado, string pass, Form1 principal);
        }

        public class SistemProxy : ISujeto
        {
            public void Peticion(Usuario empleado, string pass, Form1 principal)
            {
               try
               {
                    if (empleado.IdDepartamento.Equals(1))
                    {

                    }else if (empleado.IdDepartamento.Equals(2))
                    {
                        if (pass == empleado.Contrasenia)
                        {
                            Administrador AdminView = new Administrador(principal);
                            AdminView.Show(principal);
                            principal.Hide();
                        }
                    }
                    else if (empleado.IdDepartamento.Equals(3))
                    {
                        if(pass == empleado.Contrasenia)
                        {
                            Empleado EmplView = new Empleado();
                            EmplView.Show(principal);
                            principal.Hide();
                        }

                    }
               }
               catch (Exception ex)
               {
                     MessageBox.Show("Ha ocurrido un error");
               }
            }
        }
    }
}
