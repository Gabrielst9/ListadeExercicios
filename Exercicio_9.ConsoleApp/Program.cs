namespace Exercicio_9.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular a média harmônica das notas de um Aluno
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, mediaHarmonica = default;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());               

            Console.Write("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            mediaHarmonica = 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));

            Console.WriteLine($"A média harmônica das notas é: {mediaHarmonica}");
        }

    }
}
