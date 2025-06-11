using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sesion16
{
    public class Estudiante
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private double _promedio;



        //Constructor
        public Estudiante() { }
        public Estudiante(int id, string name, string apellido, double promedio)
        {
            _id = id;
            _nombre = name;
            _apellido = apellido;
            _promedio = promedio;
        }




        /*Métodos públicos SET y GET*/
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public double Promedio { get => _promedio; set => _promedio = value; }



        public void Crear_estudiante(int i, string n, string a, double p)
        {
            _id = i;
            _nombre = n;
            _apellido = a;
            _promedio = p;

            MessageBox.Show("El estudiante fue creado");
        }

        public string Leer_estudiante()
        {
            return  $"ID: {_id}, Nombre: {_nombre}, Apellido: {_apellido}, Promedio: {_promedio}";

        }

        public ListViewItem ToListViewItem()
        {
            var item = new ListViewItem(_id.ToString());
            item.SubItems.Add(_nombre);
            item.SubItems.Add(_apellido);
            item.SubItems.Add(_promedio.ToString("F2"));//Fixed-point de 2 decimales, Redondea aritmeticamente
            return item;
        }



    }
}
