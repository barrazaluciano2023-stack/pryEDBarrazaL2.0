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
    public partial class frmListSimple : Form
    {
        public frmListSimple()
        {
            InitializeComponent();
        }
        clsListaSimple listaSimple = new clsListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crear un nuevo nodo con los datos ingresados
            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            nuevo.Nombre = txtNombreNuevo.Text;
            nuevo.Tramite = txtTramiteNuevo.Text;
            listaSimple.Agregar(nuevo);
            listaSimple.Recorrer(dgvDatos);
            listaSimple.Recorrer(lstDatos);
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramiteNuevo.Text = "";
        }

        private void frmListSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
