using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoMDS_Centroedu
{
    internal class Usuarios
    {
        int id_usuario;
        string usuario;
        string password;
        string nombre;
        int id_tipo;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }

        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
