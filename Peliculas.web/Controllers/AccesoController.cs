using Microsoft.AspNetCore.Mvc;



namespace Peliculas.web.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrate()
        {

            return View();
        }

        [HttpPost]

        public IActionResult Index(Clientes d)
        {

            return RedirectToAction("Index", "Home");

        }


    }
}
