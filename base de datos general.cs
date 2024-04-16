using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSofware2
{
    public class base_de_datos_general
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BdMatricula;Data Source=GALAGER");
            conexion.Open();

            return conexion;
        }


    }
}
