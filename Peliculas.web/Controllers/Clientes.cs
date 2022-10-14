using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Peliculas.web.Models;

namespace Peliculas.web.Controllers
{
    public class Clientes : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {

            IEnumerable<Cliente> clientes = new List<Cliente>()
          {

              new Cliente
              {

                  Id=1,
                  Nombre="Alex",
                  apellidos="Frias Molina",
                  Clave="123",
                  Correo="Alex@gmail.com",
                  Edad=18


              },

                 new Cliente
              {

                  Id=2,
                  Nombre="Alexa",
                  apellidos="Frias Molina",
                  Clave="123d",
                  Correo="Alexa@gmail.com",
                  Edad=13


              },

          };
              

            return View(clientes);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


            // GET: Clientes/Create

        public ActionResult Create()
        {
            return View();
        }

    
       

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
