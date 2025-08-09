using System;

namespace _06_tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            // Loop de 1 até 10 para mostrar a tabuada
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }

         
        }
    }
}