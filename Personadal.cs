using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSofware2
{
    public class Personadal
    {
        public static int AgregarPersona(Persona persona)
        {
            int retorna  = 0;
            using (SqlConnection conexion = base_de_datos_general.ObtenerConexion())
            {
                string query = "insert into estudiantes (nombres,apellidos,grado,celular)values ('" + persona.nombres + "','"+persona.apellidos+"','" + persona.grado + "','" + persona.celular + "')";
                SqlCommand comando = new SqlCommand(query,conexion);
                retorna = comando.ExecuteNonQuery();    
            }
            return retorna;
        }

        public static List<Persona> PresentarRegistro()
        { 
            List<Persona> Lista = new List<Persona>();
            using (SqlConnection conexion = base_de_datos_general.ObtenerConexion())
            {
                string query = "select * from estudiantes";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Persona persona = new Persona();
                    persona.matricula = reader.GetInt32(0);
                    persona.nombres = reader.GetString(1);
                    persona.apellidos = reader.GetString(2);
                    persona.grado = reader.GetString(3);
                    persona.celular = reader.GetString(4);
                    Lista.Add(persona);
                }
                conexion.Close();
                return Lista;
                }
            }
        public static int ModificarPersona(Persona persona)
        {
            int result = 0;
            using (SqlConnection conexion = base_de_datos_general.ObtenerConexion()) 
            {
                string query = "update persona set nombres='" + persona.nombres + "',apellidos='" + persona.apellidos + "', grado='" + persona.grado + "', celular='" + persona.celular + "' where matricula=" + persona.matricula + "";
                SqlCommand comando = new SqlCommand( query, conexion);

                result = comando.ExecuteNonQuery();
               
            }
            return result;
        }
        public static int EliminarPersona(int matricula)
        {
            int retorna = 0;
            using (SqlConnection conexion = base_de_datos_general.ObtenerConexion())
            {
                string query = "delete from persona where matricula= " + matricula + " ";
                SqlCommand comando = new SqlCommand(query, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }


    }
}
    

