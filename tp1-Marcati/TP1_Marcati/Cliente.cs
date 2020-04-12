using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Marcati
{
    public class Cliente : Persona
    {
        public int ID_Cliente { get; set; }
        public Empresa Empresa { get; set; }
    }
}
