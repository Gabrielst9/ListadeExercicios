namespace Exercicio_13.ConsoleApp
{
    internal class Program
    {
        //A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia.
        //Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
        //Você foi contratado para fazer os cálculos para o dono.
        //Com base nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e depois calcular os dados solicitados.
        static void Main(string[] args)
        {
            int quantidadePao, quantidadeBroa = default;
            decimal resultado = default;
            decimal poupança = default;

            Console.WriteLine("Padaria Hotpão!\n");

            Console.WriteLine("Informe a quantidade de pães vendidos: ");
            quantidadePao = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme a quantidade de broas vendidas: ");
            quantidadeBroa = int.Parse(Console.ReadLine());

            //calculo
            resultado = (quantidadePao * 0.12m) + (quantidadeBroa * 1.50m);
            poupança = resultado * 0.10m;

            Console.WriteLine($"\nO valor arrecadado foi: {resultado}");
            Console.WriteLine("O valor a ser guardado na poupança é: {0:0.00}", poupança);
        }
    }
}
