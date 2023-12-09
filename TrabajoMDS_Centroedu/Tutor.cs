using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoMDS_Centroedu
{
    internal class Tutor
    {
        int id_tutor;
        string nombre, apellido, usuario, email;

        public int Id_tutor { get => id_tutor; set => id_tutor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Email { get => email; set => email = value; }
    }
}
