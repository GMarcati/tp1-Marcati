using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Marcati
{
    public class Empleado : Persona
    {
        public int ID_Empleado { get; set; }
        public Puesto Puesto { get; set; }

    }
}
