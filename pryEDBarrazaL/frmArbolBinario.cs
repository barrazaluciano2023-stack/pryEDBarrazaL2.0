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
    public partial class frmArbolBinario : Form
    {
        clsArbolBinario clsArbolBinario = new clsArbolBinario();
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;
            clsArbolBinario.Agregar(nuevo);
            clsArbolBinario.Recorrer(dgvArbol);
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }
    }
}
