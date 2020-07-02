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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }


        public void ActGrid()
        {
            tableLayoutPanel3.Controls.Remove(dataGridView1);
            var dt = ConnectionBD.ExecuteQuery("");
            dataGridView1.DataSource = dt;
            tableLayoutPanel3.Controls.Add(dataGridView1);
        }
    }
}
