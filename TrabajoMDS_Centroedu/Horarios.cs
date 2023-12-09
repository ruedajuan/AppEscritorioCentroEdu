using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoMDS_Centroedu
{
    internal class Horarios
    {
        int grado;
        string nombre;
        string dia;
        string hora;
        string aula;


        public int Grado { get => grado; set => grado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dia { get => dia; set => dia = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Aula { get => aula; set => aula = value; }
    }
}
