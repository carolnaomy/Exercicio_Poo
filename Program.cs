using Exercicio_Poo.Exercicio1;
using Exercicio_Poo.Exercicio2;
using System;
using System.Collections.Generic;

namespace Exercicio_Poo
{
    internal class Program
    {
        static void Main()
        {
            //Calendario calendario = new Calendario();

            //// Exibir calendário de um determinado mês
            //calendario.ExibirCalendarioMes(2024, 1);

            //// Verificar se uma data é feriado
            //DateTime dataFeriado = new DateTime(2024, 12, 25);
            //Console.WriteLine($"É feriado? {calendario.VerificarFeriado(dataFeriado)}");

            //// Calcular a diferença de dias entre duas datas
            //DateTime dataInicio = new DateTime(2024, 1, 1);
            //DateTime dataFim = new DateTime(2024, 12, 25);
            //int diferencaDias = calendario.CalcularDiferencaDias(dataInicio, dataFim);
            //Console.WriteLine($"Diferença de dias entre {dataInicio.ToShortDateString()} e {dataFim.ToShortDateString()}: {diferencaDias} dias");



            JogoAdivinhacao jogo = new JogoAdivinhacao();
            Console.WriteLine("Bem-vindo ao Jogo de Adivinhação! Tente adivinhar o número secreto entre 1 e 100.");

            while (!jogo.JogoEncerrado())
            {
                Console.Write("Digite seu palpite: ");
                if (int.TryParse(Console.ReadLine(), out int palpite))
                {
                    jogo.Jogar(palpite);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                }
            }



            //JogoCartas jogo = new JogoCartas();

            //// Embaralhar o baralho
            //jogo.Embaralhar();

            //// Distribuir cartas para os jogadores
            //List<string> jogadores = new List<string> { "Jogador1", "Jogador2", "Jogador3" };
            //jogo.DistribuirCartas(jogadores, 7);

            //// Exibir o monte
            //jogo.ExibirMonte();




            //Biblioteca biblioteca = new Biblioteca();

            //// Cadastrando livros
            //biblioteca.CadastrarLivro("Dom Casmurro", "Machado de Assis", 3);
            //biblioteca.CadastrarLivro("1984", "George Orwell", 5);

            //// Verificando disponibilidade de um livro
            //Console.WriteLine("Disponibilidade de 'Dom Casmurro': " + biblioteca.VerificarDisponibilidadeLivro("Dom Casmurro"));

            //// Fazendo empréstimo
            //biblioteca.FazerEmprestimo("Dom Casmurro");
            //biblioteca.FazerEmprestimo("Dom Casmurro");
            //biblioteca.FazerEmprestimo("1984");

            //// Devolvendo livros
            //biblioteca.DevolverLivro("Dom Casmurro");

            //// Verificando disponibilidade de um livro após devolução
            //Console.WriteLine("Disponibilidade de 'Dom Casmurro' após devolução: " + biblioteca.VerificarDisponibilidadeLivro("Dom Casmurro"));



            //Pessoa pessoa = new Pessoa("João", 30, "Engenheiro");
            //pessoa.ExibirInformacoes();



            //RedeSocial redeSocial = new RedeSocial();

            //// Adicionar usuários
            //redeSocial.AdicionarUsuario("Alice");
            //redeSocial.AdicionarUsuario("Bob");
            //redeSocial.AdicionarUsuario("Charlie");

            //// Adicionar amigos
            //redeSocial.AdicionarAmigo("Alice", "Bob");
            //redeSocial.AdicionarAmigo("Alice", "Charlie");

            //// Publicar mensagens
            //redeSocial.PublicarMensagem("Alice", "Olá, pessoal!");

            //// Comentar post
            //redeSocial.ComentarPost("Bob", "Alice", "Olá, Alice!");

            Console.ReadLine();

        }
    }
}