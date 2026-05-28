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
            cmbEliminar.Items.Add(nuevo.Codigo);
            clsArbolBinario.Recorrer(dgvArbol);
            clsArbolBinario.Recorrer(treeArbol);
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void rdbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPreOrden.Checked)
            {
                clsArbolBinario.MostrarPreOrden(dgvArbol);
            }
        }

        private void rdbInOrden_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbInOrden.Checked)
            {
                clsArbolBinario.MostrarInOrden(dgvArbol);
            }
        }

        private void rdbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPostOrden.Checked)
            {
                clsArbolBinario.MostrarPostOrden(dgvArbol);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(cmbEliminar.Text);

            clsArbolBinario.Eliminar(codigo);

            clsArbolBinario.Recorrer(treeArbol);

            clsArbolBinario.MostrarInOrden(dgvArbol);
          
            cmbEliminar.Items.Remove(codigo);
        }
    }
}
