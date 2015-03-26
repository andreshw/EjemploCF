using MiMusica.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiMusica.Web.Controllers
{
    public class AlbumController : Controller
    {
        //
        // GET: /Album/
        public ActionResult CrearAlbum(int idArtista)
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearAlbum(Album album)
        {
            AlbumRepositorio repo = new AlbumRepositorio();
            repo.GuardarAlbum(album);
            return RedirectToAction("AgregarAlbumes", "Artista", new { id = album.IdArtista });
        }
	}
}