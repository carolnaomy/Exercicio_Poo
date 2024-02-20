using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio1
{
    public class Paciente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<string> HistoricoConsultas { get; set; }

        public Paciente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            HistoricoConsultas = new List<string>();
        }

        public void AdicionarConsulta(string consulta)
        {
            HistoricoConsultas.Add(consulta);
        }

        public void ExibirConsultas()
        {
            Console.WriteLine($"Consultas realizadas pelo paciente {Nome}:");
            foreach (var consulta in HistoricoConsultas)
            {
                Console.WriteLine(consulta);
            }

        }
    }
    
}
