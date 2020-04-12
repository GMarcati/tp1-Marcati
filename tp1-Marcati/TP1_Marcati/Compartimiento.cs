using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Marcati
{
    public class Compartimiento
    {
        public int ID_Compartimiento { get; set; }
        public Producto Producto { get; set; }
        public Cliente Cliente { get; set; }
        public Dimension Dimension { get; set; }

    }
}
