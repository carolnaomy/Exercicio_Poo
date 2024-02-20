using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio1
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }


        public Produto(string nome, double preco, int quantidadeEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;

        }
        public double CalcularValorTotalEstoque()
        {
            return Preco * QuantidadeEstoque;
        }
        public bool VerificarDisponibilidade()
        {
            return QuantidadeEstoque > 0;
        }
    }

    
}
