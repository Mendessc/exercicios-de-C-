using System;

namespace Exercicio1_05_05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorreta = false;

            while (respostaCorreta == false)
            {
            Console.WriteLine("Digite uma nota de 0 a 10");
            float nota = float.Parse(Console.ReadLine());

            if (nota >= 0 && nota <= 10)
            {
                Console.WriteLine("Nota Válida");
                respostaCorreta = true;
            }
            else
            {
                Console.WriteLine("Nota Inválida");
            }
                
            }


        }
    }
}
