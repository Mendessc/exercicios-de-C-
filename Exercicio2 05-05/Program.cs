using System;

namespace Exercicio2_05_05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            while (check == true)
            {

            Console.WriteLine("Digite seu nome de usuário");
            string nomeDeUsuario = Console.ReadLine();     

            Console.WriteLine("Digite sua senha");
            string senha = Console.ReadLine();

            if (nomeDeUsuario == senha)
            {
                Console.WriteLine("CADASTRO INVALIDO: nome de usuario igual a senha!!!");
            }
            else
            {
                Console.WriteLine("Cadastro feito com sucesso!");
                check = false;
            }
                
            }


        }
    }
}
