using System;

namespace Byte_Bank
{
    public class ContaCorrente
    {
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente(int Agencia, int Numero, string Titular)
        {
            this.Saldo = 0;
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
        }
        public double Desposito(double deposito)
        {
            return this.Saldo += deposito;
        }

        public bool Saque(double saque)
        {
            if (this.Saldo > saque)
            {
                this.Saldo -= saque;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Transferencia(ContaCorrente contaDestino, double transferencia)
        {
            if (this.Saque(transferencia))
            {
                contaDestino.Desposito(transferencia);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}