using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio2
{
    public class Agenda
    {
        private List<Contato> contatos;

        public Agenda()
        {
            contatos = new List<Contato>();
        }

        public void AdicionarContato(string nome, string telefone)
        {
            contatos.Add(new Contato(nome, telefone));
            Console.WriteLine($"Contato '{nome}' adicionado com sucesso.");
        }

        public void EditarContato(string nome, string novoTelefone)
        {
            Contato contato = contatos.Find(c => c.Nome == nome);
            if (contato != null)
            {
                contato.Telefone = novoTelefone;
                Console.WriteLine($"Telefone do contato '{nome}' atualizado para '{novoTelefone}'.");
            }
            else
            {
                Console.WriteLine($"Contato '{nome}' não encontrado na agenda.");
            }
        }

        public void RemoverContato(string nome)
        {
            Contato contato = contatos.Find(c => c.Nome == nome);
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine($"Contato '{nome}' removido da agenda.");
            }
            else
            {
                Console.WriteLine($"Contato '{nome}' não encontrado na agenda.");
            }
        }

        public List<Contato> BuscarContatosPorNome(string nome)
        {
            return contatos.FindAll(c => c.Nome.Contains(nome));
        }

        public Contato BuscarContatoPorTelefone(string telefone)
        {
            return contatos.Find(c => c.Telefone == telefone);
        }
    }
}