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
        public static List<Venta> GetUsuarios()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=Base_Prueba2;Trusted_Connection=True;";

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
                                    venta.Comentarios = dataReader["Comentarios"].ToString();
                                    venta.idUsuario = dataReader["ID Usuaurio"].ToString();


                                    listVentaData.Add(venta);

                                }

                            }
                            return listVentaData;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                return listVentaData;
            }

        }

        public static List<Venta> GetVentas()
        {
            throw new NotImplementedException();
        }
    }
}