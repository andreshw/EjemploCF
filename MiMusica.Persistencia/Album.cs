using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiMusica.Persistencia
{
    public class Album
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaLanzamiento { get; set; }
        
        [NotMapped]
        public int IdArtista { get; set; }

        public virtual Artista Artista { get; set; }
    }
}
