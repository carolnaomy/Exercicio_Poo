using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio2
{
    internal class Pessoa

    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }

        public Pessoa(string nome, int idade, string profissao)
        {
            Nome = nome;
            Idade = idade;
            Profissao = profissao;
        }
        public int CalcularIdadeEmAnosBissextos()
        {
            int anosBissextos = Idade / 4;
            return Idade + anosBissextos;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Profissão: " + Profissao);
            Console.WriteLine("Idade em anos bissextos: " + CalcularIdadeEmAnosBissextos());

        }

    }
}