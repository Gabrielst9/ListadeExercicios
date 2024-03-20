namespace Exercicio___2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float fahrenheit, celsius;

            while (true)
            {
                Console.WriteLine("\nConversao de Fahrenheit para Celsius\n");

                Console.WriteLine("Digite a temperatura em Fahrenheit:");
                fahrenheit = float.Parse(Console.ReadLine());

                celsius = CalculaResultado(fahrenheit);

                ExibirResultado(celsius);

                DesejaContinuar("\n Deseja Continuar? (S/N)");
            }
        }

        static float CalculaResultado(float fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        private static void ExibirResultado(float celsius)
        {
            Console.WriteLine($"\n A temperatura em Celsius é: {celsius}");
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
