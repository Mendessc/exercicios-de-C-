using System;

namespace ExercicioDesafioForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomeProduto = null;
            int[] quantidade = null;
            double[] valor = null;

            Console.WriteLine("Quantos produtos você deseja adicionar?");
            int quantidadeProdutos = int.Parse(Console.ReadLine());

            nomeProduto = new string[quantidadeProdutos];
            quantidade = new int [quantidadeProdutos];
            valor = new double [quantidadeProdutos];
            
            for (var i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1}ª produto");
                nomeProduto[i] = (Console.ReadLine());
            }

            for (var i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine($"Qual a quantidade do {i + 1}ª produto");
                quantidade[i] = int.Parse(Console.ReadLine());
            }
            for (var i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine($"Qual o valor do {i + 1}ª produto");
                valor[i] = double.Parse(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($@"|====================================================|
|   Nome              Quantidade             Valor   |  
|====================================================|");

            for (var i = 0; i < quantidadeProdutos; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($@"|  {nomeProduto[i]}                 {quantidade[i]}                  R${valor[i]} |");
            }
            Console.WriteLine($@"|====================================================|");
        }

    }
}
