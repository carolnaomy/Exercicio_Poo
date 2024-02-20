using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio1
{
    public class Retângulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retângulo(double largura, double altura)
        { Largura = largura;
           Altura = altura; 
        }

        public double CalcularArea()
        {
            return Largura * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        
    }

}
