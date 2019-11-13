using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.contas
{
    class ContaInvestimento : Conta,ITributavel
    {
        //public override void Saca(double valorConvertido)
        //{
        //    this.Saldo -= valorConvertido + 0.2;
        //}
        //public override void Deposita(double valorConvertido)
        //{
        //    this.Saldo += valorConvertido - 0.2;
        //}

        public double CTributo()
        {
            return this.Saldo *= 0.02;
        }
    }
}
