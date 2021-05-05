using System;

namespace ExercicioDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classifique sua Categoria!" + "\n");

            Console.WriteLine("Escreva sua idade");
            int idadeNadador = int.Parse(Console.ReadLine());

            if(idadeNadador >= 0 && idadeNadador <= 4)
                Console.WriteLine("Você não tem idade suficiente para participar!!");

            if(idadeNadador >= 5 && idadeNadador <= 7)
                Console.WriteLine("Você está na categoria Infantil A");
        
            if(idadeNadador >= 8 && idadeNadador <= 10)
                Console.WriteLine("Você está na categoria Infantil B");
            
            if(idadeNadador >= 11 && idadeNadador <= 13)
                Console.WriteLine("Você está na categoria Juvenil A");
            
            if(idadeNadador >= 14 && idadeNadador <= 17)
                Console.WriteLine("Você está na categoria Juvenil B");
            
            if(idadeNadador >= 18)
                Console.WriteLine("Você está na categoria Sênior");
        }
    }
}
