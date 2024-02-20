using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio1
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; } 
        public double VelocidadeAtual { get; set; }

        public Carro (string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            VelocidadeAtual = 0;
        }

        public void Acelerar(double aceleracao)
        {
            VelocidadeAtual += aceleracao;
        }
        public void Frear(double desaceleracao)
        {
            VelocidadeAtual -= desaceleracao;
            if (VelocidadeAtual <0)
            {
                VelocidadeAtual = 0;
            }
        }

    }
}
