namespace Exercicio_5.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma esfera
        static void Main(string[] args)
        {
            float raio = default;
            float pi = 3.14f;

            float volume = default;

            Console.WriteLine("Calculando o Volume de uma Esfera \n");

            Console.WriteLine("Digite o valor do raio da esfera:");
            raio = float.Parse(Console.ReadLine());

            //Calculando;
            volume = (4 * (raio * raio * raio)) /3 * pi;

            Console.WriteLine($"\nO volume da esfera é: {volume}");
        }
    }
}
