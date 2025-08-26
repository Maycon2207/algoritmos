using System;
using System.Text.RegularExpressions;

namespace _08_validaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine()?.Trim();

            // Remove caracteres não numéricos do CPF
            cpf = Regex.Replace(cpf, @"\D", "");

            // Valida se o CPF contém exatamente 11 dígitos
            if (cpf.Length != 11)
            {
                Console.WriteLine("CPF inválido. Deve conter 11 dígitos numéricos.");
                return;
            }
            /*if (cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" ||
            cpf == "44444444444" || cpf == "55555555555" || cpf == "66666666666" ||
            cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999")
            {
                Console.WriteLine("Cpf Inválido! Números repetidos não são permitidos");
                return;*/
                //if( cpf.Distinct().Count() == 1) // Outra forma de validar se todos os dígitos são iguais
                // Valida se todos os dígitos são iguais
                if (Regex.IsMatch(cpf, @"^(\d)\1{10}$"))
            {
                Console.WriteLine("CPF inválido. Todos os dígitos são iguais.");
                return;
            }

            // Valida o CPF com os dígitos verificadores
            if (ValidarCPF(cpf))
                Console.WriteLine(" CPF válido.");
            else
                Console.WriteLine(" CPF inválido.");
        }

        static bool ValidarCPF(string cpf)
        {
            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            // Pega os 9 primeiros dígitos
            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            // Calcula o primeiro dígito verificador
            for (int i = 0; i < 9; i++)
                soma += (tempCpf[i] - '0') * multiplicador1[i];

            int resto = soma % 11;
            int digito1 = (resto < 2) ? 0 : 11 - resto;

            tempCpf += digito1;
            soma = 0;

            // Calcula o segundo dígito verificador
            for (int i = 0; i < 10; i++)
                soma += (tempCpf[i] - '0') * multiplicador2[i];

            resto = soma % 11;
            int digito2 = (resto < 2) ? 0 : 11 - resto;

            // Confere se os dois últimos dígitos conferem
            return cpf.EndsWith(digito1.ToString() + digito2.ToString());
        }
    }
}
