namespace Exercicio_5.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma esfera
        static void Main(string[] args)
        {
            double raio,volume;

            Console.WriteLine("Calculando o Volume de uma Esfera \n");

            Console.WriteLine("Digite o valor do raio da esfera:");
            raio = double.Parse(Console.ReadLine());

            //Calculando;
            volume = CalculaVolume(raio);

            ExibirResultado(volume);
        }

        static double CalculaVolume(double raio)
        {
            double calculo = (4 * (raio * raio * raio)) / 3 * Math.PI;

            return calculo;
        }

        private static void ExibirResultado(double volume)
        {
            Console.WriteLine($"\nO volume da esfera é: {volume}");
        }
    }
}
