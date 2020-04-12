using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Marcati
{
    public class Pasillo
    {
        public int ID_Pasillo { get; set; }
        public Lado Lado { get; set; }
        public Cliente Cliente { get; set; }
        public Dimension Dimension { get; set; }
    }
}
