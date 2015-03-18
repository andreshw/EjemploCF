using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiMusica.Persistencia
{
    public class MiMusicaContexto : DbContext
    {
        public MiMusicaContexto() : base("Default")
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Album> Albumes { get; set; }
    }
}
