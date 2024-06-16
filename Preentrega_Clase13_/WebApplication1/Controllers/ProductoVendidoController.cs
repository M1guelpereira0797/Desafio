using SistemaGestionBussiness;
using SistemaGestionEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {

        [HttpGet(Name = "GetProductoVendido")]
        public IEnumerable<ProductoVendido> usuarios()
        {
            return ProductoVendidoBussiness.GetUsuarios().ToArray();
        }
        [HttpGet("{id}")]
        public IActionResult GetProductoById(int id)
        {
            ProductoVendido producto = ProductoVendidoBussiness.GetUsuarios()[id];

            return Ok(producto);
        }
    }

}