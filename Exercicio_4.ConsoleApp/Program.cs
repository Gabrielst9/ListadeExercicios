namespace Exercicio_4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quilometragemInicial = default;
            double quilometragemFinal = default;
            double consumo = default;

            Console.WriteLine("Calculando o Consumo de Combustivel por KM\n");

            Console.WriteLine("Digite a quilometragem Inicial:");
            quilometragemInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a quilometragem Final:");
            quilometragemFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o consumo de combustivel:");
            consumo = double.Parse(Console.ReadLine());

            //Calculando
            double distancia = quilometragemFinal - quilometragemInicial;
            double consumoTotal = distancia / consumo;

            Console.WriteLine("\nO consumo total de combustivel foi: " + consumoTotal + " litros.");
        }
    }
}
