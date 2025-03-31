using Calculadora.Calculadora;

namespace Calculadora.Passa_V{
    class PassaV(){
        
            public static void PassaValor(double valor){ //Função que passa o valor do resultado da ultima operação 
            double n1 = valor;
            double n2 = 0;

            Calcular.Calculadora(n1, n2, null);
        }
    }
}