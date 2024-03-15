namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float comprimento = default;
            float largura = default;
            float altura = default;
            float resultado = default;

            while (true)
            {
                Console.WriteLine("Calculadora de Volume");

                Console.WriteLine("Digite o valor do comprimento da caixa:");
                comprimento = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da largura:");
                largura = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da altura:");
                altura = float.Parse(Console.ReadLine());

                resultado = comprimento * largura * altura;

                Console.WriteLine($"O volume da caixa é: {resultado}");
            }
        }
    }
}
