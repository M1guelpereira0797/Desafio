using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaGestionEntities;

namespace SistemaGestionData
{

    public class ProductoVendidoData
    {
        public static List<ProductoVendido> GetUsuarios()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=Base_Prueba2;Trusted_Connection=True;";

            List<ProductoVendido> listProductoVendidoData = new List<ProductoVendido>();

            string query = "SELECT * FROM Producto Vendido";
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
                                    var producto = new ProductoVendido();

                                    producto.Id = Convert.ToInt32(dataReader["Id"]);
                                    producto.idProducto = Convert.ToInt32(dataReader["ID Producto"]);
                                    producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                                    producto.idVenta = Convert.ToInt32(dataReader["id Venta"]);


                                    listProductoVendidoData.Add(producto);

                                }

                            }
                            return listProductoVendidoData;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                return listProductoVendidoData;
            }

        }
    }
}