﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente:Conta,ITributavel
    {
        public override void Deposita(double valorConvertido)
        {
            this.Saldo+=valorConvertido-0.1;
        }
        public override void Saca(double valorConvertido)
        {
            this.Saldo-=valorConvertido+0.05;
        }
        public double CTributo()
        {
            return this.Saldo *= 0.05;
        }

    }
}
