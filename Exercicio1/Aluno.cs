using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio1
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public List<double> Notas { get; set; }

        public Aluno(string nome, int matricula, List<double> notas)
        {
            Nome = nome;
            Matricula = matricula;
            Notas = notas;

        }

        public double CalcularMedia()
        {
            double soma = 0;
            foreach (var nota in Notas)
            {
                soma += nota;
            }
            return soma / Notas.Count;
        }

        public string VerificarSituacao()
        {
            double media = CalcularMedia();
            return media >= 7 ? "Aprovado" : "Reprovado";
         }
    


    }
}
