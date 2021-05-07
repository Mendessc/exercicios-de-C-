using System;

namespace ExercicioCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacao;
            string letra;
            bool check = false;
            double n1;
            double n2;

            Console.WriteLine("Digite os dois números que você deseja utilizar");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());


            while (check == false)
            {
                Console.WriteLine("Você quer Somar, Subtrair, Multiplicar ou Dividir? ");
                operacao = Console.ReadLine() .ToLower();
                letra = operacao.Substring(0, 2);

                if (letra == "so")
                {
                    Console.WriteLine("Ok você quer somar!" + "\n");
                    check = true;
                    Console.WriteLine($"O resultado da soma é: {Soma(n1, n2)}");
                }
                else if (letra == "su")
                {
                    Console.WriteLine("Ok você quer subtrair!" + "\n");
                    check = true;
                    Console.WriteLine($"O resultado da subtração é: {Subtrair(n1, n2)}");
                }
                else if (letra == "mu")
                {
                    Console.WriteLine("Ok você quer multiplicar!" + "\n");
                    check = true;
                    Console.WriteLine($"O resultado da multiplicação é: {Multiplicar(n1, n2)}");
                }
                else if (letra == "di")
                {
                    Console.WriteLine("Ok você quer dividir!" + "\n");
                    check = true;
                    Console.WriteLine($"O resultado da divisão é: {Dividir(n1, n2)}");
                }
                else
                {
                    Console.WriteLine("Isso não é uma operação válida!!! Tente Novamente!");
                }
            }

        }
        static double Soma(double PrimeiroNumero, double SegundoNumero)
        {
            return PrimeiroNumero + SegundoNumero;
        }
        static double Subtrair(double PrimeiroNumero, double SegundoNumero)
        {
            return PrimeiroNumero - SegundoNumero;
        }
        static double Dividir(double PrimeiroNumero, double SegundoNumero)
        {
            return PrimeiroNumero / SegundoNumero;
        }
        static double Multiplicar(double PrimeiroNumero, double SegundoNumero)
        {
            return PrimeiroNumero * SegundoNumero;
        }
    }
}
