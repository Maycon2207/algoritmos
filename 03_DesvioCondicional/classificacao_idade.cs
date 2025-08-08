using System;

class classificacao_idade
{
    static void Main()
    {
        int numero;

        Console.Write("Digite sua idade: ");
        numero = int.Parse(Console.ReadLine());

        if (numero <= 12)
        {
            Console.WriteLine("Você é criança.");
        }
        else if (numero <= 17)
        {
            Console.WriteLine("Você é adolescente.");
        }
        else if (numero >= 60)
        {
            Console.WriteLine("Você é idoso.");
        }
        else
        {
            Console.WriteLine("Você é adulto.");
        }
    }
}
