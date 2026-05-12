using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDBarrazaL
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
         
        }
        

        private void btnGrabarCliente_Click(object sender, EventArgs e)
        {
            clsArchivoTexto objCLiente= new clsArchivoTexto();
            objCLiente.nombreArchivo = "Clientes.csv";
            objCLiente.grabar(txtCódigoCLiente.Text, txtNombreCliente.Text , txtDeudaCliente.Text);
            objCLiente.recorrer(dgvClientes);
            MessageBox.Show("Cliente grabado correctamente");
            
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.nombreArchivo = "Clientes.csv";
            if(File.Exists(x.nombreArchivo))
            {
                x.recorrer(dgvClientes);
            }
             else
            {
                MessageBox.Show("No se encontró el archivo Clientes.csv");
            }
        }
    }
}
