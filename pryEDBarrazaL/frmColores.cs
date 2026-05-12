using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDBarrazaL 
{
    public partial class frmColores : Form
    {
        public frmColores()
        {
            clsArchivoTexto x = new clsArchivoTexto();
            InitializeComponent();
            x.recorrer(lstColores);
        }

        private void btnGrabarColor_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.nombreArchivo = "Colores.csv";
            x.grabar(txtNombreColor.Text);
            x.recorrer(lstColores);
            MessageBox.Show("Dato grabado correctamente");
        }
    }
}
