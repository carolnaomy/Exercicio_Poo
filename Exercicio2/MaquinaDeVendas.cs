using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio2
{
    public class MaquinaDeVendas
    {
        private List<Produto> estoque;
        private decimal saldo;

        public MaquinaDeVendas()
        {
            estoque = new List<Produto>();
            saldo = 0;
        }

        public void CadastrarProduto(string nome, decimal preco, int quantidadeEstoque)
        {
            Produto produto = new Produto(nome, preco, quantidadeEstoque);
            estoque.Add(produto);
            Console.WriteLine($"Produto '{nome}' cadastrado com sucesso.");
        }

        public void SelecionarProduto(string nome)
        {
            Produto produto = estoque.Find(p => p.Nome == nome);
            if (produto != null)
            {
                if (produto.QuantidadeEstoque > 0)
                {
                    Console.WriteLine($"Produto '{nome}' selecionado. Preço: R$ {produto.Preco}");
                }
                else
                {
                    Console.WriteLine($"Produto '{nome}' não está disponível no momento.");
                }
            }
            else
            {
                Console.WriteLine($"Produto '{nome}' não encontrado na máquina.");
            }
        }

        public void InserirDinheiro(decimal valor)
        {
            saldo += valor;
            Console.WriteLine($"Valor de R$ {valor} inserido. Saldo atual: R$ {saldo}");
        }

        public void ComprarProduto(string nome)
        {
            Produto produto = estoque.Find(p => p.Nome == nome);
            if (produto != null && produto.QuantidadeEstoque > 0)
            {
                if (saldo >= produto.Preco)
                {
                    saldo -= produto.Preco;
                    produto.QuantidadeEstoque--;
                    Console.WriteLine($"Compra realizada com sucesso! Produto '{nome}' comprado.");
                    Console.WriteLine($"Saldo restante: R$ {saldo}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para comprar o produto.");
                }
            }
            else
            {
                Console.WriteLine("Produto não disponível para compra.");
            }
        }

        public void RetornarTroco()
        {
            Console.WriteLine($"Troco: R$ {saldo}");
            saldo = 0;
        }

        public void ExibirEstoque()
        {
            Console.WriteLine("Estoque disponível:");
            foreach (var produto in estoque)
            {
                Console.WriteLine($"Nome: {produto.Nome}, Preço: R$ {produto.Preco}, Quantidade em estoque: {produto.QuantidadeEstoque}");
            }
        }
    }
}