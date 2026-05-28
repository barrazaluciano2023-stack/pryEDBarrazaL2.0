using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDBarrazaL
{
    internal class clsArbolBinario
    {
        private clsNodo primerNodo;
        public clsNodo Raiz
        {
            get { return primerNodo; }
            set { primerNodo = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
               clsNodo aux = Raiz;
               clsNodo ant = Raiz;
               while(aux != null)
                {
                   ant = aux;
                    if (Nuevo.Codigo < aux.Codigo)
                    {
                        aux = aux.Izquierdo;
                    }
                    else
                    {
                        aux = aux.Derecho;
                    }
                }
               if(Nuevo.Codigo < ant.Codigo)
                {
                    ant.Izquierdo = Nuevo;
                }
                else
                {
                    ant.Derecho = Nuevo;
                }
            }
        }
        public void Recorrer(DataGridView dgv){
            dgv.Rows.Clear();
            InOrdenAsc(Raiz, dgv);
        }
        private void InOrdenAsc(clsNodo raiz, DataGridView dgv)
        {
            if(raiz.Izquierdo != null) 
            {
                InOrdenAsc(raiz.Izquierdo, dgv);
            }
            dgv.Rows.Add(raiz.Codigo, raiz.Nombre, raiz.Tramite);
            if(raiz.Derecho != null)
            {
                InOrdenAsc(raiz.Derecho, dgv);
            }
        }
        
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();

            TreeNode NodoPadre = new TreeNode("Arbol");

            tree.Nodes.Add(NodoPadre);

            if (Raiz != null)
            {
                PreOrden(Raiz, NodoPadre);
            }

            tree.ExpandAll();
        }

        public void PreOrden(clsNodo raiz, TreeNode nodoTreeView)   
        {
            TreeNode Nodopadre = new  TreeNode(raiz.Codigo.ToString());
            nodoTreeView.Nodes.Add(Nodopadre);
            if (raiz.Izquierdo != null)
            {
                PreOrden(raiz.Izquierdo, Nodopadre);
            }
            if (raiz.Derecho != null)
            {
                PreOrden(raiz.Derecho , Nodopadre);
            }

        }
        private clsNodo ObtenerMenor(clsNodo nodo)
        {
            while (nodo.Izquierdo != null)
            {
                nodo = nodo.Izquierdo;
            }

            return nodo;
        }
        private clsNodo EliminarNodo(clsNodo raiz, int codigo)
        {
            if (raiz == null)
            {
                return null;
            }

            if (codigo < raiz.Codigo)
            {
                raiz.Izquierdo = EliminarNodo(raiz.Izquierdo, codigo);
            }
            else if (codigo > raiz.Codigo)
            {
                raiz.Derecho = EliminarNodo(raiz.Derecho, codigo);
            }
            else
            {
                // SIN HIJOS
                if (raiz.Izquierdo == null && raiz.Derecho == null)
                {
                    return null;
                }

                // UN HIJO
                if (raiz.Izquierdo == null)
                {
                    return raiz.Derecho;
                }

                if (raiz.Derecho == null)
                {
                    return raiz.Izquierdo;
                }

                // DOS HIJOS
                clsNodo menor = ObtenerMenor(raiz.Derecho);

                raiz.Codigo = menor.Codigo;
                raiz.Nombre = menor.Nombre;
                raiz.Tramite = menor.Tramite;

                raiz.Derecho = EliminarNodo(raiz.Derecho, menor.Codigo);
            }

            return raiz;
        }
        public void Eliminar(int codigo)
        {
            Raiz = EliminarNodo(Raiz, codigo);
        }
        public void MostrarInOrden(DataGridView dgv)
        {
            dgv.Rows.Clear();
            InOrden(Raiz, dgv);
        }

        private void InOrden(clsNodo raiz, DataGridView dgv)
        {
            if (raiz != null)
            {
                InOrden(raiz.Izquierdo, dgv);

                dgv.Rows.Add(raiz.Codigo, raiz.Nombre, raiz.Tramite);

                InOrden(raiz.Derecho, dgv);
            }
        }
        public void MostrarPreOrden(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PreOrdenListado(Raiz, dgv);
        }

        private void PreOrdenListado(clsNodo raiz, DataGridView dgv)
        {
            if (raiz != null)
            {
                dgv.Rows.Add(raiz.Codigo, raiz.Nombre, raiz.Tramite);

                PreOrdenListado(raiz.Izquierdo, dgv);

                PreOrdenListado(raiz.Derecho, dgv);
            }
        }
        public void MostrarPostOrden(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PostOrden(Raiz, dgv);
        }

        private void PostOrden(clsNodo raiz, DataGridView dgv)
        {
            if (raiz != null)
            {
                PostOrden(raiz.Izquierdo, dgv);

                PostOrden(raiz.Derecho, dgv);

                dgv.Rows.Add(raiz.Codigo, raiz.Nombre, raiz.Tramite);
            }
        }

    }
}
