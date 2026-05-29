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
            this.btnListarViajes = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.btnlistarDestinos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cordoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mendoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SantaFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuenosAires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cmbCargaDestino = new System.Windows.Forms.ComboBox();
            this.cmbCargaOrigen = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConsDatos = new System.Windows.Forms.TextBox();
            this.btnConsConsultar = new System.Windows.Forms.Button();
            this.btnConsBorrar = new System.Windows.Forms.Button();
            this.cmbConsDestino = new System.Windows.Forms.ComboBox();
            this.cmbConsultaOrigen = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.dgvViajes);
            this.groupBox1.Location = new System.Drawing.Point(47, 274);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1004, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar viajes";
            // 
            // btnListarViajes
            // 
            this.btnListarViajes.Location = new System.Drawing.Point(831, 21);
            this.btnListarViajes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarViajes.Name = "btnListarViajes";
            this.btnListarViajes.Size = new System.Drawing.Size(152, 28);
            this.btnListarViajes.TabIndex = 13;
            this.btnListarViajes.Text = "Ver todos los viajes";
            this.btnListarViajes.UseVisualStyleBackColor = true;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(700, 21);
            this.btnListarOrigenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(123, 30);
            this.btnListarOrigenes.TabIndex = 12;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // btnlistarDestinos
            // 
            this.btnlistarDestinos.Location = new System.Drawing.Point(291, 18);
            this.btnlistarDestinos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlistarDestinos.Name = "btnlistarDestinos";
            this.btnlistarDestinos.Size = new System.Drawing.Size(123, 30);
            this.btnlistarDestinos.TabIndex = 11;
            this.btnlistarDestinos.Text = "Listar Destinos";
            this.btnlistarDestinos.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Hasta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Desde:";
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(483, 18);
            this.cmbHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(201, 24);
            this.cmbHasta.TabIndex = 9;
            // 
            // cmbDesde
            // 
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(97, 18);
            this.cmbDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(169, 24);
            this.cmbDesde.TabIndex = 8;
            // 
            // dgvViajes
            // 
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Origen,
            this.Cordoba,
            this.Mendoza,
            this.SantaFe,
            this.BuenosAires,
            this.Salta});
            this.dgvViajes.Location = new System.Drawing.Point(27, 58);
            this.dgvViajes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.RowHeadersWidth = 51;
            this.dgvViajes.Size = new System.Drawing.Size(949, 185);
            this.dgvViajes.TabIndex = 0;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.MinimumWidth = 6;
            this.Origen.Name = "Origen";
            this.Origen.Width = 125;
            // 
            // Cordoba
            // 
            this.Cordoba.HeaderText = "Cordoba";
            this.Cordoba.MinimumWidth = 6;
            this.Cordoba.Name = "Cordoba";
            this.Cordoba.Width = 125;
            // 
            // Mendoza
            // 
            this.Mendoza.HeaderText = "Mendoza";
            this.Mendoza.MinimumWidth = 6;
            this.Mendoza.Name = "Mendoza";
            this.Mendoza.Width = 125;
            // 
            // SantaFe
            // 
            this.SantaFe.HeaderText = "Santa Fe";
            this.SantaFe.MinimumWidth = 6;
            this.SantaFe.Name = "SantaFe";
            this.SantaFe.Width = 125;
            // 
            // BuenosAires
            // 
            this.BuenosAires.HeaderText = "Buenos Aires";
            this.BuenosAires.MinimumWidth = 6;
            this.BuenosAires.Name = "BuenosAires";
            this.BuenosAires.Width = 125;
            // 
            // Salta
            // 
            this.Salta.HeaderText = "Salta";
            this.Salta.MinimumWidth = 6;
            this.Salta.Name = "Salta";
            this.Salta.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnBorrarTodo);
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Controls.Add(this.cmbCargaDestino);
            this.groupBox2.Controls.Add(this.cmbCargaOrigen);
            this.groupBox2.Location = new System.Drawing.Point(399, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(319, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carga de Datos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Origen:";
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(33, 180);
            this.btnBorrarTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(127, 47);
            this.btnBorrarTodo.TabIndex = 4;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(168, 180);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(127, 47);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cmbCargaDestino
            // 
            this.cmbCargaDestino.FormattingEnabled = true;
            this.cmbCargaDestino.Location = new System.Drawing.Point(108, 90);
            this.cmbCargaDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCargaDestino.Name = "cmbCargaDestino";
            this.cmbCargaDestino.Size = new System.Drawing.Size(201, 24);
            this.cmbCargaDestino.TabIndex = 1;
            // 
            // cmbCargaOrigen
            // 
            this.cmbCargaOrigen.FormattingEnabled = true;
            this.cmbCargaOrigen.Location = new System.Drawing.Point(108, 34);
            this.cmbCargaOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCargaOrigen.Name = "cmbCargaOrigen";
            this.cmbCargaOrigen.Size = new System.Drawing.Size(201, 24);
            this.cmbCargaOrigen.TabIndex = 0;
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
            this.groupBox3.Location = new System.Drawing.Point(747, 27);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(303, 233);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta de Datos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Origen:";
            // 
            // txtConsDatos
            // 
            this.txtConsDatos.Location = new System.Drawing.Point(92, 140);
            this.txtConsDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConsDatos.Name = "txtConsDatos";
            this.txtConsDatos.Size = new System.Drawing.Size(201, 22);
            this.txtConsDatos.TabIndex = 7;
            // 
            // btnConsConsultar
            // 
            this.btnConsConsultar.Location = new System.Drawing.Point(33, 178);
            this.btnConsConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsConsultar.Name = "btnConsConsultar";
            this.btnConsConsultar.Size = new System.Drawing.Size(127, 47);
            this.btnConsConsultar.TabIndex = 6;
            this.btnConsConsultar.Text = "Consultar";
            this.btnConsConsultar.UseVisualStyleBackColor = true;
            // 
            // btnConsBorrar
            // 
            this.btnConsBorrar.Location = new System.Drawing.Point(168, 178);
            this.btnConsBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsBorrar.Name = "btnConsBorrar";
            this.btnConsBorrar.Size = new System.Drawing.Size(127, 47);
            this.btnConsBorrar.TabIndex = 5;
            this.btnConsBorrar.Text = "Borrar";
            this.btnConsBorrar.UseVisualStyleBackColor = true;
            // 
            // cmbConsDestino
            // 
            this.cmbConsDestino.FormattingEnabled = true;
            this.cmbConsDestino.Location = new System.Drawing.Point(92, 90);
            this.cmbConsDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbConsDestino.Name = "cmbConsDestino";
            this.cmbConsDestino.Size = new System.Drawing.Size(201, 24);
            this.cmbConsDestino.TabIndex = 4;
            // 
            // cmbConsultaOrigen
            // 
            this.cmbConsultaOrigen.FormattingEnabled = true;
            this.cmbConsultaOrigen.Location = new System.Drawing.Point(92, 34);
            this.cmbConsultaOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbConsultaOrigen.Name = "cmbConsultaOrigen";
            this.cmbConsultaOrigen.Size = new System.Drawing.Size(201, 24);
            this.cmbConsultaOrigen.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDBarrazaL.Properties.Resources.grafo_a1;
            this.pictureBox1.Location = new System.Drawing.Point(47, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(108, 147);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(201, 22);
            this.txtPrecio.TabIndex = 8;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 579);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGrafo";
            this.Text = "S";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnCargar;
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
        private System.Windows.Forms.TextBox txtPrecio;
    }
}