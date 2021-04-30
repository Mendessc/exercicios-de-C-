using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em qual ano você nasceu?");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o ano atual?");
            int anoAtual = int.Parse(Console.ReadLine());
            
            int idadePessoa = anoAtual - anoNascimento;
            float idadeSemana = idadePessoa * 521775;

            Console.WriteLine("Sua idade é: " + idadePessoa + "\n");
            Console.WriteLine("Sua idade em semanas é: " + idadeSemana + "\n");

        }
    }
}
