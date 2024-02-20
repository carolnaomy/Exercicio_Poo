using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio2
{
    
    public class Usuario
    {
        public string Nome { get; set; }
        public List<Usuario> Amigos { get; set; }
        public List<string> Mensagens { get; set; }

        public Usuario(string nome)
        {
            Nome = nome;
            Amigos = new List<Usuario>();
            Mensagens = new List<string>();
        }

        public void PublicarMensagem(string mensagem)
        {
            Mensagens.Add(mensagem);
            Console.WriteLine($"{Nome} publicou: {mensagem}");
        }

        public void ComentarPost(string mensagem, Usuario autorPost)
        {
            autorPost.Mensagens.Add($"Comentário de {Nome}: {mensagem}");
            Console.WriteLine($"{Nome} comentou no post de {autorPost.Nome}: {mensagem}");
        }
    }

    public class RedeSocial
    {
        private List<Usuario> usuarios;

        public RedeSocial()
        {
            usuarios = new List<Usuario>();
        }

        public void AdicionarUsuario(string nome)
        {
            usuarios.Add(new Usuario(nome));
            Console.WriteLine($"Usuário '{nome}' adicionado à rede social.");
        }

        public void AdicionarAmigo(string nomeUsuario, string nomeAmigo)
        {
            Usuario usuario = BuscarUsuario(nomeUsuario);
            Usuario amigo = BuscarUsuario(nomeAmigo);
            if (usuario != null && amigo != null)
            {
                usuario.Amigos.Add(amigo);
                amigo.Amigos.Add(usuario);
                Console.WriteLine($"'{nomeAmigo}' adicionado como amigo de '{nomeUsuario}'.");
            }
            else
            {
                Console.WriteLine("Usuário ou amigo não encontrado.");
            }
        }

        public void PublicarMensagem(string nomeUsuario, string mensagem)
        {
            Usuario usuario = BuscarUsuario(nomeUsuario);
            if (usuario != null)
            {
                usuario.PublicarMensagem(mensagem);
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }

        public void ComentarPost(string nomeUsuario, string nomeAutorPost, string mensagem)
        {
            Usuario usuario = BuscarUsuario(nomeUsuario);
            Usuario autorPost = BuscarUsuario(nomeAutorPost);
            if (usuario != null && autorPost != null)
            {
                usuario.ComentarPost(mensagem, autorPost);
            }
            else
            {
                Console.WriteLine("Usuário ou autor do post não encontrado.");
            }
        }

        public Usuario BuscarUsuario(string nome)
        {
            return usuarios.Find(u => u.Nome == nome);
        }
    }
}