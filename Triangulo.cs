using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo
{
    public class Triangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;

        }
        public bool VerificarTriangulovalido()
        {
            return (LadoA + LadoB > LadoC) && (LadoA + LadoC > LadoB) && (LadoB + LadoC > LadoA);

        }

        public double CalcularArea()
        {
            double semiperimetro = (LadoA + LadoB + LadoC) / 2;
            return Math.Sqrt(semiperimetro * (semiperimetro - LadoA) * (semiperimetro - LadoB) * (semiperimetro - LadoC));
        }







    }
}
