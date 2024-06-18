using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        public static List<Venta> GetVentas()
        {
            return VentaData.GetVentas();

        }
        public static Venta GetVentaById(int id)
        {
            return VentaData.GetVenta(id);
        }

        

    }
}