using SistemaGestionBussiness;
using SistemaGestionEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ClienteController : ControllerBase
        {
            [HttpGet(Name = "GetCliente")]
            public IEnumerable<Usuario> usuarios()
            {
                return UsuarioBussiness.GetUsuarios().ToArray();
            }

            [HttpDelete(Name = "EliminarCliente")]
            public void Delete([FromBody] int id)
            {
                UsuarioBussiness.EliminarUsuario(id);
            }
            [HttpPut(Name = "ModificarCliente")]
            public void Put([FromBody] Usuario usuario)
            {
                UsuarioBussiness.ModificarUsuario(usuario);
            }
            [HttpPost(Name = "AltaCliente")]
            public void Post([FromBody] Usuario usuario)
            {
                UsuarioBussiness.AltaUsuario(usuario);

            }

        }
    }