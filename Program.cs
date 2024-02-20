using System;

namespace Exercicio_Poo
{
    internal class Program
    {
        static void Main()
        {
            Funcionario Fun = new Funcionario("Caroline",2000,"Analista Ti");

            double salarioliquido = Fun.CalcularSalarioLiquido(300,1000);

            Console.WriteLine($"oi, eu sou {Fun.Nome} e meu salário líquido é {salarioliquido}");

            ContaBancaria Banco = new ContaBancaria(4161, "tryihoujip", 5611650);

        
      
            
            Livro livro = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1000);

            livro.VerificarDisponibilidade(); // Verifica se o livro está disponível

            livro.EmprestarLivro(); // Empresta o livro

            livro.VerificarDisponibilidade(); // Verifica se o livro está disponível após o empréstimo

            livro.DevolverLivro(); // Devolve o livro

            livro.VerificarDisponibilidade(); // Verifica se o livro está disponível após a devolução



            Console.ReadKey();


        }
    }
}