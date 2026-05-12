namespace pryEDBarrazaL
{
    partial class frmColores
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnGrabarColor = new System.Windows.Forms.Button();
            this.lstColores = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(97, 135);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(84, 37);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnGrabarColor
            // 
            this.btnGrabarColor.Location = new System.Drawing.Point(262, 135);
            this.btnGrabarColor.Name = "btnGrabarColor";
            this.btnGrabarColor.Size = new System.Drawing.Size(84, 37);
            this.btnGrabarColor.TabIndex = 1;
            this.btnGrabarColor.Text = "Grabar";
            this.btnGrabarColor.UseVisualStyleBackColor = true;
            this.btnGrabarColor.Click += new System.EventHandler(this.btnGrabarColor_Click);
            // 
            // lstColores
            // 
            this.lstColores.FormattingEnabled = true;
            this.lstColores.Location = new System.Drawing.Point(97, 210);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(249, 121);
            this.lstColores.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(94, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombreColor
            // 
            this.txtNombreColor.Location = new System.Drawing.Point(169, 76);
            this.txtNombreColor.Name = "txtNombreColor";
            this.txtNombreColor.Size = new System.Drawing.Size(177, 20);
            this.txtNombreColor.TabIndex = 4;
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.txtNombreColor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lstColores);
            this.Controls.Add(this.btnGrabarColor);
            this.Controls.Add(this.btnListar);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnGrabarColor;
        private System.Windows.Forms.ListBox lstColores;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreColor;
    }
}