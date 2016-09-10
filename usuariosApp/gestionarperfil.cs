using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;


namespace usuariosApp
{
    public partial class gestionarperfil : Form
    {
        public gestionarperfil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            //ocultamos el formulario 
            this.Hide();
            //mostramos el nuevo formulario creado
            Form2 f3 = new Form2();
            f3.ShowDialog();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;Database=usuariosapp;port=3306;username=root;password='';";
            string Query = ("UPDATE usuarios, passwords SET passwords.password='" + this.textBox3.Text + "', usuarios.email='" + this.textBox2.Text + "' WHERE usuarios.id_usuarios=passwords.id_usuario AND usuarios.nombre='" + this.textBox4.Text + "';");
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("¡Actualizado con Exito!");
                while (myReader.Read()) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;Database=usuariosapp;port=3306;username=root;password='';";
            string Query = ("DELETE usuarios, passwords FROM usuarios INNER JOIN passwords WHERE usuarios.id_usuarios=passwords.id_usuario AND usuarios.nombre='" + this.textBox4.Text + "';");
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("¡Eliminado con Exito!");
                while (myReader.Read()) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void verusuarios_Click(object sender, EventArgs e)
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
                string consulta = "SELECT usuarios.id_usuarios, usuarios.nombre,passwords.password,usuarios.email FROM usuarios,passwords WHERE usuarios.id_usuarios = passwords.id_usuario";

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

      
    }
}
