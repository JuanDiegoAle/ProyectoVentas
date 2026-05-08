using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVentas.Repository
{
    public class UsuarioRepository
    {
        private string connectionString=
            "Server=.;Database=VentasDB;Trusted_Connection=True;";

        public string Login(string username, string password)
        {
            using (SqlConnection conn =
                new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT Rol
            FROM Usuario
            WHERE Username = @Username
            AND Password = @Password";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString(); // "admin" o "vendedor"
                }
                else
                {
                    return ""; // login fallido
                }
            }
        }
    }
}
