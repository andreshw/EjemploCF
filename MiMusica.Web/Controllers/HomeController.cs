using MiMusica.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiMusica.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Usuario usuario = Session["usuarioLogueado"] as Usuario;
            if(usuario != null)
            { 
                ViewBag.NombreUsuario = usuario.Nombre;
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}