using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryEDBarrazaL
{
    internal class clsPila
    {
        private clsNodo pri;
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }


        public void eliminar()
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;
            }
        }


        public void Recorrer(DataGridView dgvDatos)
        {
            clsNodo aux = Primero;
            dgvDatos.Rows.Clear();
            while (aux != null)
            {
                dgvDatos.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox lstDatos)
        {
            clsNodo aux = Primero;
            lstDatos.Items.Clear();
            while (aux != null)
            {
                lstDatos.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox cmbDatos)
        {
            clsNodo aux = Primero;
            cmbDatos.Items.Clear();
            while (aux != null)
            {
                cmbDatos.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(String NombreArchivo)
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("pila.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.WriteLine(aux.Codigo);
                AD.WriteLine(";");
                AD.WriteLine(aux.Nombre);
                AD.WriteLine(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("pila.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.WriteLine(aux.Codigo);
                AD.WriteLine(";");
                AD.WriteLine(aux.Nombre);
                AD.WriteLine(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
    }
}
