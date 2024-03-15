namespace Exercicio_10.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
        static void Main(string[] args)
        {
            double peso1, peso2 = default;
            double nota1, nota2 = default;
            double mediaPonderada = default;


            Console.WriteLine("Calculando Media Ponderada!\n");

            Console.WriteLine("Informe a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInforme o peso da primeira nota: ");
            peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInforme a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInforme o peso da segunda nota: ");
            peso2 = Convert.ToDouble(Console.ReadLine());

            //calculo da media ponderada
            mediaPonderada = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);

            Console.WriteLine($"\nA média ponderada é: {mediaPonderada}");
        }
    }
}
