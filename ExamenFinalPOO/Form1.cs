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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }

        public void PoblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "contrasenia";
            comboBox1.DisplayMember = "nombre";
            comboBox1.DataSource = ConsultaUsuario.getLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usu = (Usuario)comboBox1.SelectedItem;
            string pass = textBox1.Text;

            Proxy.ISujeto Prox = new Proxy.SistemProxy(); 
            Prox.Peticion(usu, pass, this);
            textBox1.Text = "";
            
        }
    }
}
