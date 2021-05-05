using System;

namespace Exercicio3_05_05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            string nome = "";
            int idade = 0;
            int salario = 0;
            string estadoCivil;
            string letra;

            while (check == false)
            {
            Console.WriteLine("Insira seu nome");
            nome = Console.ReadLine();
            
            if (nome == "")
            {
                Console.WriteLine("Nome Inválido");
            }
            else
            {
                Console.WriteLine("Nome Salvo");
                check = true;
            }
        }

        while (check == true)
        {
            Console.WriteLine("Insira sua idade");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 150)
            {
                Console.WriteLine("Idade Salva");
                check = false;
            }
            else
            {
                Console.WriteLine("Idade Invalida!!");
            }
            
        }

        while (check == false)
        {
            Console.WriteLine("Insira seu salário");
            salario = int.Parse(Console.ReadLine());

            if (salario <= 0)
            {
                Console.WriteLine("Valor de salário inválido!!!");
            }
            else
            {
                Console.WriteLine("Salário salvo");
                check = true;
            }
        }

        while (check == true)
        {
            Console.WriteLine("Insira seu estado civil");
            estadoCivil = Console.ReadLine();
            letra = estadoCivil.Substring(0, 1) .ToLower();

            if (letra == "s")
            {
                Console.WriteLine("Estado Civil salvo");
                check = false;
            }

            else if (letra == "c")
            {
                Console.WriteLine("Estado Civil salvo");
                check = false;
            }
            else if (letra == "v")
            {
                Console.WriteLine("Estado Civil salvo");
                check = false;
            }
            else if (letra == "d")
            {
                Console.WriteLine("Estado Civil salvo");
                check = false;
            }
            else
            {
                Console.WriteLine("Estado civil Inválido!!");
            }

            Console.WriteLine("As informações cadastradas foram: \n");
            Console.WriteLine("Nome: " + nome + "\n" + "Idade: " + idade + "\n" + "Salário: R$" + salario + "\n" + "Estado Civil: " + estadoCivil); 
        }
        
        }
    }
}
