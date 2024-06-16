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
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba2;Trusted_Connection=True;";

            List<ProductoVendido> listProductoVendidoData = new List<ProductoVendido>();

            string query = "SELECT * FROM ProductoVendido";
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
            catch (Exception)
            {
                return listProductoVendidoData;
            }

        }

        
        public static ProductoVendido GetUsuarios(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Productos Vendido WHERE Id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    var productoVendido = new ProductoVendido();
                    productoVendido.Id = Convert.ToInt32(dataReader["Id"]);
                    /*producto.Descripcion = dataReader["Descripcion"].ToString();*/
                    productoVendido.idProducto = Convert.ToInt32(dataReader["Costo"]);
                    productoVendido.Stock = Convert.ToInt32(dataReader["PrecioVenta"]);
                    productoVendido.idVenta= Convert.ToInt32(dataReader["PrecioVenta"]);

                    return productoVendido;
                }

                throw new Exception("ID NO ENCONTRADO");
            }
        }
    }
}