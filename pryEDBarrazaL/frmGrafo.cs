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
    public partial class frmGrafo : Form
    {
        clsGrafo grafo = new clsGrafo();
        public frmGrafo()
        {
            InitializeComponent();
        }

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            grafo.mostrarCiudades(cmbCargaOrigen);
            grafo.mostrarCiudades(cmbCargaDestino);
            grafo.mostrarCiudades(cmbConsultaOrigen);
            grafo.mostrarCiudades(cmbConsDestino);
            grafo.mostrarCiudades(cmbHasta);
            grafo.mostrarCiudades(cmbDesde);
            grafo.mostrarTodo(dgvViajes);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbCargaOrigen.SelectedIndex;
            Int32 c = cmbCargaDestino.SelectedIndex;
            Decimal p = Convert.ToDecimal(txtPrecio.Text);
            grafo.Agregar(f, c, p);
            grafo.mostrarTodo(dgvViajes);
            txtPrecio.Clear();

        }
    }
}
