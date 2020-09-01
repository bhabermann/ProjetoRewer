using Projeto.Testes;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var teste = new Teste(5);
            teste.MultiplicarPor2();
            Console.WriteLine(teste.Value());

            if (teste.Value() == 10)
            { // begin
                Console.WriteLine("Deu certo");
            } // end
            else
            {
                Console.WriteLine("Deu errado");
            }

            var count = 0;
            while (count < 10)
            {
                Console.WriteLine(count);
                count++;
            }

            for (int i = 10; i < 0; i--)
            {
                Console.WriteLine(count);
            }

            // Repeat
            var value = 0;
            do
            {
                value++;
                Console.WriteLine(value);
            } while (value < 10);
        }
    }
}
