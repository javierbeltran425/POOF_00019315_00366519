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
            ActGrid2();
        }

        public void ActGrid()
        {
            tableLayoutPanel3.Controls.Remove(dataGridView1);
            var dt = ConnectionBD.ExecuteQuery("SELECT idusuario, iddepartamento, nombre, apellido, dui, fechanacimiento FROM USUARIO ");
            dataGridView1.DataSource = dt;
            tableLayoutPanel3.Controls.Add(dataGridView1);
        }

        public void ActGrid2()
        {
            tableLayoutPanel6.Controls.Remove(dataGridView2);
            var dt = ConnectionBD.ExecuteQuery("SELECT * FROM REGISTRO");
            dataGridView2.DataSource = dt;
            tableLayoutPanel6.Controls.Add(dataGridView2, 0, 0);
            tableLayoutPanel6.SetColumnSpan(dataGridView2, 2);
        }

        public void ActGrid3()
        {
            groupBox2.Controls.Remove(dataGridView3);
            var dt = ConnectionBD.ExecuteQuery("SELECT d.nombre, count(u.idDepartamento) as frecuencia " +
                "FROM REGISTRO r, DEPARTAMENTO d, USUARIO u " +
                "WHERE r.idUsuario = u.idUsuario AND d.idDepartamento = u.idDepartamento " +
                "GROUP BY d.idDepartamento " +
                "ORDER BY frecuencia DESC LIMIT 1 ");
            dataGridView3.DataSource = dt;
            groupBox2.Controls.Add(dataGridView3);
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

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel4.Controls.Remove(current);
            current = new EliminarUsuario();
            tableLayoutPanel4.Controls.Add(current, 0, 1);
            tableLayoutPanel4.SetColumnSpan(current, 2);
            ActGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActGrid2();
            ActGrid3();
        }
    }
}
