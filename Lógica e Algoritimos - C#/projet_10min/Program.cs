using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            int numero_2 = 5;
            //Console.WriteLine("Quanto é " + numero + " + " + numero_2 + "?");
            Console.WriteLine($"Quanto é {numero} + {numero_2}?");

            int resposta = Convert.ToInt32(Console.ReadLine());

            if (resposta == (numero + numero_2))
            {
                Console.WriteLine("Parabéns! Você acertou!");
            }
            else
            {
                Console.WriteLine("Que pena! Você errou!");
        }
    }
}}