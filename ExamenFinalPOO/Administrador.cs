using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalPOO
{
    public partial class Administrador : Form
    {
        private UserControl current = null;
        private Form1 princ;
        public Administrador(Form1 principal)
        {
            InitializeComponent();
            princ = principal;
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            ActGrid();
        }

        public void ActGrid()
        {
            tableLayoutPanel3.Controls.Remove(dataGridView1);
            var dt = ConnectionBD.ExecuteQuery("SELECT idusuario, iddepartamento, nombre, apellido, dui, fechanacimiento FROM USUARIO ");
            dataGridView1.DataSource = dt;
            tableLayoutPanel3.Controls.Add(dataGridView1);
        }

        private void Administrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            princ.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel4.Controls.Remove(current);
            current = new AgregarUsuario();
            tableLayoutPanel4.Controls.Add(current, 0, 1);
            tableLayoutPanel4.SetColumnSpan(current, 2);
            ActGrid();
        }
    }
}
