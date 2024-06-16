using SistemaGestionBussiness;
using SistemaGestionEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {

        [HttpGet(Name = "GetVenta")]
        public IEnumerable<Venta> ventas()
        {
            return VentaBussiness.GetVentas().ToArray();
        }
        [HttpGet("{id}")]
        public IActionResult GetVetnasById(int id)
        {
            Venta ventas = VentaBussiness.GetVentas()[id];

            return Ok(ventas);
        }
    }
}
