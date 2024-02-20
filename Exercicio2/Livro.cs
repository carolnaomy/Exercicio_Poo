using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio2
{
   
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int QuantidadeDisponivel { get; set; }

        public Livro(string titulo, string autor, int quantidadeDisponivel)
        {
            Titulo = titulo;
            Autor = autor;
            QuantidadeDisponivel = quantidadeDisponivel;
        }
    }

    public class Biblioteca
    {
        private List<Livro> livros;

        public Biblioteca()
        {
            livros = new List<Livro>();
        }

        public void CadastrarLivro(string titulo, string autor, int quantidadeDisponivel)
        {
            livros.Add(new Livro(titulo, autor, quantidadeDisponivel));
            Console.WriteLine($"Livro '{titulo}' cadastrado na biblioteca.");
        }

        public void FazerEmprestimo(string titulo)
        {
            Livro livro = BuscarLivro(titulo);
            if (livro != null && livro.QuantidadeDisponivel > 0)
            {
                livro.QuantidadeDisponivel--;
                Console.WriteLine($"Livro '{titulo}' emprestado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Livro '{titulo}' não disponível para empréstimo.");
            }
        }

        public void DevolverLivro(string titulo)
        {
            Livro livro = BuscarLivro(titulo);
            if (livro != null)
            {
                livro.QuantidadeDisponivel++;
                Console.WriteLine($"Livro '{titulo}' devolvido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Livro '{titulo}' não encontrado na biblioteca.");
            }
        }

        public bool VerificarDisponibilidadeLivro(string titulo)
        {
            Livro livro = BuscarLivro(titulo);
            return livro != null && livro.QuantidadeDisponivel > 0;
        }

        private Livro BuscarLivro(string titulo)
        {
            return livros.Find(l => l.Titulo == titulo);
        }
    }

}

