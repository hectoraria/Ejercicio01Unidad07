using Ejercicio04Unidad07.Models.ENT;

namespace Ejercicio04Unidad07.Models.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class ClsListados
    {
            /// <summary>
            /// Funcion que devuelve un lsitado de objetos de la clase ClsPersona
            /// </summary>
            /// <returns>Lista de personas</returns>
            public static List<ClsPersona> listadoPersonas()
            {
                List<ClsPersona> lista = new List<ClsPersona>();

                ClsPersona p1 = new ClsPersona("Hector", "Arias Martin", 32, 3);
                ClsPersona p2 = new ClsPersona("Edu", "Arnesto Tiko", 6, 3);
                ClsPersona p3 = new ClsPersona("Marcos", "Holgado Tirado", 9, 2);
                ClsPersona p4 = new ClsPersona("Pablo", "Lorenza Bellido", 22, 1);
                ClsPersona p5 = new ClsPersona("Lorezo ", "Tupac Arnesto", 32, 5);
                ClsPersona p6 = new ClsPersona("Jorge", "Arias Martin", 32, 1);
                ClsPersona p7 = new ClsPersona("Mariajo", "Guerrero Dolido", 43, 2);
                ClsPersona p8 = new ClsPersona("Martin", "Kata Hormiga", 76, 5);
                ClsPersona p9 = new ClsPersona("Joselu", "Horta Malta", 2, 3);
                ClsPersona p10 = new ClsPersona("Josemamu", "Vencida", 26,  1);

                lista.Add(p1);
                lista.Add(p2);
                lista.Add(p3);
                lista.Add(p4);
                lista.Add(p5);
                lista.Add(p6);
                lista.Add(p7);
                lista.Add(p8);
                lista.Add(p9);
                lista.Add(p10);


                return lista;
            }

            /// <summary>
            /// Función que devuelve una lista de objetos de la clase ClsDepartamento
            /// </summary>
            /// <returns>Lista de departamentos</returns>
            public static List<ClsDepartamento> listadoDepartamentos()
            {
                List<ClsDepartamento> lista = new List<ClsDepartamento>();

                ClsDepartamento d = new ClsDepartamento("DAM", 1);
                ClsDepartamento d2 = new ClsDepartamento("DAW", 2);
                ClsDepartamento d3 = new ClsDepartamento("ASIR", 3);
                ClsDepartamento d4 = new ClsDepartamento("ADE", 4);
                ClsDepartamento d5 = new ClsDepartamento("PAO", 5);

                lista.Add(d);
                lista.Add(d2);
                lista.Add(d3);
                lista.Add(d4);
                lista.Add(d5);

                return lista;
            }
        }
    }
