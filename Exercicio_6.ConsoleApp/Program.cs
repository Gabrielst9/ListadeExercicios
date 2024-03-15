namespace Exercicio_6.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
        static void Main(string[] args)
        {
            float celsius = default;
            float resultado = default;


            Console.WriteLine("Tranformando Celsius em Fahrenheit");

            Console.WriteLine("Digite a temperatura em Celsius:");
            celsius = float.Parse(Console.ReadLine());

            resultado = ((9 * celsius) / 5) + 32;

            Console.WriteLine($"\nA temperatura em Fahrenheit é: {resultado}");
        }
    }
}
