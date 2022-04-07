namespace FinalProject
{
    partial class Mascotas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewMascotas = new System.Windows.Forms.DataGridView();
            this.labelBuscarMascota = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBuscarMascota = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelAgregarMascota = new System.Windows.Forms.Label();
            this.labelIDmascota = new System.Windows.Forms.Label();
            this.textBoxIDmascota = new System.Windows.Forms.TextBox();
            this.labelNombreMascota = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelEspecie = new System.Windows.Forms.Label();
            this.textBoxEspecie = new System.Windows.Forms.TextBox();
            this.labelRaza = new System.Windows.Forms.Label();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(787, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 455);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 455);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 13);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Location = new System.Drawing.Point(2, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 13);
            this.panel4.TabIndex = 3;
            // 
            // dataGridViewMascotas
            // 
            this.dataGridViewMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMascotas.Location = new System.Drawing.Point(584, 85);
            this.dataGridViewMascotas.Name = "dataGridViewMascotas";
            this.dataGridViewMascotas.Size = new System.Drawing.Size(179, 332);
            this.dataGridViewMascotas.TabIndex = 4;
            // 
            // labelBuscarMascota
            // 
            this.labelBuscarMascota.AutoSize = true;
            this.labelBuscarMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarMascota.Location = new System.Drawing.Point(580, 26);
            this.labelBuscarMascota.Name = "labelBuscarMascota";
            this.labelBuscarMascota.Size = new System.Drawing.Size(124, 20);
            this.labelBuscarMascota.TabIndex = 5;
            this.labelBuscarMascota.Text = "Buscar mascota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Mascota";
            // 
            // textBoxBuscarMascota
            // 
            this.textBoxBuscarMascota.Location = new System.Drawing.Point(653, 56);
            this.textBoxBuscarMascota.Name = "textBoxBuscarMascota";
            this.textBoxBuscarMascota.Size = new System.Drawing.Size(110, 20);
            this.textBoxBuscarMascota.TabIndex = 7;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(19, 16);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(131, 31);
            this.labelTitulo.TabIndex = 8;
            this.labelTitulo.Text = "Mascotas";
            // 
            // labelAgregarMascota
            // 
            this.labelAgregarMascota.AutoSize = true;
            this.labelAgregarMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarMascota.Location = new System.Drawing.Point(26, 85);
            this.labelAgregarMascota.Name = "labelAgregarMascota";
            this.labelAgregarMascota.Size = new System.Drawing.Size(131, 20);
            this.labelAgregarMascota.TabIndex = 9;
            this.labelAgregarMascota.Text = "Agregar mascota";
            this.labelAgregarMascota.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelIDmascota
            // 
            this.labelIDmascota.AutoSize = true;
            this.labelIDmascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDmascota.Location = new System.Drawing.Point(59, 141);
            this.labelIDmascota.Name = "labelIDmascota";
            this.labelIDmascota.Size = new System.Drawing.Size(91, 20);
            this.labelIDmascota.TabIndex = 10;
            this.labelIDmascota.Text = "ID mascota";
            // 
            // textBoxIDmascota
            // 
            this.textBoxIDmascota.Location = new System.Drawing.Point(210, 141);
            this.textBoxIDmascota.Name = "textBoxIDmascota";
            this.textBoxIDmascota.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDmascota.TabIndex = 11;
            // 
            // labelNombreMascota
            // 
            this.labelNombreMascota.AutoSize = true;
            this.labelNombreMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMascota.Location = new System.Drawing.Point(59, 195);
            this.labelNombreMascota.Name = "labelNombreMascota";
            this.labelNombreMascota.Size = new System.Drawing.Size(130, 20);
            this.labelNombreMascota.TabIndex = 12;
            this.labelNombreMascota.Text = "Nombre mascota";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(210, 195);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 13;
            // 
            // labelEspecie
            // 
            this.labelEspecie.AutoSize = true;
            this.labelEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecie.Location = new System.Drawing.Point(59, 246);
            this.labelEspecie.Name = "labelEspecie";
            this.labelEspecie.Size = new System.Drawing.Size(66, 20);
            this.labelEspecie.TabIndex = 14;
            this.labelEspecie.Text = "Especie";
            // 
            // textBoxEspecie
            // 
            this.textBoxEspecie.Location = new System.Drawing.Point(210, 246);
            this.textBoxEspecie.Name = "textBoxEspecie";
            this.textBoxEspecie.Size = new System.Drawing.Size(100, 20);
            this.textBoxEspecie.TabIndex = 15;
            // 
            // labelRaza
            // 
            this.labelRaza.AutoSize = true;
            this.labelRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaza.Location = new System.Drawing.Point(59, 297);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.Size = new System.Drawing.Size(47, 20);
            this.labelRaza.TabIndex = 16;
            this.labelRaza.Text = "Raza";
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Location = new System.Drawing.Point(210, 297);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaza.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Propietario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(210, 351);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonAgregar.Location = new System.Drawing.Point(399, 182);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(119, 46);
            this.buttonAgregar.TabIndex = 20;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonActualizar.Location = new System.Drawing.Point(399, 271);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(119, 46);
            this.buttonActualizar.TabIndex = 21;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.Red;
            this.buttonCancelar.Location = new System.Drawing.Point(25, 409);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(65, 21);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // Mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRaza);
            this.Controls.Add(this.labelRaza);
            this.Controls.Add(this.textBoxEspecie);
            this.Controls.Add(this.labelEspecie);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombreMascota);
            this.Controls.Add(this.textBoxIDmascota);
            this.Controls.Add(this.labelIDmascota);
            this.Controls.Add(this.labelAgregarMascota);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxBuscarMascota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBuscarMascota);
            this.Controls.Add(this.dataGridViewMascotas);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mascotas";
            this.Text = "Mascotas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewMascotas;
        private System.Windows.Forms.Label labelBuscarMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscarMascota;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelAgregarMascota;
        private System.Windows.Forms.Label labelIDmascota;
        private System.Windows.Forms.TextBox textBoxIDmascota;
        private System.Windows.Forms.Label labelNombreMascota;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelEspecie;
        private System.Windows.Forms.TextBox textBoxEspecie;
        private System.Windows.Forms.Label labelRaza;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}