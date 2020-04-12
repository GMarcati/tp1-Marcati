using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Marcati
{
    public class Puesto
    {
        public int ID_Puesto { get; set; }
        public string Nombre { get; set; }
        public Periodo Periodo { get; set; }
    }
}
