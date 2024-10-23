using Ejercicio04Unidad07.Models.DAL;
using Ejercicio04Unidad07.Models.ENT;

namespace Ejercicio04Unidad07.Models.VM
{
    public class ClsEditarPersona : ClsPersona
    {


        public List<ClsDepartamento> ListadoDepartamentos { get; }

        public ClsEditarPersona()
        {
            ListadoDepartamentos = ClsListados.listadoDepartamentos();
        }
    }
}
