using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoMDS_Centroedu
{
    internal class Autoridad
    {
        int id_autoridad;
        string nombre, apellido, usuario, email;

        public int Id_autoridad { get => id_autoridad; set => id_autoridad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Email { get => email; set => email = value; }
    }
}
