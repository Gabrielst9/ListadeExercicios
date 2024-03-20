namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal comprimento, largura, altura, volume;

            while (true)
            {
                Console.WriteLine("\n Calculadora de Volume");

                comprimento = ObterNumeroDecimal("Digite o valor do comprimento: ");

                Console.WriteLine();
                largura = ObterNumeroDecimal("Digite o valor da largura:");

                Console.WriteLine();
                altura = ObterNumeroDecimal("Digite o valor da altura: ");

                volume = CalculaVolume(comprimento, largura, altura);

                ExibirResultado(volume);

                DesejaContinuar("\n Deseja Continuar? (S/N)");
            }
        }

        private static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine($"O volume da caixa é: {resultado}");
        }

        static decimal ObterNumeroDecimal(string texto)
        { 
            Console.WriteLine(texto);

            decimal numeroDigitado = decimal.Parse(Console.ReadLine());
            
            return numeroDigitado;
        }

        static decimal CalculaVolume(decimal comprimento, decimal largura, decimal altura)
        {
            return comprimento * largura * altura;
        }

        static void DesejaContinuar(string resposta)
        {
            Console.WriteLine(resposta);

            string verifica = Console.ReadLine().ToUpper();

            while (verifica != "S" && verifica != "N")
            {
                Console.WriteLine("\n Opção inválida. Digite S para continuar ou N para sair.");
                verifica = Console.ReadLine().ToUpper();
            }

            if (verifica == "N")
            {
                Environment.Exit(0);
            }
        }
    }
}
