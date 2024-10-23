using Ejercicio04Unidad07.Models.DAL;
using Ejercicio04Unidad07.Models.ENT;
using Ejercicio04Unidad07.Models.VM;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio04Unidad07.Controllers
{
    public class EditarPersonaController : Controller
    {
        public IActionResult EditarPersona()
        {
            Random random = new Random();
            List<ClsPersona> list = ClsListados.listadoPersonas();
            int randomNumber = random.Next(0, list.Count);


            ClsPersona persona = list[randomNumber];

            ClsEditarPersona editPersona = new ClsEditarPersona
            {
                Nombre = persona.Nombre,
                Apellidos = persona.Apellidos,
                Edad = persona.Edad,
                Departamento = persona.Departamento,
            };


            return View(editPersona);
        }
    }
}
