using System;

namespace _06_tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicando = 0, produto;
            bool digitacaoValida = false;
            //!negação inverte o valor boleano
            //!false = true
            //!true = false
            //while ( digitacaoValida

            while (!digitacaoValida)
            {

                Console.Write("Digite um número inteiro: ");
                digitacaoValida = int.TryParse(Console.ReadLine(), out multiplicando);
            }
                // console.Whiteline("TABUADA DO {0}", multiplicando);
                //interpolação de string $

                Console.WriteLine($"TABUADA DO{multiplicando}");
                for (int multiplicador = 1; multiplicador <= 10; multiplicador++) 
                {
                    produto = multiplicando * multiplicador; 
                    //console.WhiteLine("{0} x {1} =  ", multiplicando, multiplicador produto                   
                    Console.WriteLine($"{multiplicando} x { multiplicador} = { produto }");
                }

                

         
        }
    }
}