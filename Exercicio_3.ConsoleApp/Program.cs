namespace Exercicio_3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = default;
            double altura = default;
            double volume = default;

            while (true)
            {
                Console.WriteLine("\nCalculando o Volume de um Cilindro\n");

                Console.WriteLine(" Digite o valor do raio do cilindro:");
                raio = float.Parse(Console.ReadLine());

                Console.WriteLine("\n Digite o valor da altura do cilindro:");
                altura = float.Parse(Console.ReadLine());

                volume = CalculaVolume(raio, altura);

                ExibirResultado(volume);

                DesejaContinuar("\n Deseja Continuar? (S/N)");
            }
        }


        static double CalculaVolume(double raio, double altura)
        {
            return Math.PI * ( raio * raio ) * altura;
        }

        private static void ExibirResultado(double volume)
        {
            Console.WriteLine($"\n O volume do cilindro é: {volume}");
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
