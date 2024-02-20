using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio2
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public Produto(string nome, decimal preco, int quantidadeEstoque)
        {
            Nome = nome;

            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }
    }
}
