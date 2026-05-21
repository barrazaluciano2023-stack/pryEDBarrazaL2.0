namespace pryEDBarrazaL
{
    partial class frmGrafo
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbCargaOrigen = new System.Windows.Forms.ComboBox();
            this.cmbCargaDestino = new System.Windows.Forms.ComboBox();
            this.cmbcargaPrecio = new System.Windows.Forms.ComboBox();
            this.cmbConsultaOrigen = new System.Windows.Forms.ComboBox();
            this.cmbConsDestino = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnConsBorrar = new System.Windows.Forms.Button();
            this.btnConsConsultar = new System.Windows.Forms.Button();
            this.txtConsDatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnlistarDestinos = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.btnListarViajes = new System.Windows.Forms.Button();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cordoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mendoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SantaFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuenosAires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListarViajes);
            this.groupBox1.Controls.Add(this.btnListarOrigenes);
            this.groupBox1.Controls.Add(this.btnlistarDestinos);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbHasta);
            this.groupBox1.Controls.Add(this.cmbDesde);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(35, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar viajes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnBorrarTodo);
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Controls.Add(this.cmbcargaPrecio);
            this.groupBox2.Controls.Add(this.cmbCargaDestino);
            this.groupBox2.Controls.Add(this.cmbCargaOrigen);
            this.groupBox2.Location = new System.Drawing.Point(299, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carga de Datos:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtConsDatos);
            this.groupBox3.Controls.Add(this.btnConsConsultar);
            this.groupBox3.Controls.Add(this.btnConsBorrar);
            this.groupBox3.Controls.Add(this.cmbConsDestino);
            this.groupBox3.Controls.Add(this.cmbConsultaOrigen);
            this.groupBox3.Location = new System.Drawing.Point(560, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta de Datos:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cmbCargaOrigen
            // 
            this.cmbCargaOrigen.FormattingEnabled = true;
            this.cmbCargaOrigen.Location = new System.Drawing.Point(81, 28);
            this.cmbCargaOrigen.Name = "cmbCargaOrigen";
            this.cmbCargaOrigen.Size = new System.Drawing.Size(152, 21);
            this.cmbCargaOrigen.TabIndex = 0;
            // 
            // cmbCargaDestino
            // 
            this.cmbCargaDestino.FormattingEnabled = true;
            this.cmbCargaDestino.Location = new System.Drawing.Point(81, 73);
            this.cmbCargaDestino.Name = "cmbCargaDestino";
            this.cmbCargaDestino.Size = new System.Drawing.Size(152, 21);
            this.cmbCargaDestino.TabIndex = 1;
            // 
            // cmbcargaPrecio
            // 
            this.cmbcargaPrecio.FormattingEnabled = true;
            this.cmbcargaPrecio.Location = new System.Drawing.Point(81, 114);
            this.cmbcargaPrecio.Name = "cmbcargaPrecio";
            this.cmbcargaPrecio.Size = new System.Drawing.Size(152, 21);
            this.cmbcargaPrecio.TabIndex = 2;
            // 
            // cmbConsultaOrigen
            // 
            this.cmbConsultaOrigen.FormattingEnabled = true;
            this.cmbConsultaOrigen.Location = new System.Drawing.Point(69, 28);
            this.cmbConsultaOrigen.Name = "cmbConsultaOrigen";
            this.cmbConsultaOrigen.Size = new System.Drawing.Size(152, 21);
            this.cmbConsultaOrigen.TabIndex = 3;
            // 
            // cmbConsDestino
            // 
            this.cmbConsDestino.FormattingEnabled = true;
            this.cmbConsDestino.Location = new System.Drawing.Point(69, 73);
            this.cmbConsDestino.Name = "cmbConsDestino";
            this.cmbConsDestino.Size = new System.Drawing.Size(152, 21);
            this.cmbConsDestino.TabIndex = 4;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(126, 146);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(95, 38);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(25, 146);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(95, 38);
            this.btnBorrarTodo.TabIndex = 4;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnConsBorrar
            // 
            this.btnConsBorrar.Location = new System.Drawing.Point(126, 145);
            this.btnConsBorrar.Name = "btnConsBorrar";
            this.btnConsBorrar.Size = new System.Drawing.Size(95, 38);
            this.btnConsBorrar.TabIndex = 5;
            this.btnConsBorrar.Text = "Borrar";
            this.btnConsBorrar.UseVisualStyleBackColor = true;
            // 
            // btnConsConsultar
            // 
            this.btnConsConsultar.Location = new System.Drawing.Point(25, 145);
            this.btnConsConsultar.Name = "btnConsConsultar";
            this.btnConsConsultar.Size = new System.Drawing.Size(95, 38);
            this.btnConsConsultar.TabIndex = 6;
            this.btnConsConsultar.Text = "Consultar";
            this.btnConsConsultar.UseVisualStyleBackColor = true;
            // 
            // txtConsDatos
            // 
            this.txtConsDatos.Location = new System.Drawing.Point(69, 114);
            this.txtConsDatos.Name = "txtConsDatos";
            this.txtConsDatos.Size = new System.Drawing.Size(152, 20);
            this.txtConsDatos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Origen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Origen,
            this.Cordoba,
            this.Mendoza,
            this.SantaFe,
            this.BuenosAires,
            this.Salta});
            this.dataGridView1.Location = new System.Drawing.Point(20, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbDesde
            // 
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(73, 15);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(128, 21);
            this.cmbDesde.TabIndex = 8;
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(362, 15);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(152, 21);
            this.cmbHasta.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Desde:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Hasta:";
            // 
            // btnlistarDestinos
            // 
            this.btnlistarDestinos.Location = new System.Drawing.Point(218, 15);
            this.btnlistarDestinos.Name = "btnlistarDestinos";
            this.btnlistarDestinos.Size = new System.Drawing.Size(92, 24);
            this.btnlistarDestinos.TabIndex = 11;
            this.btnlistarDestinos.Text = "Listar Destinos";
            this.btnlistarDestinos.UseVisualStyleBackColor = true;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(525, 17);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(92, 24);
            this.btnListarOrigenes.TabIndex = 12;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // btnListarViajes
            // 
            this.btnListarViajes.Location = new System.Drawing.Point(623, 17);
            this.btnListarViajes.Name = "btnListarViajes";
            this.btnListarViajes.Size = new System.Drawing.Size(114, 23);
            this.btnListarViajes.TabIndex = 13;
            this.btnListarViajes.Text = "Ver todos los viajes";
            this.btnListarViajes.UseVisualStyleBackColor = true;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            // 
            // Cordoba
            // 
            this.Cordoba.HeaderText = "Cordoba";
            this.Cordoba.Name = "Cordoba";
            // 
            // Mendoza
            // 
            this.Mendoza.HeaderText = "Mendoza";
            this.Mendoza.Name = "Mendoza";
            // 
            // SantaFe
            // 
            this.SantaFe.HeaderText = "Santa Fe";
            this.SantaFe.Name = "SantaFe";
            // 
            // BuenosAires
            // 
            this.BuenosAires.HeaderText = "Buenos Aires";
            this.BuenosAires.Name = "BuenosAires";
            // 
            // Salta
            // 
            this.Salta.HeaderText = "Salta";
            this.Salta.Name = "Salta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDBarrazaL.Properties.Resources.grafo_a1;
            this.pictureBox1.Location = new System.Drawing.Point(35, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGrafo";
            this.Text = "frmGrafo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cmbcargaPrecio;
        private System.Windows.Forms.ComboBox cmbCargaDestino;
        private System.Windows.Forms.ComboBox cmbCargaOrigen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConsDatos;
        private System.Windows.Forms.Button btnConsConsultar;
        private System.Windows.Forms.Button btnConsBorrar;
        private System.Windows.Forms.ComboBox cmbConsDestino;
        private System.Windows.Forms.ComboBox cmbConsultaOrigen;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnListarViajes;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.Button btnlistarDestinos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cordoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mendoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn SantaFe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuenosAires;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salta;
    }
}