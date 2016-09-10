namespace usuariosApp
{
    partial class registroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registroUsuario));
            this.nombre = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.nombre_tb2 = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.password_tb2 = new System.Windows.Forms.TextBox();
            this.Registro = new System.Windows.Forms.GroupBox();
            this.agregar = new System.Windows.Forms.Button();
            this.aleatorio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.generarpass = new System.Windows.Forms.Button();
            this.aleatorios_tb = new System.Windows.Forms.TextBox();
            this.agregarpass = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(14, 33);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(17, 67);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 1;
            this.email.Text = "Email";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(13, 108);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // nombre_tb2
            // 
            this.nombre_tb2.Location = new System.Drawing.Point(85, 33);
            this.nombre_tb2.Name = "nombre_tb2";
            this.nombre_tb2.Size = new System.Drawing.Size(106, 20);
            this.nombre_tb2.TabIndex = 3;
            this.nombre_tb2.TextChanged += new System.EventHandler(this.nombre_tb2_TextChanged);
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(85, 67);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(106, 20);
            this.email_tb.TabIndex = 4;
            // 
            // password_tb2
            // 
            this.password_tb2.Location = new System.Drawing.Point(85, 105);
            this.password_tb2.Name = "password_tb2";
            this.password_tb2.Size = new System.Drawing.Size(106, 20);
            this.password_tb2.TabIndex = 5;
            this.password_tb2.TextChanged += new System.EventHandler(this.password_tb2_TextChanged);
            // 
            // Registro
            // 
            this.Registro.Controls.Add(this.Eliminar);
            this.Registro.Controls.Add(this.actualizar);
            this.Registro.Controls.Add(this.agregar);
            this.Registro.Controls.Add(this.password_tb2);
            this.Registro.Controls.Add(this.nombre);
            this.Registro.Controls.Add(this.email_tb);
            this.Registro.Controls.Add(this.email);
            this.Registro.Controls.Add(this.nombre_tb2);
            this.Registro.Controls.Add(this.password);
            this.Registro.Location = new System.Drawing.Point(12, 26);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(229, 329);
            this.Registro.TabIndex = 6;
            this.Registro.TabStop = false;
            this.Registro.Text = "Registro";
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(60, 174);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(114, 37);
            this.agregar.TabIndex = 6;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // aleatorio
            // 
            this.aleatorio.AutoSize = true;
            this.aleatorio.Location = new System.Drawing.Point(266, 151);
            this.aleatorio.Name = "aleatorio";
            this.aleatorio.Size = new System.Drawing.Size(138, 13);
            this.aleatorio.TabIndex = 9;
            this.aleatorio.Text = "Generar Password Aleatorio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(304, 310);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 11;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(60, 224);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(114, 36);
            this.actualizar.TabIndex = 7;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // generarpass
            // 
            this.generarpass.Location = new System.Drawing.Point(267, 196);
            this.generarpass.Name = "generarpass";
            this.generarpass.Size = new System.Drawing.Size(136, 23);
            this.generarpass.TabIndex = 15;
            this.generarpass.Text = "Generar Password";
            this.generarpass.UseVisualStyleBackColor = true;
            this.generarpass.Click += new System.EventHandler(this.generarpass_Click);
            // 
            // aleatorios_tb
            // 
            this.aleatorios_tb.Location = new System.Drawing.Point(251, 170);
            this.aleatorios_tb.Name = "aleatorios_tb";
            this.aleatorios_tb.Size = new System.Drawing.Size(166, 20);
            this.aleatorios_tb.TabIndex = 14;
            this.aleatorios_tb.TextChanged += new System.EventHandler(this.aleatorios_tb_TextChanged);
            // 
            // agregarpass
            // 
            this.agregarpass.Location = new System.Drawing.Point(275, 225);
            this.agregarpass.Name = "agregarpass";
            this.agregarpass.Size = new System.Drawing.Size(119, 23);
            this.agregarpass.TabIndex = 13;
            this.agregarpass.Text = "Agregar Password";
            this.agregarpass.UseVisualStyleBackColor = true;
            this.agregarpass.Click += new System.EventHandler(this.agregarpass_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(60, 266);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(114, 41);
            this.Eliminar.TabIndex = 16;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // registroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 367);
            this.Controls.Add(this.generarpass);
            this.Controls.Add(this.aleatorios_tb);
            this.Controls.Add(this.agregarpass);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aleatorio);
            this.Controls.Add(this.Registro);
            this.Name = "registroUsuario";
            this.Text = "registroUsuario";
            this.Load += new System.EventHandler(this.registroUsuario_Load);
            this.Registro.ResumeLayout(false);
            this.Registro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox nombre_tb2;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox password_tb2;
        private System.Windows.Forms.GroupBox Registro;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label aleatorio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Button generarpass;
        private System.Windows.Forms.TextBox aleatorios_tb;
        private System.Windows.Forms.Button agregarpass;
        private System.Windows.Forms.Button Eliminar;
    }
}