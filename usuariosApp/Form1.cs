using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace usuariosApp{
    public partial class Form1 : Form {
        //validar password
        private bool IsValidPassword(string password)
        {
            return (password.Length == 8 &&
                password.Any(char.IsUpper) &&
                password.Any(char.IsLower) &&
                password.Any(char.IsDigit)
                );
        } 
        public Form1()
        {
            InitializeComponent();

            //acomodo del texto en el TXBOX
            usuario_tb.TextAlign = HorizontalAlignment.Center;
            usuario_tb.CharacterCasing = CharacterCasing.Lower;
            contrasena_tb.PasswordChar='*';
            contrasena_tb.MaxLength = 8;
            usuario_tb.MaxLength =32;
            contrasena_tb.TextAlign = HorizontalAlignment.Center;
            contrasena_tb.CharacterCasing = CharacterCasing.Lower;
        }
        private void button1_Click(object sender, EventArgs e){
                string myConnection = "datasource=localhost;Database=usuariosapp;port=3306;username=root ";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                //MySqlCommand SelectCommand = new MySqlCommand("select * from usuariosapp.usuarios where nick='"+ this.usuario_tb.Text +"' and password='"+ this.contrasena_tb.Text +"';",myConn);
                MySqlCommand SelectCommand = new MySqlCommand("select * from usuarios inner join passwords where usuarios.nombre ='" + this.usuario_tb.Text + "' and passwords.password='" + this.contrasena_tb.Text + "';", myConn);
                MySqlDataReader myReader;
            //  MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
               try  {
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                    while (myReader.Read()) {
                           count = count + 1;
                        }
                  if (string.IsNullOrEmpty(usuario_tb.Text)){
                        MessageBox.Show("Debe completar la informacion");
                        return;
                   }
                  else {
                              if (count == 1) {
                                  MessageBox.Show("Usuario Correcto!, Acceso Autorizado!");
                                  //ocultamos el formulario 
                                  this.Hide();
                                  //mostramos el nuevo formulario creado
                                  Form2 f3 = new Form2();
                                  f3.ShowDialog();
                              }
                              else{
                                  MessageBox.Show("Error, Acceso Denegado");
                              }
                         }
                    myConn.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
                Debug.WriteLine("Send to debug output.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e) {
            //ocultamos el formulario 
            this.Hide();
            //mostramos el nuevo formulario creado
            registroUsuario f2 = new registroUsuario();
            f2.ShowDialog();

        }

        private void usuario_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}
