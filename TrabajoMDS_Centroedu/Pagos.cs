using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoMDS_Centroedu
{
    internal class Pagos
    {
        int id_pagos, id_tutor, monto;
        string fecha_pago, modalidad_pago, mes_pago;

        public int Id_pagos { get => id_pagos; set => id_pagos = value; }
        public int Id_tutor { get => id_tutor; set => id_tutor = value; }
        public int Monto { get => monto; set => monto = value; }
        public string Fecha_pago { get => fecha_pago; set => fecha_pago = value; }
        public string Modalidad_pago { get => modalidad_pago; set => modalidad_pago = value; }
        public string Mes_pago { get => mes_pago; set => mes_pago = value; }
    }
}
