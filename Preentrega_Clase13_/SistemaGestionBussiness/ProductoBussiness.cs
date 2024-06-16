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
        public static Producto GetProductoById(int Id)
        {
            return ProductoData.GetProducto(Id);
        }
        public static List<Producto> GetProductos()
        {
            return ProductoData.GetProductos();
        }
        public static bool AltaProducto(Producto producto)
        {
            return ProductoData.CreateProducto(producto);
        }
        public static bool BorrarProducto(int Id)
        {
            return ProductoData.DeleteProducto(Id);
        }
        public static bool ModificarProducto(Producto producto)
        {
            return ProductoData.EditProducto(producto);
        }
    }
}