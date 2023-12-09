using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoMDS_Centroedu
{
    internal class Calificaciones
    {
        int id_materia;
        int id_alumno;
        int trimestre;
        int calificacion;
        string nombre_materia;


        public int Id_materia { get => id_materia; set => id_materia = value; }
        public int Id_alumno { get => id_alumno; set => id_alumno = value; }
        public int Trimestre { get => trimestre; set => trimestre = value; }
        public int Calificacion { get => calificacion; set => calificacion = value; }
        public string Nombre_materia { get => nombre_materia; set => nombre_materia = value; }
    }
}
