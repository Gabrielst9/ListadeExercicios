using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_28.ConsoleApp
{
    internal class Program
    {
        //Escreva um programa que exiba a tabuada de multiplicação do 1 até o 10.
        //Para isso, o programa deve gerar todas as combinações de multiplicação entre 1 e 10, exibindo o resultado de cada operação na tela.
        //Desafio: Para cada número, tente separar em colunas.

        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada! \n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tabuada do " + i + ":");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
