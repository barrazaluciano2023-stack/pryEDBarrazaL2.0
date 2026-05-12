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
    
    public partial class frmPila : Form
    {
        clsPila pila = new clsPila();
        public frmPila()
        {
            InitializeComponent();
        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crear un nuevo nodo con los datos ingresados
            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;
            pila.Agregar(nuevo);
            pila.Recorrer(dgvDatos);
            pila.Recorrer(lstDatos);
            pila.Recorrer("ArchivoPila.csv"); 
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btbEliminar_Click(object sender, EventArgs e)
        {

            // Mostrar los datos del primer nodo antes de eliminarlo
            if (pila.Primero != null)
            {
                lblCodigoEliminado.Text = pila.Primero.Codigo.ToString();
                lblNombreEliminado.Text = pila.Primero.Nombre;
                lblTramiteEliminado.Text = pila.Primero.Tramite;

                // Eliminar el primer nodo
                pila.eliminar();

                // Actualizar la grilla y la lista
                pila.Recorrer(dgvDatos);
                pila.Recorrer(lstDatos);
                pila.Recorrer();
            }
            else
            {
                lblCodigoEliminado.Text = "";
                lblNombreEliminado.Text = "";
                lblTramiteEliminado.Text = "";
            }
        }

        private void lblTramiteEliminado_Click(object sender, EventArgs e)
        {

        }
    }
}
