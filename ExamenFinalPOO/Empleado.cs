using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalPOO
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dt2 = ConnectionBD.ExecuteQuery($"SELECT us.idUsuario, us.nombre, us.apellido, reg.temperatura, reg.fecha " +
                $"FROM USUARIO us, Registro reg WHERE us.idUsuario = reg.idRegistro");

            dataGridView1.DataSource = dt2;


            MessageBox.Show("Datos obtenidos exitosamente");
        }


        private void Empleado_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = RegistroConsulta.getLista();
        }
    }
}
