namespace Exercicio_17.ConsoleApp
{
    internal class Program
    {
        //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
        static void Main(string[] args)
        {
            int a, b, c = default;

            Console.WriteLine("Somando Valores!");

            Console.WriteLine("Informe o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o valor de C: ");
            c = int.Parse(Console.ReadLine());

            //condicionamento
            if (a + b < c)
            {
                Console.WriteLine("A soma é menor que C");
            }
            else
            {
                Console.WriteLine("A soma é maior que C");
            }
        }
    }
}