using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiMusica.Persistencia
{
    public class Artista
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string UrlImagen { get; set; }

        public virtual List<Album> Albumes { get; set; }
    }
}
