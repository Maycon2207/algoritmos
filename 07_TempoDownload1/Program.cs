using System;


namespace _07_TempoDownload1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tamanhoMB = 0;
            double velocidadeMbps = 0;
            double tempoSegundo, tempoMinutos;

            
            while (true)
            {
                Console.Write("Digite o tamanho do arquivo (MB): ");
                if(double.TryParse(Console.ReadLine(), out tamanhoMB) && tamanhoMB > 0)
                
                    break;
             else
                
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
                
            }


            while (true)
            {
                Console.Write("Digite a velocidade da internet (Mbps): ");
                if (double.TryParse(Console.ReadLine(), out velocidadeMbps) && velocidadeMbps > 0)

                    break;

                else

                    Console.WriteLine("Valor inválido! Digite um número maior que zero.\n");

            }    
                     tempoSegundo = (tamanhoMB * 8) / velocidadeMbps;
                     tempoMinutos = tempoSegundo / 60;

                    Console.WriteLine($"Tempo aproximado de download: {tempoMinutos:F2} minutos");
                
            

        }
    }
}
