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
        public void MostrarDestinos(DataGridView dgvDestinos)
        {


        }
    }
}
