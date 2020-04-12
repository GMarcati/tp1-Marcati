using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Marcati
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public string Nombre { get; set; }
        public Marca Marca { get; set; }
        public Tipo Tipo { get; set; }
        public Dimension Dimension { get; set; }

    }
}
