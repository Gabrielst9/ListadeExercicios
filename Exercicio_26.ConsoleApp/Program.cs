namespace Exercicio_26.ConsoleApp
{
    //Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequencia de Fibonacci! \n");

            Console.WriteLine("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0, j = 1, k = 0; k <= numero;)
            {
                k = i + j;
                i = j;
                j = k;

                if (k <= numero)
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
}
