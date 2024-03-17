namespace Exercicio_22.ConsoleApp
{
    //Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escrevendo os números ímpares entre 100 e 200! \n");

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}