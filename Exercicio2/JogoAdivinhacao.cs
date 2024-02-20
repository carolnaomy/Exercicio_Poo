using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio2
{
    public class JogoAdivinhacao
    {
        private int numeroSecreto;
        private bool jogoEncerrado;

        public JogoAdivinhacao()
        {
            Random rand = new Random();
            numeroSecreto = rand.Next(1, 100); // Gera um número aleatório entre 1 e 100
            jogoEncerrado = false;
        }

        public void Jogar(int palpite)
        {
            if (jogoEncerrado)
            {
                Console.WriteLine("O jogo já foi encerrado. Inicie um novo jogo.");
                return;
            }

            if (palpite == numeroSecreto)
            {
                Console.WriteLine("Parabéns! Você acertou o número secreto.");
                jogoEncerrado = true;
            }
            else if (palpite < numeroSecreto)
            {
                Console.WriteLine("O palpite é menor que o número secreto.");
            }
            else
            {
                Console.WriteLine("O palpite é maior que o número secreto.");
            }
        }

        public bool JogoEncerrado()
        {
            return jogoEncerrado;
        }
    }
}
