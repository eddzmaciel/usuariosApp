using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace usuariosApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void gestionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionarperfil f4 = new gestionarperfil();
            f4.ShowDialog();
        }

        private void historialpass_but_Click(object sender, EventArgs e)
        {
            this.Hide();
            historialpasswords f5 = new historialpasswords();
            f5.ShowDialog();

        }
    }
}
