using System;

using System.Text.RegularExpressions;

namespace _08_validarCPF1
{
    internal class program
            {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu CPF:");
            string cpf = Console.ReadLine();
            string cpfLimpo = Regex.Replace(cpf, "[^0-9]", "");

            if (cpfLimpo.Length != 11)
            {
                Console.WriteLine("Cpf digitado : " + cpf);
                Console.WriteLine("Somente números: " + cpfLimpo);
            }
            else
            {
                Console.WriteLine("Cpf Inválido! o campo deve conter 11 dígitos.");
                return;
            }

            if (cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" ||
                cpf == "44444444444" || cpf == "55555555555" || cpf == "66666666666" ||
                cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999")
            {
                Console.WriteLine("Cpf Inválido! Números repetidos não são permitidos");
                return;
            }

            int soma = 0;
            char[] cpfVetor = cpf.ToCharArray();

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpfVetor[i].ToString()) * (10 - i);
            }

            int resto = soma % 11;
            int digX = resto >= 2 ? 11 - resto : 0;

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                int valor = (i < 9) ? int.Parse(cpfVetor[i].ToString()) : digX;
                soma += valor * (11 - i);
            }

            resto = soma % 11;
            int digY = (resto < 2) ? 0 : 11 - resto;

            bool valido = (digX == (cpfVetor[9] - '0')) && (digY == (cpfVetor[10] - '0'));

            if (valido)
                Console.WriteLine(" CPF válido!");
            else
                Console.WriteLine(" CPF inválido!");
        }

    }
}


        

    


