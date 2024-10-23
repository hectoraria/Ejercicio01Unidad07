namespace Ejercicio04Unidad07.Models.ENT
{
    public class ClsPersona
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public int Departamento { get; set; }
        #endregion
          
        public ClsPersona() { }
        public ClsPersona(string nombre, string apellidos, int edad, int departamento)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Departamento = departamento;
        }
    }
}
