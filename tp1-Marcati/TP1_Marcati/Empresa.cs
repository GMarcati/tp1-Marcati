﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Marcati
{
    public class Empresa
    {
        public int ID_Empresa { get; set; }
        public string Nombre { get; set; }
        public Periodo Periodo { get; set; }
    }
}
