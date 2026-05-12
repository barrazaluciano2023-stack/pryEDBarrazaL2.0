using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDBarrazaL
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
         public void Agregar(clsNodo nuevo)
         {
                if (pri == null)
                {
                    pri = nuevo;
                    ult = nuevo;
                }
                else
                {
                    if (nuevo.Codigo < pri.Codigo)
                    {
                        nuevo.Siguiente = pri;
                        pri.Anterior = nuevo;
                        pri = nuevo;
                    }
                    else
                    {
                        if (nuevo.Codigo > ult.Codigo)
                        {
                            ult.Siguiente = nuevo;
                            nuevo.Anterior = ult;
                            ult = nuevo;
                        }
                        else
                        {
                            clsNodo aux = pri;
                            clsNodo ant = pri;
                            while (aux.Codigo < nuevo.Codigo)
                            {
                                ant = aux;
                                aux = aux.Siguiente;
                                if (aux == null) break;
                            }
                            nuevo.Siguiente = aux;
                            nuevo.Anterior = aux.Anterior;
                            aux.Anterior.Siguiente = nuevo;
                            aux.Anterior = nuevo;

                        }
                    }
                }
         }
        public void eliminar(Int32 codigo)
        {
            if (Primero.Codigo == codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while (aux.Codigo < codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        aux = aux.Siguiente;
                        aux.Anterior = ant;
                        ant.Siguiente = aux;
                    }
                }
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
                cmbDatos.Items.Add(aux.Codigo);
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
        public void RecorrerDesc(DataGridView dgvDatos)
        {
            clsNodo aux = Ultimo;
            dgvDatos.Rows.Clear();
            while (aux != null)
            {
                dgvDatos.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }

        // Recorrido DESCENDENTE para ListBox
        public void RecorrerDesc(ListBox lstDatos)
        {
            clsNodo aux = Ultimo;
            lstDatos.Items.Clear();
            while (aux != null)
            {
                lstDatos.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }
        public void RecorrerAsc(ComboBox cmbDatos)
        {
            clsNodo aux = Primero;
            cmbDatos.Items.Clear();
            while (aux != null)
            {
                cmbDatos.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerDesc(ComboBox cmbDatos)
        {
            clsNodo aux = Ultimo;
            cmbDatos.Items.Clear();
            while (aux != null)
            {
                cmbDatos.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }
    }
}
