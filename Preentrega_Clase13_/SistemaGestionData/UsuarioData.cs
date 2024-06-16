using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaGestionEntities;

namespace SistemaGestionData
{

    public class UsuarioData
    {
        public static List<Usuario> GetUsuarios()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=Base_Prueba2;Trusted_Connection=True;";

            List<Usuario> listaUsuario = new List<Usuario>();

            string query = "SELECT * FROM Usuario";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                            {
                                while (dataReader.Read())
                                {
                                    var usuario = new Usuario();

                                    usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                    usuario.Nombre = dataReader["Nombre"].ToString();
                                    usuario.Apellido = dataReader["Apellido"].ToString();
                                    usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                    usuario.Contrasena = dataReader["Contraseña"].ToString();
                                    usuario.Mail = dataReader["Mail"].ToString();

                                    listaUsuario.Add(usuario);

                                }

                            }
                            return listaUsuario;
                        }
                    }
                }

            }
            catch (Exception)
            {
                return listaUsuario;
            }

        }
        public static bool CreateUsuario(Usuario usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=Base_Prueba2;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cliente(nombre, apellido, domicilio, telefono) values(@nombre, @apellido, @domicilio, @telefono)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("nombre",usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("domicilio", usuario.Domicilio);
                command.Parameters.AddWithValue("telefono", usuario.Telefono);
                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }

        public static bool DeleteUsuario(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=Base_Prueba2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Usuario WHERE Id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("id", id);

                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool UpdateUsuario(Usuario usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=Base_Prueba2;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Cliente SET nombre = @nombre, apellido = @apellido, domicilio = @domicilio, telefono = @telefono WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("domicilio", usuario.Domicilio);
                command.Parameters.AddWithValue("telefono", usuario.Telefono);
                command.Parameters.AddWithValue("id", usuario.Id);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }

        }
    }
}