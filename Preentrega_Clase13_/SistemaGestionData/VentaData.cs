using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using SistemaGestionEntities;

namespace SistemaGestionData
{

    public class VentaData
    {
        public static List<Venta> GetVentas()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba2;Trusted_Connection=True;";

            List<Venta> listVentaData = new List<Venta>();

            string query = "SELECT * FROM Venta ";
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
                                    var venta = new Venta();

                                    venta.Id = Convert.ToInt32(dataReader["Id"]);
                                    venta.Comentario = dataReader["Comentarios"].ToString();
                                    venta.idUsuario = dataReader["ID Usuaurio"].ToString();


                                    listVentaData.Add(venta);

                                }

                            }
                            return listVentaData;
                        }
                    }
                }

            }
            catch (Exception)
            {
                return listVentaData;
            }

        }

        public static Venta GetVenta(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Venta WHERE Id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    var venta = new Venta();
                    venta.Id = Convert.ToInt32(dataReader["Id"]);
                    /*producto.Descripcion = dataReader["Descripcion"].ToString();*/
                    /*venta.Comentario = dataReader["Costo"].ToString(); */
                    /*venta.idUsuario = dataReader["id Usuario"].ToString(); */


                    return venta;
                }

                throw new Exception("ID NO ENCONTRADO");
            }
        }
    }
}