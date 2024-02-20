using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio2
{
    public enum CorCarta
    {
        Vermelho,
        Amarelo,
        Verde,
        Azul
    }

    public class Carta
    {
        public CorCarta Cor { get; set; }
        public int Numero { get; set; }

        public Carta(CorCarta cor, int numero)
        {
            Cor = cor;
            Numero = numero;
        }

        public override string ToString()
        {
            return $"{Cor.ToString()} {Numero}";
        }
    }

    public class JogoCartas
    {
        private List<Carta> baralho;
        private List<Carta> monte;

        public JogoCartas()
        {
            baralho = new List<Carta>();
            monte = new List<Carta>();

            // Inicializar o baralho com todas as cartas possíveis
            for (int i = 0; i <= 9; i++)
            {
                foreach (CorCarta cor in Enum.GetValues(typeof(CorCarta)))
                {
                    baralho.Add(new Carta(cor, i));
                }
            }
        }

        public void Embaralhar()
        {
            Random rand = new Random();
            for (int i = 0; i < baralho.Count; i++)
            {
                int randomIndex = rand.Next(i, baralho.Count);
                Carta temp = baralho[randomIndex];
                baralho[randomIndex] = baralho[i];
                baralho[i] = temp;
            }
        }

        public void DistribuirCartas(List<string> jogadores, int quantidadeCartas)
        {
            foreach (string jogador in jogadores)
            {
                for (int i = 0; i < quantidadeCartas; i++)
                {
                    if (baralho.Count == 0)
                    {
                        Console.WriteLine("O baralho está vazio. Não é possível distribuir mais cartas.");
                        return;
                    }
                    Carta carta = baralho[0];
                    baralho.RemoveAt(0);
                    Console.WriteLine($"Carta {carta} distribuída para o jogador {jogador}");
                }
            }
        }

        public void AdicionarAoMonte(Carta carta)
        {
            monte.Add(carta);
        }

        public void ExibirMonte()
        {
            Console.WriteLine("Cartas no monte:");
            foreach (Carta carta in monte)
            {
                Console.WriteLine(carta);
            }
        }
    }
}