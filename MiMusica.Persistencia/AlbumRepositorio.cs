using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiMusica.Persistencia
{
    public class AlbumRepositorio
    {
        private MiMusicaContexto contexto;

        public AlbumRepositorio()
        {
            this.contexto = new MiMusicaContexto();
        }

        public List<Album> ConsultarAlbum()
        {
            return contexto.Albumes.ToList();
        }

        public Album ConsultarAlbumPorId(int idAlbum)
        {
            return contexto.Albumes.FirstOrDefault(a => a.Id == idAlbum);
        }

        public void GuardarAlbum(Album album)
        {
            var artista = contexto.Artistas.FirstOrDefault(a => a.Id == album.IdArtista);
            album.Artista = artista;
            
            contexto.Albumes.Add(album);
            contexto.SaveChanges();
        }

        public void EditarAlbum(Album album)
        {
            Album albumEditar = ConsultarAlbumPorId(album.Id);
            albumEditar.Nombre = album.Nombre;
            albumEditar.FechaLanzamiento = album.FechaLanzamiento;
            contexto.SaveChanges();
        }

        public void EliminarAlbum(int idAlbum)
        {
            Album albumEliminar = ConsultarAlbumPorId(idAlbum);
            contexto.Albumes.Remove(albumEliminar);
            contexto.SaveChanges();
        }
    }
}
