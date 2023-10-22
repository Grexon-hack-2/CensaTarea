using FormCustomer.CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace FormCustomer.CapaDatos
{
    public class Execute
    {
        public DataTable GetAllCustomers()
        {
            try
            {
                SqlConnection conexion = Conexion.Connection();
                string query = "SELECT * FROM Clientes;";

                SqlDataAdapter dataAdapter = new(query, conexion);

                DataTable dt = new();

                dataAdapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error En la base de datos: {ex}");
            }

        }

        public bool InsertCustomer(CustomerModel customer)
        {
            SqlConnection conexion = Conexion.Connection();
            string query = "INSERT INTO Clientes VALUES(@ID, @Name, @LastName, @Picture);";
            SqlCommand cmd = new(query, conexion);
            cmd.Parameters.AddWithValue("@ID", customer.ID);
            cmd.Parameters.AddWithValue("@Name", customer.Name);
            cmd.Parameters.AddWithValue("@LastName", customer.LastName);
            cmd.Parameters.AddWithValue("@Picture", customer.Picture);

            if (cmd.ExecuteNonQuery() > 0) return true;
            else return false;
        }

        public bool UpdateCustomer(CustomerModel customer, string id)
        {
            SqlConnection conexion = Conexion.Connection();
            string query = "UPDATE Clientes SET Name = @Name, last_Name = @LastName, Picture = @Picture WHERE ID = @ID;";
            SqlCommand cmd = new(query, conexion);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Name", customer.Name);
            cmd.Parameters.AddWithValue("@LastName", customer.LastName);
            cmd.Parameters.AddWithValue("@Picture", customer.Picture);

            if (cmd.ExecuteNonQuery() > 0) return true;
            else return false;
        }

        public bool DeleteCustomer(string ID)
        {
            SqlConnection conexion = Conexion.Connection();
            string query = "DELETE FROM Clientes WHERE ID = @ID;";
            SqlCommand cmd = new(query, conexion);
            cmd.Parameters.AddWithValue("@ID", ID);

            if (cmd.ExecuteNonQuery() > 0) return true;
            else return false;
        }

    }
}