using System.Numerics;

namespace Exercicio_14.ConsoleApp
{
    internal class Program
    {
        //Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
        //Considere sempre anos completos, e que um ano possui 365 dias.
        //Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
        static void Main(string[] args)
        {
            string nome = default;
            int idade = default;
            int diasdeVida = default;
  
            Console.WriteLine("Calculadora da Morte");

            Console.WriteLine("Informe o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("\nInforme a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            //calculo
            diasdeVida = idade * 365;

            Console.WriteLine($"\n{nome}, você já viveu {diasdeVida} dias.");
        }
    }
}
