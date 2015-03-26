using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiMusica.Persistencia
{
    public class UsuarioRepositorio
    {
        private MiMusicaContexto contexto;

        public UsuarioRepositorio()
        {
            contexto = new MiMusicaContexto();
        }

        public void GuardarUsuario(Usuario usuario)
        {
            usuario.TipoUsuario = TipoUsuario.Administrador;
            this.contexto.Usuarios.Add(usuario);
            this.contexto.SaveChanges();
        }


        public Usuario ValidarUsuario(string userName, string password)
        {
            Usuario usuario = contexto.Usuarios
                .FirstOrDefault(u => u.UserName == userName && u.Password == password);
            return usuario;
        }
    }
}
