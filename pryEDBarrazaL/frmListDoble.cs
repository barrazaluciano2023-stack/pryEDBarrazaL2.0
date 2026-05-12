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
    public partial class frmListDoble : Form
    {
        clsListaDoble listaDoble = new clsListaDoble();
        public frmListDoble()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;
            listaDoble.Agregar(nuevo);
            listaDoble.Recorrer(dgvDatos);
            listaDoble.Recorrer(lstDatos);
            listaDoble.Recorrer(cmbCodigo);
            listaDoble.Recorrer("ArchivoPila.csv");
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void frmListDoble_Load(object sender, EventArgs e)
        {

        }

        private void btbEliminar_Click(object sender, EventArgs e)
        {
            listaDoble.eliminar(Convert.ToInt32(cmbCodigo.Text));
            listaDoble.Recorrer(dgvDatos);
            listaDoble.Recorrer(lstDatos);
            listaDoble.Recorrer(cmbCodigo);
        }
       

        private void rdbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            listaDoble.RecorrerDesc(dgvDatos);
            listaDoble.RecorrerDesc(lstDatos);
            listaDoble.RecorrerDesc(cmbCodigo);
        }

        private void rdbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            listaDoble.Recorrer(dgvDatos);
            listaDoble.Recorrer(lstDatos);
            listaDoble.RecorrerAsc(cmbCodigo);
        }
    }
}
