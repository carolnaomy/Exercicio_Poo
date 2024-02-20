using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Poo.Exercicio2
{
    internal class Calendario
    {
        private List<DateTime> feriados;

        public Calendario()
        {
            feriados = new List<DateTime>();
            // Adicione aqui os feriados desejados
            AdicionarFeriado(new DateTime(DateTime.Now.Year, 1, 1), "Ano Novo");
            AdicionarFeriado(new DateTime(DateTime.Now.Year, 4, 21), "Tiradentes");
            AdicionarFeriado(new DateTime(DateTime.Now.Year, 5, 1), "Dia do Trabalhador");
            AdicionarFeriado(new DateTime(DateTime.Now.Year, 9, 7), "Independência do Brasil");
            AdicionarFeriado(new DateTime(DateTime.Now.Year, 10, 12), "Dia de Nossa Senhora Aparecida");
            AdicionarFeriado(new DateTime(DateTime.Now.Year, 11, 2), "Finados");
            AdicionarFeriado(new DateTime(DateTime.Now.Year, 11, 15), "Proclamação da República");
            AdicionarFeriado(new DateTime(DateTime.Now.Year, 12, 25), "Natal");
        }

        public void AdicionarFeriado(DateTime data, string descricao)
        {
            feriados.Add(data);
            Console.WriteLine($"Adicionado feriado: {descricao} - {data.ToShortDateString()}");
        }

        public void ExibirCalendarioMes(int ano, int mes)
        {
            DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
            DateTime ultimoDiaMes = primeiroDiaMes.AddMonths(1).AddDays(-1);

            Console.WriteLine($"Calendário do mês {mes}/{ano}:");
            Console.WriteLine("Dom Seg Ter Qua Qui Sex Sab");

            int diaSemana = (int)primeiroDiaMes.DayOfWeek;
            for (int i = 0; i < diaSemana; i++)
            {
                Console.Write("    ");
            }

            for (int dia = 1; dia <= ultimoDiaMes.Day; dia++)
            {
                Console.Write($"{dia,3}");

                if (++diaSemana == 7)
                {
                    diaSemana = 0;
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }

        public bool VerificarFeriado(DateTime data)
        {
            foreach (DateTime feriado in feriados)
            {
                if (data.Date == feriado.Date)
                {
                    return true;
                }
            }
            return false;
        }

        public int CalcularDiferencaDias(DateTime dataInicio, DateTime dataFim)
        {
            TimeSpan diferenca = dataFim.Date - dataInicio.Date;
            return Math.Abs(diferenca.Days);
        }
    }


}

