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
               while(aux != null){
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
        
    }
}
