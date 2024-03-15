namespace Exercicio_20.ConsoleApp
{
    internal class Program
    {
        //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
        static void Main(string[] args)
        {
            float numero = default;

            Console.WriteLine("Par ou Ímpar! \n");

            Console.WriteLine("Digite um número: ");
            numero = float.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é ímpar");
            }
        }
    }
}
