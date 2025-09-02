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

            GerarCalendario(mes, ano);

            // for (int mes = 1; mes <== 12; mes++)  isso é para ele ficar fazendo um loop e imprimindo todos os meses do ano
            Console.WriteLine("\n\n Deseja ver o ano inteiro? (S/N): ");
            string opcao = Console.ReadLine().ToUpper();

            if (opcao == "S")
            {
                for (int m = 1; m <= 12; m++)
                {
                    ImprimeCalendario(m, ano);
                    Console.WriteLine(new string('-', 50));
                }
                Console.ReadKey();
            }
        }

        private static void GerarCalendario(int mes, int ano)
        {
            ImprimeCalendario(mes, ano);
        }

        public static void ImprimeCalendario(int mes, int ano)
        {
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

            Console.WriteLine($"\nCalendário de {primeiroDiaMes.ToString("MMMM")} de {ano}");
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
                        if (diaSemana == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
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
            foreach (int f in diasFeriados)
            {
                if (f > 0)
                {
                    Console.Write(f + " ");
                }
            }
            Console.WriteLine("\n\n");
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
            else if (mes == 12) feriados[indice++] = 25;

            DateTime pascoa = DomingoDePascoa(ano);
            DateTime carnaval = pascoa.AddDays(-47);
            DateTime sextaFeiraSanta = pascoa.AddDays(-2);
            DateTime corpusChristi = pascoa.AddDays(60);

            if (carnaval.Month == mes) feriados[indice++] = carnaval.Day;
            if (sextaFeiraSanta.Month == mes) feriados[indice++] = sextaFeiraSanta.Day;
            if (pascoa.Month == mes) feriados[indice++] = pascoa.Day;
            if (corpusChristi.Month == mes) feriados[indice++] = corpusChristi.Day;

            return feriados;
        }

        public static DateTime DomingoDePascoa(int ano)
        {
            int X = 0, Y = 0;

            if (ano <= 1699) { X = 22; Y = 2; }
            else if (ano <= 1799) { X = 23; Y = 3; }
            else if (ano <= 1899) { X = 24; Y = 4; }
            else if (ano <= 2099) { X = 24; Y = 5; }
            else if (ano <= 2199) { X = 24; Y = 6; }
            else if (ano <= 2299) { X = 24; Y = 7; }

            int a = ano % 19;
            int b = ano % 4;
            int c = ano % 7;
            int d = (19 * a + X) % 30;
            int g = (2 * b + 4 * c + 6 * d + Y) % 7;

            int dia, mes;

            if (d + g > 9)
            {
                dia = d + g - 9;
                mes = 4;
            }
            else
            {
                dia = d + g + 22;
                mes = 3;
            }


            return new DateTime(ano, mes, dia);




        }
    }
}








