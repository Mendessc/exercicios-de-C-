using System;

namespace ExercicoDesafio_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int F = 1;
            int n = 1;
            int resultado = 0;

            Console.WriteLine("----------Sequência de Fibonacci----------\n");
            Console.WriteLine(resultado);
            Console.WriteLine(F);
            Console.WriteLine(n);

            while (resultado < 500)
            {
                resultado = F + n;
                 Console.WriteLine(resultado);
                 n = F;
                 F = resultado;
            }
            Console.WriteLine("----------Fim Da Sequência de Fibonacci----------");
        }
    }
}
