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
    public partial class VigilanteForm : Form
    {
        private Form1 principal;
        private Usuario empleado;

        public VigilanteForm(Form1 princ, Usuario vig)
        {
            InitializeComponent();
            principal = princ;
            empleado = vig;
           
        }


        public VigilanteForm()
        {
            this.principal = principal;
            this.empleado = empleado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue == null || textBox1.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    if (radioButton1.Checked)
                    {
                        ConnectionBD.ExecuteNonQuery("INSERT INTO REGISTRO(idusuario ,entrada, temperatura) " +
                        $"VALUES('{comboBox1.SelectedValue}', true, '{textBox1.Text}') ");

                        MessageBox.Show("Bienvenido");
                    }
                    else if (radioButton2.Checked)
                    {
                        ConnectionBD.ExecuteNonQuery("INSERT INTO REGISTRO(idusuario ,entrada, temperatura) " +
                        $"VALUES('{comboBox1.SelectedValue}', false, '{textBox1.Text}') ");

                        MessageBox.Show("Buen Viaje");
                    }
                   

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        

        private void VigilanteForm_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }

        public void PoblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idusuario";
            comboBox1.DisplayMember = "nombre";
            comboBox1.DataSource = ConsultaUsuario.getLista();

        }

        private void VigilanteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            principal.PoblarControles();
            principal.Show();
        }
    }
}
