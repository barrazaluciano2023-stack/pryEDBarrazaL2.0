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
    public partial class frmCola : Form
    {
        // Instancia de la cola
        clsCola cola = new clsCola();
        
        public frmCola()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crear un nuevo nodo con los datos ingresados
            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            nuevo.Nombre = txtNombreNuevo.Text;
            nuevo.Tramite = txtTramiteNuevo.Text;
            cola.Agregar(nuevo);
            cola.Recorrer(dgvDatos);
            cola.Recorrer(lstDatos);
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramiteNuevo.Text = "";
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            // Mostrar los datos del primer nodo antes de eliminarlo
            if (cola.Primero != null)
            {
                lblCodigoEliminado.Text = cola.Primero.Codigo.ToString();
                lblNombreEliminado.Text = cola.Primero.Nombre;
                lblTramiteEliminado.Text = cola.Primero.Tramite;

                // Eliminar el primer nodo
                cola.Eliminar();

                // Actualizar la grilla y la lista
                cola.Recorrer(dgvDatos);
                cola.Recorrer(lstDatos);
                cola.Recorrer();
            }
            else
            {
                lblCodigoEliminado.Text = "";
                lblNombreEliminado.Text = "";
                lblTramiteEliminado.Text = "";
            }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
    }
}
