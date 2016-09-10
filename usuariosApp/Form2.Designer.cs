namespace usuariosApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.Button();
            this.gestionar = new System.Windows.Forms.Button();
            this.historialpass_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(104, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido  al Sistema";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(162, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 115);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(185, 270);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 3;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // gestionar
            // 
            this.gestionar.Location = new System.Drawing.Point(172, 184);
            this.gestionar.Name = "gestionar";
            this.gestionar.Size = new System.Drawing.Size(106, 36);
            this.gestionar.TabIndex = 4;
            this.gestionar.Text = "Gestionar Perfil";
            this.gestionar.UseVisualStyleBackColor = true;
            this.gestionar.Click += new System.EventHandler(this.gestionar_Click);
            // 
            // historialpass_but
            // 
            this.historialpass_but.Location = new System.Drawing.Point(172, 226);
            this.historialpass_but.Name = "historialpass_but";
            this.historialpass_but.Size = new System.Drawing.Size(106, 38);
            this.historialpass_but.TabIndex = 5;
            this.historialpass_but.Text = "Historial de Passwords";
            this.historialpass_but.UseVisualStyleBackColor = true;
            this.historialpass_but.Click += new System.EventHandler(this.historialpass_but_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 329);
            this.Controls.Add(this.historialpass_but);
            this.Controls.Add(this.gestionar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button gestionar;
        private System.Windows.Forms.Button historialpass_but;
    }
}