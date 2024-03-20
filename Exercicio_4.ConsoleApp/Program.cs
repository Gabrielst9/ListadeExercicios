namespace Exercicio_4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quilometragemInicial, quilometragemFinal, consumo;

            while (true)
            {
                Console.WriteLine("Calculando o Consumo de Combustivel por KM\n");

                quilometragemInicial = ObterDoubleCalculo("Digite a quilometragem Inicial:");

                quilometragemFinal = ObterDoubleCalculo("\nDigite a quilometragem final:");

                consumo = ObterDoubleCalculo("Digite o consumo de combustivel:");

                //Calculando
                double distancia = quilometragemFinal - quilometragemInicial;

                double consumoTotal = CalculaConsumo(distancia, consumo);

                ExibirResultado(consumoTotal);

                DesejaContinuar("\n Deseja Continuar? (S/N)");
            }
        }

        static double ObterDoubleCalculo(string texto)
        {
            Console.WriteLine(texto);

            double numeroDigitado = double.Parse(Console.ReadLine());

            return numeroDigitado;
        }

        static double CalculaConsumo(double distancia, double consumo)
        {
            return distancia / consumo;
        }

        private static void ExibirResultado(double consumoTotal)
        {
            Console.WriteLine("\nO consumo total de combustivel foi: " + consumoTotal + " litros.");
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
