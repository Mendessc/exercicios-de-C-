using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu salário atual?");
            float salarioAtual = float.Parse(Console.ReadLine());

            if(salarioAtual < 500){
                float salarioPorcentagem = (salarioAtual / 100) * 30;
                float salarioCorreto = salarioAtual + salarioPorcentagem;
                Console.WriteLine("Seu salário corrigido é de: " + salarioCorreto);
            }
            else{
                Console.WriteLine("Você não tem direito ao beneficio");
            }
        }
    }
}
