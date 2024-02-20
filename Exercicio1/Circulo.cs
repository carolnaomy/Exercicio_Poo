using System;

namespace Exercicio_Poo.Exercicio1
{
    public class Circulo
    {
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }
    }
}
