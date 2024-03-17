namespace Exercicio_25.ConsoleApp
{
    //Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
    //Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
    //Pesquise sobre “fatorial”

    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.WriteLine("Fatorando um Valor! \n");

            Console.WriteLine("Informe um valor: ");
            valor = int.Parse(Console.ReadLine());
            
            for (int i = valor - 1; i > 0; i--)
            {
                valor *= i;

                if (i > 1)
                {
                    Console.Write(i + " X ");
                }
                else
                {
                    Console.Write(i + " = " + valor);
                }
            }
        }
    }
}