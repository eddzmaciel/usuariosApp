namespace usuariosApp
{
    partial class historialpasswords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historialpasswords));
            this.verhistorial = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // verhistorial
            // 
            this.verhistorial.Location = new System.Drawing.Point(39, 93);
            this.verhistorial.Name = "verhistorial";
            this.verhistorial.Size = new System.Drawing.Size(75, 23);
            this.verhistorial.TabIndex = 0;
            this.verhistorial.Text = "Ver Historial";
            this.verhistorial.UseVisualStyleBackColor = true;
            this.verhistorial.Click += new System.EventHandler(this.verhistorial_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 258);
            this.dataGridView1.TabIndex = 1;
            // 
            // regresar
            // 
            this.regresar.Location = new System.Drawing.Point(425, 396);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(111, 23);
            this.regresar.TabIndex = 2;
            this.regresar.Text = "Menu Principal";
            this.regresar.UseVisualStyleBackColor = true;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(234, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 127);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // historialpasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.verhistorial);
            this.Name = "historialpasswords";
            this.Text = "historialpasswords";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button verhistorial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}