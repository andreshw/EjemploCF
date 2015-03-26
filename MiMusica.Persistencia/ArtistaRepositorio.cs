using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiMusica.Persistencia
{
    public class ArtistaRepositorio
    {
        private MiMusicaContexto contexto;

        public ArtistaRepositorio()
        {
            this.contexto = new MiMusicaContexto();
        }

        public List<Artista> ConsultarArtistas()
        {
            return contexto.Artistas.ToList();
        }

        public Artista ConsultarArtistaPorId(int idArtista)
        {
            return contexto.Artistas.FirstOrDefault(a => a.Id == idArtista);
        }

        public void GuardarArtista(Artista artista)
        {
            contexto.Artistas.Add(artista);
            contexto.SaveChanges();
        }

        public void EditarArtista(Artista artista)
        {
            Artista artistaEditar = ConsultarArtistaPorId(artista.Id);
            artistaEditar.Nombre = artista.Nombre;
            artistaEditar.UrlImagen = artista.UrlImagen;
            contexto.SaveChanges();
        }

        public void EliminarArtista(int idArtista)
        {
            Artista artistaEliminar = ConsultarArtistaPorId(idArtista);
            contexto.Artistas.Remove(artistaEliminar);
            contexto.SaveChanges();
        }
    }
}
