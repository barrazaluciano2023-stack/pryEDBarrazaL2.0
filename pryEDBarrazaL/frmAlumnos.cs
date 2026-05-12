using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDBarrazaL
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.nombreArchivo = "Alumnos.csv";
            x.grabar(txtCodigo.Text + ";" + txtNombreAlumno.Text + ";" + cmbCarrera.Text);
            x.recorrer(dgvAlumnos);
            x.recorrer(cmbCarrera);
            MessageBox.Show("Alumno grabado correctamente");
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.nombreArchivo = "Alumnos.csv";
            if (File.Exists(x.nombreArchivo))
            {
                x.recorrer(dgvAlumnos);
                
            }
            else
            {
                MessageBox.Show("No se encontró el archivo Alumnos.csv");
            }
        }
    }
}
