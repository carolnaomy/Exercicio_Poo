using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public bool Disponivel { get; set; }

        public Livro(string titulo, string autor, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
            Disponivel = true;

        }

        public void EmprestarLivro()
        {
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine("Livro emprestado com sucesso.");
            }
            else
            {
                Console.WriteLine("O livro já está emprestado.");

            }



        }

        public void DevolverLivro()
        {

            if (!Disponivel)
            {
                Disponivel = true;
                Console.WriteLine("Livro devolvido com sucesso.");
            }
            else
            {
                Console.WriteLine("O livro já está disponível.");
            }
        }

        public void VerificarDisponibilidade()
        {
            if (Disponivel)
            {
                Console.WriteLine("O livro está disponível para empréstimo.");
            }
            else
            {
                Console.WriteLine("O livro não está disponível no momento.");
            }
        }
    }
}
    

    
