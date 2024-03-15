namespace Exercicio_18.ConsoleApp
{
    internal class Program
    {
        //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
        static void Main(string[] args)
        {
            //int a, b, c = default;
            List<int> valores = new List<int>();
            
            Console.WriteLine("Ordenando Valores");

            Console.WriteLine("Informe o valor de A: ");
            valores.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Informe o valor de B: ");
            valores.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Informe o valor de C: ");
            valores.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            //ordenando
            foreach (var item in valores.OrderByDescending(x => x))
            {
                Console.WriteLine(item);
            }

        }
    }
}
