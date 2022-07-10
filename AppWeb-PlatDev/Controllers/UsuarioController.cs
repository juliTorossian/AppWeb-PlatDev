using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppWeb_PlatDev.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Muestra pantalla de inicio de sesion
        public ActionResult Login()
        {
            return View();
        }
        // GET: Muestra pantalla de crear cuenta
        public ActionResult CrearCuenta()
        {
            return View();
        }
    }
}
