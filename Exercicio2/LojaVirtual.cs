using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio2
{
    public class LojaVirtual
    {
        private List<Produto> catalogo;
        private List<ItemCarrinho> carrinho;

        public LojaVirtual()
        {
            catalogo = new List<Produto>();
            carrinho = new List<ItemCarrinho>();
        }

        public void CadastrarProduto(string nome, decimal preco, int quantidadeEstoque)
        {
            Produto produto = new Produto(nome, preco, quantidadeEstoque);
            catalogo.Add(produto);
            Console.WriteLine($"Produto '{nome}' cadastrado com sucesso.");

        }
        public void AdicionarAoCarrinho(string nome, int quantidade)
        {
            Produto produto = catalogo.Find(p => p.Nome == nome);
            if (produto != null)
            {
                carrinho.Add(new ItemCarrinho(produto, quantidade));
                Console.WriteLine($"'{quantidade}x {nome}' adicionado ao carrinho.");
            }
            else
            {
                Console.WriteLine($"Produto '{nome}' não encontrado no catálogo.");
            }
        }
        public void AplicarDesconto(decimal percentualDesconto)
        {
            foreach (var item in carrinho)
            {
                decimal desconto = item.Produto.Preco * percentualDesconto / 100;
                item.Produto.Preco -= desconto;
            }
            Console.WriteLine($"Desconto de {percentualDesconto}% aplicado aos produtos do carrinho.");
        }

        public decimal CalcularTotalCompra()
        {
            decimal total = 0;
            foreach (var item in carrinho)
            {
                total += item.CalcularSubtotal();
            }
            return total;
        }
    }
}

    

