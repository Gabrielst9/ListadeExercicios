namespace Exercicio_12.ConsoleApp
{
    internal class Program
    {
        //A imobiliária Imóbilis vende apenas terrenos retangulares.
        //Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
        static void Main(string[] args)
        {
            double largura, comprimento = default;
            double area = default;

            Console.WriteLine("Calculo da Area do Terreno");

            Console.WriteLine("Informe a largura do terreno: ");
            largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInforme o comprimento do terreno: ");
            comprimento = Convert.ToDouble(Console.ReadLine());

            //calculo da area
            area = largura * comprimento;

            Console.WriteLine($"\nA área do terreno é: {area}");
        }
    }
}
