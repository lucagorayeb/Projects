using Calculadora.Continuar;


namespace Calculadora.Calculadora
{
    class Calcular
    {
         public static void Calculadora(double n1, double n2, string? op)
        {
            if(n2==0){
                Console.WriteLine("Digite a operação: ");
                op = Console.ReadLine();
                Console.WriteLine("Digite o valor: ");
                n2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            double res = 0;
            switch (op)
            {
                case "+": 
                    res = n1 + n2;
                    break;
                
                case"-":
                    res = n1 - n2;
                    break;

                case"x": case"*":
                    res = n1*n2;
                    break;

                case"/":
                    if(n2==0){
                        Console.WriteLine("Erro: Divisão por zero não é permitida!");
                        return;
                    }

                    res = n1 / n2;
                    break;
                
                case "r": 
                    res = RaizNewton(n1, n2);
                    break;

                default:
                    Console.WriteLine("ERRO");
                    break;
            }

            Console.WriteLine($"Resultado: {n1.ToString("F2")} {op} {n2} = {res.ToString("F2")}");//Interpolação de strings

            Continua.Continuar(res);
        }

            
            static double RaizNewton(double x, double n, double precisao = 1e-7) {
                double r = x / n;  // Chute inicial
                while (Math.Abs(Math.Pow(r, n) - x) > precisao) {
                    r = ((n - 1) * r + x / Math.Pow(r, n - 1)) / n;
                }
            return r;
            }
        
    } 
}
   

