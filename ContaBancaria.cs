using System;

namespace Exercicio_Poo
{
    public class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numeroConta, string nomeTitular, double saldoInicial)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                Saldo -= valor;
            }
        }
    }
}
