using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int idadePessoa = int.Parse(Console.ReadLine());

            int idadeMeses = idadePessoa * 12;
            int idadeDias = idadePessoa * 365;
            int idadeHoras = idadeDias * 24;
            int idadeMinutos = idadeHoras * 60;

            Console.WriteLine("Sua idade em meses é: " + idadeMeses + "\n");
            Console.WriteLine("Sua idade em dias é: " + idadeDias + "\n");
            Console.WriteLine("Sua idade em horas é: " + idadeHoras + "\n");
            Console.WriteLine("Sua idade em minutos é: " + idadeMinutos + "\n");
        }
    }
}
