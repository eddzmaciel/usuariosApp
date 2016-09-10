using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.ProviderBase;

namespace usuariosApp
{
    public partial class historialpasswords : Form
    {

      

        public historialpasswords()
        {
            InitializeComponent();
        }

        private void verhistorial_Click(object sender, EventArgs e)
        {

            try
            {
                //RUTA DE LA TABLA DBF
                string cadena = "datasource=localhost;Database=usuariosapp;port=3306;username=root;password='';";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = cadena;
                //ABRIR CONEXION 
                con.Open();
                // 
                string consulta = "Select * from passwords";
         
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);
                //EL DATASET CAPTURARA LOS DATOS DEVUELTOS
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                //CERRAMOS LA CONEXION
                con.Close();
                // INDICAMOS AL DATA GRID QUE TOME LA INFORMACION DEL DATA SET
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error:" + exp.Message);
            }


        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f6 = new Form2();
            f6.ShowDialog();
        }
    }
}
