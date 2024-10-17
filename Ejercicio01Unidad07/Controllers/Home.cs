using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio01Unidad07.Controllers
{
    public class Home : Controller
    {
       public ActionResult Index()
        {
            String texto;
            if (DateTime.Now.Hour > 6 && DateTime.Now.Hour >= 12)
            {
                texto = "Buenos Dias";
            }
            else if (DateTime.Now.Minute > 12 && DateTime.Now.Hour >= 19)
            {
                texto = "Buenas Tardes";
            }
            else
            {
                texto = "Buneas Noches";
            }



            ViewData["Nombre"] = texto;
            ViewBag.hora=DateTime.Now.Hour;
            return View(); 
        
        }

        
    }
}
