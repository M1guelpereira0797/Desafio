using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;


namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        public static List<Producto> GetProductos()
        {
            return ProductoData.GetProductos();

        }

    }
}