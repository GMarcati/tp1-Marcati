using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Marcati
{
    public class Persona
    {
        public int ID_Persona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public int CUIL { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNac { get; set; }
        public Nacionalidad Nacionalidad { get; set; }

    }
}
