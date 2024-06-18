using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {
        public static List<Usuario> GetUsuarios()
        {
            return UsuarioData.GetUsuarios();

        }
        public static void AltaUsuario(Usuario usuario)
        {
            UsuarioData.CreateUsuario(usuario);
        }

        public static void EliminarUsuario(int id)
        {
            UsuarioData.DeleteUsuario(id);
        }

        public static Usuario GetUsuarioById(int Id)
        {
            return UsuarioData.GetUsuario(Id);
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            UsuarioData.UpdateUsuario(usuario);
        }
    }

}
