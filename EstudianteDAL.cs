using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Para usar bases de Datos
using System.Data.SqlClient; // Para hacer conexiones con Sql cliente

namespace Sesion16
{

    //cambiamos la clase de internal a public
    //DAL significa Data Access Layer
    public class EstudianteDAL 
    {

        private string _connectionString = "Server=LPDISCESTRADA;Database=DB_UNIVERSIDAD;Trusted_Connection=True;";

        //con SQL Autentication
       // private string _connectionString = "Server=LPDISCESTRADA;Database=DB_UNIVERSIDAD;User Id=myuser;Password=Mypassword1*;";

        public bool GuardarEstudiante(Estudiante est)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarEstudiante", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = est.Id;
                        cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = est.Nombre;
                        cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar, 100).Value = est.Apellido;
                        cmd.Parameters.Add("@Promedio", SqlDbType.Float).Value = est.Promedio;

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        return result > 0; // true si se insertó al menos una fila
                    }
                }
            }
            catch (Exception ex)
            {
                // Aquí puedes loguear o mostrar el error
                System.Windows.Forms.MessageBox.Show("Error al guardar el estudiante: " + ex.Message);
               // Console.WriteLine("Error al guardar el estudiante: " + ex.Message);
                return false;
            }
        }
    }

 }

