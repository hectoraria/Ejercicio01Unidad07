using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio01Unidad07.Models
{
    public class ClsPersona : Controller
    {
        public int idPersona { get; set; }

        public string nombre { get; set; }

        public string apellidos { get; set; }

        public DateTime fechaNac { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }
    }
}
