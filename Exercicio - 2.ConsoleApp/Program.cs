namespace Exercicio___2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float fahrenheit = default;
            float celsius = default;

            Console.WriteLine("Conversao de Fahrenheit para Celsius\n");

            Console.WriteLine("Digite a temperatura em Fahrenheit:");
            fahrenheit = float.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em Celsius é: {celsius}");
        }
    }
}
