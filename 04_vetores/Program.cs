using System;


namespace _04_vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variavel
            //sintaxe: tipo nomeVariavel = valor
            string nome = "Fulano de Tal";
            Console.WriteLine(nome);

            //reatribuição de valor em um avariavel
            // nome = "beltrano ";

            //declaração de vetores
            //Sintaxe: tipo[] nomeVariavel =  { valor1, Valor2, valor3 }
            string[] nomes = { "fulano", "beltrano", "sicrano" ,"decio", "otavio", "armando"};
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);
            Console.WriteLine(nome);
            //loop FOR
            //sintaxe: for (indice; controle; incremento)
            for (int i = 0; i < nomes.Length; i++)
            {
                //Console.WriteLine(nomes[i]);
                Console.WriteLine("{0}° Nome: {1}", i + 1, nomes[i]);

            }
            //numero pares de 0 a 100
            for (int i = 0;i <= 100; i+=2)
            {
                Console.WriteLine("Numero: {0}", i);

            }
            //loop foreach
            //sintaxe: foreach(variavel in vetor)
            foreach (string varNome in nomes) 
            {
                Console.WriteLine("nome: {0}", varNome);
            }
        }
    }
}
