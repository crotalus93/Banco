using System;

namespace Banco
{
    public abstract class Conta 
    {
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }
        public int Numero { get; set; }
        public string Valor { get; set; }

        public abstract void Deposita(double valorConvertido);

        public abstract void Saca(double valorConvertido);    
    }
}