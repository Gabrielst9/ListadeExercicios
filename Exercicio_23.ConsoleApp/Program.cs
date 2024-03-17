namespace Exercicio_23.ConsoleApp
{
    internal class Program
    {
        //Desenvolver um algoritmo que
        //efetue a soma de todos os números ímpares que são
        //múltiplos de três e que se encontram no conjunto dos números de 1 até 500.
        static void Main(string[] args)
        {
            int numerosImpares = default;

            Console.WriteLine("Calculadora de Números Impares! \n");

            for (int i = 0; i <+ 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    numerosImpares += i;
                }
            }

            Console.WriteLine("A soma dos números ímpares múltiplos de três e encontram no conjunto dos números de 1 até 500 é: \n" + numerosImpares);
        }
    }
}
