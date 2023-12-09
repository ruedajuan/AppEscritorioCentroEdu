using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoMDS_Centroedu
{
    internal class Materias
    {
        int id_materia, id_profesor, id_grado;
        string nombre;

        public int Id_materia { get => id_materia; set => id_materia = value; }
        public int Id_profesor { get => id_profesor; set => id_profesor = value; }
        public int Id_grado { get => id_grado; set => id_grado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
