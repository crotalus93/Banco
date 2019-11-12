using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class TotalizadorDeContas
    {
        public double SaldoTotal { get; set; }

        public void SomaSaldo(double saldo)
        {
            this.SaldoTotal += saldo;
        }
    }
}
