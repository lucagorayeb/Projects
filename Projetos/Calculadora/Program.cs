using Calculadora.Calculadora;

namespace Calculadora
{
    class Program 
    {
        static void Main()
            {
                Console.WriteLine("Digite o primeiro número:");
                double n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a operação:");
                string? op = Console.ReadLine();

                Console.WriteLine("Digite o segundo número:");
                double n2 = Convert.ToInt32(Console.ReadLine());

                Calcular.Calculadora(n1, n2, op);
            }
    }
}


