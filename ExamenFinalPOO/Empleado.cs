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
        private Form1 principal;
        private Usuario empleado;
        public Empleado(Form1 princ, Usuario emp)
        {
            InitializeComponent();
            principal = princ;
            empleado = emp;
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            ActGrid();
        }

        private void ActGrid()
        {
            tableLayoutPanel1.Controls.Remove(dataGridView1);
            var dt = ConnectionBD.ExecuteQuery($"SELECT * FROM REGISTRO WHERE idusuario = '{empleado.IdUsuario}' ");
            dataGridView1.DataSource = dt;
            tableLayoutPanel1.Controls.Add(dataGridView1);
        }

        private void Empleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            principal.PoblarControles();
            principal.Show();
        }
    }
}
