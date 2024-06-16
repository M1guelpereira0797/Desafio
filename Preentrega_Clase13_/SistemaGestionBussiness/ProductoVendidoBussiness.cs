using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> GetUsuarios()
        {
            return ProductoVendidoData.GetUsuarios();

        }
        public static ProductoVendido GetUsuariosById(int id)
        {
            return ProductoVendidoData.GetUsuarios(id);
        }

    }
}