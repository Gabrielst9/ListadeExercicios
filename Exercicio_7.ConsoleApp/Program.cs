namespace Exercicio_7.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular o salário total de um vendedor.
        //Deverá ser informado o salário base e o total de vendas.
        //A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.
        static void Main(string[] args)
        {
            decimal salarioBase = default;
            decimal totalVendas = default;
            decimal comissao = default;
            decimal salarioTotal = default;

            Console.WriteLine("Calculando O salario Total!\n");

            Console.WriteLine("Informe o salario base: ");
            salarioBase = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o total de vendas: ");
            totalVendas = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o percentual de comissão: ");
            comissao = decimal.Parse(Console.ReadLine());

            salarioTotal = salarioBase + (totalVendas * (comissao / 100));

            Console.WriteLine($"\nO salario total é: {salarioTotal}");
        }
    }
}
