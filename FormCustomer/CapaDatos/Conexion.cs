using System.Data.SqlClient;
using System.Configuration;

namespace FormCustomer.CapaDatos
{
    public class Conexion
    {
        public static SqlConnection Connection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConectionString"].ConnectionString;

            SqlConnection con = new(connectionString);

            con.Open();

            return con;
        }
    }
}
