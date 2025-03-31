using Calculadora.Passa_V;
using Calculadora.Calculadora;

namespace Calculadora.Continuar
{

  public class Continua
    {
        public static void Continuar(double res) //Função que verifica a continuidade da operação 
        {
            MenuR();
            string? r;
            Console.WriteLine("Quer fazer outra operação? ");
            r = Console.ReadLine();
            
            Console.Clear();
            
            switch (r)
            {
                case "Não": case "NÃO": case "não": 
                    Console.WriteLine("Programa finalizado"); 
                break;
                
                case "Nao": case "NAO": case "nao": 
                    Console.WriteLine("Programa finalizado"); 
                break;

                case "Sim": case "SIM": case "sim": 
                    MenuC(); 
                    PassaV.PassaValor(res); 
                    Console.WriteLine(); 
                break;

                case "ZERAR": case "Zerar": case "zerar": 
                    Program.Main(); 
                    Console.WriteLine(); 
                break;
                
                default: 
                    Console.WriteLine("Erro"); 
                break;
            }
        }

            public static void MenuC()//Função que cria um menu mostrando as operações que a calculadora executa
            {   
                Console.WriteLine("------------------");
                Console.WriteLine("\tMENU ");
                Console.WriteLine("------------------\n");
                Console.WriteLine("     OPERAÇÕES\n");
                Console.WriteLine("Digite '+' para somar");
                Console.WriteLine("Digite '-' para subtrair");
                Console.WriteLine("Digite 'x' para multiplicar");
                Console.WriteLine("Digite '/' para dividir");
                Console.WriteLine("Digite '^' para potência");
                Console.WriteLine("Digite 'r' para raiz\n\n");
            }

            static void MenuR(){//Função que cria um menu mostrando as opções depois de se obter o resultado da operação

                Console.WriteLine("------------------");
                Console.WriteLine("\tMENU ");
                Console.WriteLine("------------------\n");
                Console.WriteLine("\tOPÇÕES\n");
                Console.WriteLine("Digite 'Sim' para fazer outa operação ");
                Console.WriteLine("Digite 'Não' para finalizar a operação");
                Console.WriteLine("Digite 'Zerar' para zerar a operação\n\n");


            }
    } 
}