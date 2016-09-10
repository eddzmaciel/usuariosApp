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

namespace usuariosApp {
    public partial class registroUsuario : Form    {

        private bool IsValidPassword(string password)        {
            return (password.Length == 8 &&
                password.Any(char.IsUpper) &&
                password.Any(char.IsLower) &&
                password.Any(char.IsDigit)
                );
        }

    
        public registroUsuario() {
            InitializeComponent();
            aleatorios_tb.TextAlign = HorizontalAlignment.Center;
            aleatorios_tb.CharacterCasing = CharacterCasing.Lower;
            password_tb2.MaxLength = 8;
            nombre_tb2.MaxLength = 32;
        }
        private void registroUsuario_Load(object sender, EventArgs e)
        {

        }
        private void agregar_Click(object sender, EventArgs e) {
            string constring = "datasource=localhost;Database=usuariosapp;port=3306;username=root;password='';";
            string Query = ("INSERT INTO  usuarios (nombre,email) VALUES ('"+this.nombre_tb2.Text+"','"+this.email_tb.Text+"'); INSERT INTO passwords (password ,estatus ,id_usuario) VALUES ('"+this.password_tb2.Text+"', '1', LAST_INSERT_ID());");
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            if (IsValidPassword(password_tb2.Text)){
                   try {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("¡Guardado con Exito!");
                        while (myReader.Read()) { }
                    }
                    catch (Exception ex){
                        MessageBox.Show(ex.Message);
                    }
                }
            else{
                //invalid password
                MessageBox.Show("Tiene que colocar 8 caracteres en su contraseña, al menos un numero en su composicion y al menos una letra mayuscula");
            }
        }
        private void password_tb2_TextChanged(object sender, EventArgs e){
        }
        private void generar_Click(object sender, EventArgs e){
        }
        private void button1_Click(object sender, EventArgs e) {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e) {
            string constring = "datasource=localhost;Database=usuariosapp;port=3306;username=root;password='';";
            string Query = ("UPDATE usuarios, passwords SET passwords.password='"+this.password_tb2.Text+"', usuarios.email='"+this.email_tb.Text+"' WHERE usuarios.id_usuarios=passwords.id_usuario AND usuarios.nombre='"+this.nombre_tb2.Text+"';");
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("¡Actualizado con Exito!");
                while (myReader.Read()) { }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
        private void Eliminar_Click(object sender, EventArgs e)  {
            string constring = "datasource=localhost;Database=usuariosapp;port=3306;username=root;password='';";
            string Query = ("DELETE usuarios, passwords FROM usuarios INNER JOIN passwords WHERE usuarios.id_usuarios=passwords.id_usuario AND usuarios.nombre='"+this.nombre_tb2.Text+"';");
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try  {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("¡Eliminado con Exito!");
                while (myReader.Read()) { }
             }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
             }
        }  
        //limpiar los textbox
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) => {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        //Generar passwords aleatorios
        private void generarpass_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            aleatorios_tb.Text = ""+random.Next(0,9)+chars[random.Next(chars.Length)]+random.Next(0,9)+random.Next(0,9)+chars[random.Next(chars.Length)]+random.Next(0,9)+random.Next(0,9)+chars[random.Next(chars.Length)];

        }
        private void aleatorios_tb_TextChanged(object sender, EventArgs e)
        {

        }
        private void nombre_tb2_TextChanged(object sender, EventArgs e){
        }
        private void agregarpass_Click(object sender, EventArgs e){
            string constring = "datasource=localhost;Database=usuariosapp;port=3306;username=root;password='';";
            string Query = ("INSERT INTO passwords (password,estatus,id_usuario) VALUES ('"+this.aleatorios_tb.Text+"', '1', LAST_INSERT_ID());");
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("¡Password Guardado con Exito!");
                while (myReader.Read()) { }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
         
        }


       


    }
}
