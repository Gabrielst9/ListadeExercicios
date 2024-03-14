namespace Exercicio_3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float raio = default;
            float altura = default;
            float pi = 3.14f;
            float volume = default;
            
            Console.WriteLine(" Calculando o Volume de um Cilindro\n");

            Console.WriteLine(" Digite o valor do raio do cilindro:");
            raio = float.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite o valor da altura do cilindro:");
            altura = float.Parse(Console.ReadLine());

            //Calculando
            volume = pi * (raio * raio) * altura;

            //resposta
            Console.WriteLine($"\n O volume do cilindro é: {volume}");
        }
    }
}
