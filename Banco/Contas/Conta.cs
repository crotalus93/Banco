using System;

namespace Banco.contas
{
    public class Conta 
    {
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }
        public int Numero { get; set; }
        public string Valor { get; set; }
        public string Nome { get; set; }

        public static int TotalDeContas;

        public Conta()
        {
            Conta.TotalDeContas++;
            this.Numero = Conta.TotalDeContas;
        }

        public static int ProximoNumero()
        {
            return Conta.TotalDeContas + 1;
        }

        public virtual void Deposita(double valorConvertido) {
        }

        public virtual void Saca(double valorConvertido)
        {

        }  
    }
}