
using Calculadora.Passa_V;

namespace Calculadora.Continuar
{

  public class Continua
    {
        public static void Continuar(double res)
        {
            
            string? r;
            Console.WriteLine("Quer fazer outra operação? ");
            r = Console.ReadLine();

            switch (r)
            {
                case "Não": case "NÃO": case "não": Console.WriteLine("Programa finalizado"); break;
                
                case "Nao": case "NAO": case "nao": Console.WriteLine("Programa finalizado"); break;

                case "Sim": case "SIM": case "sim": PassaV.PassaValor(res); break;
                
                default: Console.WriteLine("Erro"); break;
            }
        }
    } 
}