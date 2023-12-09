using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoMDS_Centroedu
{
    internal class Alumnos
    {
        int id_alumnos;
        string nombre;
        string apellido;
        int grado;
        string usuario;
        string email;
        int id_tutor;

        public int Id_alumnos { get => id_alumnos; set => id_alumnos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Grado { get => grado; set => grado = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Email { get => email; set => email = value; }
        public int Id_tutor { get => id_tutor; set => id_tutor = value; }
    }
}
