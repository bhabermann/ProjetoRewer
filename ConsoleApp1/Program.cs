using Projeto.Testes;
using System;

namespace ConsoleApp1
{
    class Program
    {
        /*
        
        Criar uma classe "Calculadora" que execute as funções Somar, Subtrair, Divir e Multiplicar. Pode utilizar somente Inteiros inicialmente.
        Criar um "roteiro" de execução de algumas funções da claculadora no Main (Instanciar, Executar e Exibir Resultado)

        Criar uma classe "Cliente" com as propriedades "Nome" e "Idade", criar o construtor da classe e passar esses dados no construtor.

        No Main, instanciar 3 clientes diferentes e adicionar todos eles numa List() e depois percorrer essa lista exibindo todas as informações de cada cliente.

        */


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
