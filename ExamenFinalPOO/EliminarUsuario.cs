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
                string query = $"SELECT idUsuario FROM USUARIO WHERE nombre = '{comboBox1.SelectedValue}'";

                var dt = ConnectionBD.ExecuteQuery(query);
                var dr = dt.Rows[0];
                var idUsuario = Convert.ToInt32(dr[0].ToString());

                string nonQuery = $"DELETE FROM USUARIO AND REGISTRO WHERE idUsuario = {idUsuario}";

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
            var name = ConnectionBD.ExecuteQuery("SELECT idUsuario FROM USUARIO");
            var nameCombo = new List<string>();

            foreach (DataRow dr in name.Rows)
            {
                nameCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = nameCombo;
        }
    }
}
