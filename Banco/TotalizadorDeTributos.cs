﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void addTributo(ITributavel IT)
        {
            Total += IT.CTributo();
        }
    }
}
