using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace pryEDBarrazaL
{
    internal class clsGrafo
    {
        //vector
        private String[] ciudades = new string[] {"Cordoba"," Mendoza"," Santa Fe"," Buenos Aires","Salta"};
        //matriz
        private Decimal[,] Precio = new Decimal[5, 5];
        public void Agregar(Int32 f, Int32 c, Decimal p)
        {
            Precio[f, c] = p;
        }
        public void Eliminar(Int32 f, Int32 c)
        {
            Precio[f, c] = 0;
        }
        public decimal Consultar(Int32 f , Int32 c)
        {
            return Precio[f, c];
        }


        public void BorrarTodo()
        {
            for (Int32 f = 0; f < 5; f++)
            {
                for (Int32 c = 0; c < 5; c++)
                {
                    Precio[f,c] = 0;
                }
            }
        }
        public void MostrarDestinos(Int32 f ,DataGridView dgvDestinos)
        {
            dgvDestinos.Rows.Clear();
            dgvDestinos.Columns.Clear();
            //agregar columnas manual mente
            dgvDestinos.Columns.Add("Col1", "Destino");
            dgvDestinos.Columns.Add("Col2", "Precio");
            dgvDestinos.Columns[0].Width = 200;
            dgvDestinos.Columns[1].Width = 200;
            dgvDestinos.Rows.Clear();

            for (Int32 c = 0; c < 5; c++)
            {
                if (Precio[f, c] > 0)
                {
                    dgvDestinos.Rows.Add(ciudades[c], Precio[f, c]);
                }
            }

        }

        public void MostrarOrigenes(Int32 c, DataGridView dgvOrigenes)
        {
            dgvOrigenes.Rows.Clear();
            dgvOrigenes.Columns.Clear();
            //agregar columnas manual mente
            dgvOrigenes.Columns.Add("Col1", "Origen");
            dgvOrigenes.Columns.Add("Col2", "Precio");
            dgvOrigenes.Columns[0].Width = 200;
            dgvOrigenes.Columns[1].Width = 200;
            dgvOrigenes.Rows.Clear();
            for (Int32 f = 0; f < 5; f++)
            {
                if (Precio[f, c] >  0)
                {
                    dgvOrigenes.Rows.Add(ciudades[f], Precio[f, c]);
                }
            }
        }
        public void mostrarTodo(DataGridView dgvViajes)
        {
            dgvViajes.Rows.Clear();
            dgvViajes.Columns.Clear();
            //agregar columnas manual mente
            dgvViajes.Columns.Add("Col1", "Origen");
            for (Int32 i = 0; i < 5; i++)
            {
                dgvViajes.Columns.Add("Destino" + i.ToString(), ciudades[i]);
            }
            for(Int32 f = 0; f < 5; f++) 
            {
                dgvViajes.Rows.Add(ciudades[f]);
                for(Int32 c = 0; c < 5; c++)
                {
                    dgvViajes.Rows[f].Cells[c + 1].Value = Precio[f, c];
                }
            }
        }
        public void mostrarCiudades(ComboBox cmbCiudad)
        {
            cmbCiudad.Items.Clear();
            for (Int32 i = 0; i < 5; i++)
            {
                cmbCiudad.Items.Add(ciudades[i]);
            }
            cmbCiudad.SelectedIndex = 0;
        }
    }
}


