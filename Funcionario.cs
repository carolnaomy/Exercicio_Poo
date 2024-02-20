using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string nome, double salario, string cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }



        public double CalcularSalarioLiquido(double descontos, double beneficios)
        {
            return Salario - descontos + beneficios;
        }

        public double CalcularSalarioLiquido(double descontos)
        {
            return Salario - descontos;
        }

        public double CalcularSalarioLiquido()
        {
            return Salario;
        }

    }
}
