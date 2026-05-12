using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Agregamos la librería para trabajar con archivos
using System.Windows.Forms; //Agregamos la librería para trabajar con ListBox

namespace pryEDBarrazaL
{
    internal class clsArchivoTexto
    {
        public string nombreArchivo = "Colores.txt";//Creamos una variable pública para guardar el nombre del archivo

        public void grabar()
        {
            StreamWriter AD = new StreamWriter(nombreArchivo, true); //Abrir AD para escribir en el archivo
            AD.WriteLine("Hola!!!!");//Escribir en el archivo + <ENTER>
            AD.Close(); //Cerrar AD para que se guarde el archivo
        }
        public void grabar(string Dato)
        {
            StreamWriter AD = new StreamWriter(nombreArchivo, true); //Abrir AD para escribir en el archivo
            AD.WriteLine(Dato);//Escribir en el archivo + <ENTER>
            AD.Close(); //Cerrar AD para que se guarde el archivo
        }
        public void grabar(string Codigo, string Nombre)
        {
            StreamWriter AD = new StreamWriter(nombreArchivo, true);//Abrir AD para escribir en el archivo
            AD.Write(Codigo);//Escribir en el archivo sin <ENTER>
            AD.Write(";");//Escribe punto y coma sin <ENTER>
            AD.WriteLine(Nombre);//Escribir en el archivo + <ENTER>
            AD.Close(); //Cerrar AD para que se guarde el archivo
        }

        public void grabar(string Dato1, string Dato2, string Dato3)
        {
            StreamWriter AD = new StreamWriter(nombreArchivo, true); //Abrir AD para escribir en el archivo
            AD.Write(Dato1);//Escribir en el archivo + <ENTER>
            AD.Write(";");//Escribe punto y coma sin <ENTER>
            AD.Write(Dato2);//Escribir en el archivo + <ENTER>
            AD.Write(";");//Escribe punto y coma sin <ENTER>
            AD.WriteLine(Dato3);//Escribir en el archivo + <ENTER>
            AD.Close(); //Cerrar AD para que se guarde el archivo
        }
        public void recorrer(ListBox lst)
        {
            string DatoLeido;
            lst.Items.Clear(); //Limpiar el ListBox para evitar duplicados
            StreamReader AD = new StreamReader(nombreArchivo); //Abrir AD para leer el archivo
            DatoLeido = AD.ReadLine(); //Leer la primera línea del archivo
            while (DatoLeido != null) //Mientras no se llegue al final del archivo
            {
                lst.Items.Add(DatoLeido); //Agregar el dato leído al ListBox
                DatoLeido = AD.ReadLine(); //Leer la siguiente línea del archivo
            }
            AD.Close(); //Cerrar AD para liberar recursos
        }
        public void recorrer(DataGridView Grilla)
        {
            String DatoLeido;
            Grilla.Rows.Clear(); //Limpiar la grilla para evitar duplicados
            StreamReader AD = new StreamReader(nombreArchivo); //Abrir AD para leer el archivo
            DatoLeido = AD.ReadLine(); //Leer la primera línea del archivo
            while (DatoLeido != null)
            {
                Grilla.Rows.Add(DatoLeido.Split(';')); //Agregar el dato leído a la grilla, separando por punto y coma
                DatoLeido = AD.ReadLine(); //Leer la siguiente línea del archivo
            }
            AD.Close(); //Cerrar AD para liberar recursos
        }
        public void recorrer(ComboBox cmb)
        {
            String DatoLeido;
            cmb.Items.Clear(); //Limpiar el ComboBox para evitar duplicados
            StreamReader AD = new StreamReader(nombreArchivo); //Abrir AD para leer el archivo
            DatoLeido = AD.ReadLine(); //Leer la primera línea del archivo
            while (DatoLeido != null)
            {
                cmb.Items.Add(DatoLeido); //Agregar el dato leído al ComboBox
                DatoLeido = AD.ReadLine(); //Leer la siguiente línea del archivo
            }
            AD.Close(); //Cerrar AD para liberar recursos
            cmb.SelectedIndex = 0; //Seleccionar el primer elemento del ComboBox
        }
    }
}
