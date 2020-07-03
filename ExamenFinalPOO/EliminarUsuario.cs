using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalPOO
{
    public partial class EliminarUsuario : UserControl
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string nonQuery = $"DELETE FROM USUARIO WHERE idUsuario = {comboBox1.SelectedValue}";

                ConnectionBD.ExecuteNonQuery(nonQuery);


                MessageBox.Show("Se ha eliminado el usuario");

            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idusuario";
            comboBox1.DisplayMember = "idusuario";
            comboBox1.DataSource = ConsultaUsuario.getLista();
        }
    }
}
