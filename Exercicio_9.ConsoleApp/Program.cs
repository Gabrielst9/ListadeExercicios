namespace Exercicio_9.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular a média harmônica das notas de um Aluno
        static void Main(string[] args)
        {
            double[] notas = new double[100];

            double mediaHarmonica = CalculaMediaHarmonica(notas);

            Console.WriteLine($"A média harmônica das notas é: {mediaHarmonica}");
        }

        static double CalculaMediaHarmonica(double[] notas)
        {
            double soma = default;
            double media = default;

            for (int i = 0; i < notas.Length; i++)
            {
                soma += 1 / notas[i];
            }

            media = notas.Length / soma;

            return media;
        }
    }
}
