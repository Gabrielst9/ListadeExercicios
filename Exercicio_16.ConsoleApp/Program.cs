namespace Exercicio_16.ConsoleApp
{
    internal class Program
    {
        //Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
        //Após o aumento, desconte 8% de impostos.
        //Imprima o salário inicial, o salário com o aumento e o salário final.
        static void Main(string[] args)
        {
            decimal salario = default;
            decimal aumento = default;
            decimal imposto = 0.08m;
            decimal salarioFinal = default;

            Console.WriteLine("Calculo de Aumento Salarial");

            Console.WriteLine("Informe o salário do funcionário: ");
            salario = decimal.Parse(Console.ReadLine());

            //calculo
            aumento = salario * 0.15m;
            salarioFinal = salario + aumento - (imposto * salario);

            Console.WriteLine($"\nSalário inicial: {salario}");
            Console.WriteLine($"Salário com aumento: {salario + aumento}");
        }
    }
}
