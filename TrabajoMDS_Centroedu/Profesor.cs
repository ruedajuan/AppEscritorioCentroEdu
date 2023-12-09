using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoMDS_Centroedu
{
    internal class Profesor
    {
        int id_profesores;
        string nombre;
        string apellido;
        string usuario;
        string email;

        public int Id_profesores { get => id_profesores; set => id_profesores = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Email { get => email; set => email = value; }
    }
}
