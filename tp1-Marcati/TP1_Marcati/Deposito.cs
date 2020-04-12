using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Marcati
{
    public class Deposito
    {
        public int ID_Deposito { get; set; }
        public List<Pasillo> Pasillos { get; set; }
        public string Direccion { get; set; }
        public int Capacidad { get; set; }
        public List<Empleado> Empleados { get; set; }
        public Seguridad Seguridad { get; set; }

        public Dimension Dimension { get; set; }
    }
}
