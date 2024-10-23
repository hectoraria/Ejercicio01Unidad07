using Ejercicio01Unidad07.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio01Unidad07.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            string texto;
            ClsPersona oPersona = new ClsPersona();

            oPersona.idPersona = 1;
            oPersona.nombre = "Hector";

            oPersona.apellidos = "Arias";

            oPersona.fechaNac = new DateTime(1973, 10, 31);

            oPersona.direccion = "La Campana";

            oPersona.telefono = "643443322";

            


            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                texto = "Buenos Días";
            }
            
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 19)
            {
                texto = "Buenas Tardes";
            }
            
            else
            {
                texto = "Buenas Noches";
            }

            
            ViewData["Nombre"] = texto;
            ViewBag.hora = DateTime.Now;
            return View(oPersona);
        }
    }
}
