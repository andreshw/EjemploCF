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
            this.contexto.Usuarios.Add(usuario);
            this.contexto.SaveChanges();
        }
    }
}
