using System;

namespace _09_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o mês (1..12):");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano:");
            int ano = int.Parse(Console.ReadLine());

            int diasDoMes = DateTime.DaysInMonth(ano, mes);

            DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;

            int[,] calendario = new int[6, 7];
            int dia = 1;

            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (semana == 0 && diaSemana < diaSemanaInicio)
                    {
                        calendario[semana, diaSemana] = 0;
                    }
                    else if (dia <= diasDoMes)
                    {
                        calendario[semana, diaSemana] = dia;
                        dia++;
                    }
                }
            }

            Console.WriteLine($"\nCalendário de " +
            $"{primeiroDiaMes.ToString("MMMM")} de {ano}");

            Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");

            int[] diasFeriados = RetornaFeriados(mes, ano);

            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    int valorDia = calendario[semana, diaSemana];

                    if (valorDia == 0)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        // Domingo em vermelho
                        if (diaSemana == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        // Se for feriado, pinta em amarelo
                        else if (Array.Exists(diasFeriados, f => f == valorDia))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else
                        {
                            Console.ResetColor();
                        }

                        Console.Write(valorDia.ToString("D2") + "\t");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nFeriados: ");
            for (int i = 0; i < diasFeriados.Length; i++)
            {
                if (diasFeriados[i] > 0)
                {
                    Console.Write(diasFeriados[i] + " ");
                }
            }

            Console.ReadKey();
        }

        public static int[] RetornaFeriados(int mes, int ano)
        {
            int[] feriados = new int[10];
            int indice = 0;

            if (mes == 1) feriados[indice++] = 1;

            else if (mes == 4) feriados[indice++] = 21;

            else if (mes == 5) feriados[indice++] = 1;

            else if (mes == 9) feriados[indice++] = 7;

            else if (mes == 10) feriados[indice++] = 12;

            else if (mes == 11)
            {
                feriados[indice++] = 2;
                feriados[indice++] = 15;
                feriados[indice++] = 20;
            }
            else if (mes == 12) feriados[indice++] = 25; // Natal
            return feriados;
        }
    }
}
