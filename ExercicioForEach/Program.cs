using System;

namespace ExercicioForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] embalagens = null;

            Console.WriteLine("Quantas embalagens de pão de queijo tem na prateleira?");
            int quantidadeEmbalagem = int.Parse(Console.ReadLine());

            embalagens = new int [quantidadeEmbalagem];

            for (var i = 0; i < quantidadeEmbalagem; i++)
            {
                Console.WriteLine("Quantos pão de queijo tem na " + (i + 1) + "ª embalagem");
                embalagens[i] = int.Parse(Console.ReadLine());
            }

            int c = 1;
            foreach (var item in embalagens)
            {
                Console.WriteLine($"A quantidade de pão de queijo da {c}ª embalagem é: {item}");
                c++;
            }


        }
    }
}
