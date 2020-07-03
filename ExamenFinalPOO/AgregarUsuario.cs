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
    public partial class AgregarUsuario : UserControl
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionBD.ExecuteNonQuery("INSERT INTO USUARIO(idusuario, iddepartamento ,nombre, apellido, dui, contrasenia, fechanacimiento) " +
                $"VALUES('{textBox5.Text}', '{comboBox1.SelectedValue}', '{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox6.Text}', '{textBox4.Text}') ");

                MessageBox.Show("Usuario registrado");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }

        public void PoblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "iddepartamento";
            comboBox1.DisplayMember = "nombre";
            comboBox1.DataSource = ConsultaDepartamento.getLista();
        }
    }
}
