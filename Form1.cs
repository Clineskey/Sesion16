using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// Librería que permite el manejo de archivos

namespace Sesion16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // this.Load += Form1_Load; //Esto llama al método, no necesario porque se verá una sola vez abajo

            /*Usamos la clase TexWriter para crear un archivo donde guardaremos
           * la información que requiramos.
           * la clase StreamWriter nos permite guardar la dirección del archivo
           * y se coloco acá por ser el constructor de la form
           * */
            TextWriter Escribir = new StreamWriter("Estudiante.txt");
            Escribir.Close();
            MessageBox.Show("Tu archivo ha sido creado");

/*
            
             if (!File.Exists("Estudiante.txt"))
{
    TextWriter Escribir = new StreamWriter("Estudiante.txt");
    Escribir.WriteLine("Archivo creado por primera vez.");
    Escribir.Close();
    MessageBox.Show("Tu archivo ha sido creado");
}
else
{
    MessageBox.Show("El archivo ya existe y no fue modificado.");
}
            */


        }

        private void Bt_Crear_Click(object sender, EventArgs e)
        {
            Estudiante estu1 = new Estudiante();

            /*Por motivos de tiempo de eplicación lo siguiente no tiene validaciones
             * pero recuerde que siempre tiene que llevar validaciones, por seguridad
              */
            int id_o =Convert.ToInt32(Tx_Id.Text);
            string nombre=Tx_Nombre.Text;
            string apellido=Tx_Apellido.Text;
            double promedio =Convert.ToDouble(Tx_Promedio.Text);

            estu1.Crear_estudiante(id_o, nombre, apellido, promedio);

            // Crear instancia del DAL
            EstudianteDAL estudianteDAL = new EstudianteDAL();


            // Guardar en la base de datos
            bool exito = estudianteDAL.GuardarEstudiante(estu1);

            if (exito)
            {
                MessageBox.Show("Estudiante guardado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al guardar el estudiante xx.");
            }


            //-------------------------------------------------------------------

            //Agregamos los datos a un listview
            Lvw_Estudiante.Items.Add(estu1.ToListViewItem());


            //Agregamos los datos a una variable
            //string dato_estudiante = estu1.Leer_estudiante();
            //MessageBox.Show(dato_estudiante);

          
            // Escribir.WriteLine(dato_estudiante);
            //Escribir.WriteLine(estu1.Leer_estudiante());
            //Escribir.Close();

            //Para Agregar más líneas o más estudiantes al documento

            using (StreamWriter agrega = File.AppendText("Estudiante.txt"))
            {
                agrega.WriteLine(estu1.Leer_estudiante());
                agrega.Close();
            }


            Tx_Id.Clear();
            Tx_Nombre.Clear();
            Tx_Apellido.Clear();
            Tx_Promedio.Clear();
            Tx_Id.Focus();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lvw_Estudiante.Columns.Clear();  // Limpia columnas para no duplicar
            Lvw_Estudiante.View = View.Details;
            Lvw_Estudiante.Columns.Add("ID", 50);
            Lvw_Estudiante.Columns.Add("Nombre", 100);
            Lvw_Estudiante.Columns.Add("Apellido", 100);
            Lvw_Estudiante.Columns.Add("Promedio", 70);



        }


        /*
        if (!File.Exists("Estudiante.txt"))
{
    using (StreamWriter sw = new StreamWriter("Estudiante.txt"))
    {
        sw.WriteLine("Encabezados opcionales si quieres");
    }
}

// Luego agregas el estudiante
using (StreamWriter sw = File.AppendText("Estudiante.txt"))
{
    sw.WriteLine(estu1.Leer_estudiante());
}

*/









    }
}
