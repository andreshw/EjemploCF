using MiMusica.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiMusica.Web.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/
        public ActionResult CrearUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearUsuario(Usuario usuario)
        {
            UsuarioRepositorio repositorio = new UsuarioRepositorio();
            repositorio.GuardarUsuario(usuario);
            return Content("Usuario Almacenado");
        }

        public ActionResult LoguearUsuario(string userName, string password)
        {
            UsuarioRepositorio repo = new UsuarioRepositorio();
            Usuario usuarioValidado = repo.ValidarUsuario(userName, password);
            if (usuarioValidado == null)
            {
                ViewBag.MensajeError = "El usuario no existe, intente nuevamente";
                return View("Login");
            }
            else
            {
                Session["usuarioLogueado"] = usuarioValidado;
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Login()
        {
            return View();
        }

	}
}