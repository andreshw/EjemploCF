using MiMusica.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiMusica.Web.Controllers
{
    public class ArtistaController : Controller
    {
        //
        // GET: /Artista/
        public ActionResult Index()
        {
            ArtistaRepositorio repo = new ArtistaRepositorio();
            List<Artista> artistas = repo.ConsultarArtistas();
            return View(artistas);
        }

        public ActionResult CrearArtista()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearArtista(Artista artista)
        {
            ArtistaRepositorio repo = new ArtistaRepositorio();
            repo.GuardarArtista(artista);
            List<Artista> artistas = repo.ConsultarArtistas();
            return View("Index", artistas);
        }

        public ActionResult EditarArtista(int id)
        {
            ArtistaRepositorio repo = new ArtistaRepositorio();
            Artista artista = repo.ConsultarArtistaPorId(id);
            return View(artista);
        }

        [HttpPost]
        public ActionResult EditarArtista(Artista artista)
        {
            ArtistaRepositorio repo = new ArtistaRepositorio();
            repo.EditarArtista(artista);
            List<Artista> artistas = repo.ConsultarArtistas();
            return View("Index", artistas);
        }

        public ActionResult EliminarArtista(int id)
        {
            ArtistaRepositorio repo = new ArtistaRepositorio();
            repo.EliminarArtista(id);
            List<Artista> artistas = repo.ConsultarArtistas();
            return View("Index", artistas);
        }

        public ActionResult AgregarAlbumes(int id)
        {
            ArtistaRepositorio repo = new ArtistaRepositorio();
            Artista artista = repo.ConsultarArtistaPorId(id);
            return View(artista);
        }

	}
}