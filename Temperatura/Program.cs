using System;

class Program{

    static void Main(){
        Console.WriteLine("Para qual tempertura você quer converte?");
        string? r = Console.ReadLine();

        Console.WriteLine("Qual o valor que deseja converter? ");
        double num = Convert.ToInt32(Console.ReadLine());

        TipoConvesao(r, num);
    }

    static void TipoConvesao(string? r, double valor){

        switch(r){

            case "C": case "c": case "celsius": case "Celsius": case "CELSIUS":
                Console.Write(ConvertToC(valor).ToString("F1"));
                Console.Write("° C");
                break;
            
            case "F": case "f": case "Fahrenheit": case "fahrenheit": case "FAHRENHEIT":
                Console.Write(ConvertToFh(valor).ToString("F1"));
                Console.Write("° F");
                break;
            
            default:
                Console.WriteLine("Erro");
                break;
        }
    }

    static double ConvertToFh(double valor){
        double temp = (valor*9 + 5*32)/5;
        return temp;
    }

    static double ConvertToC(double valor){
        double temp = (valor - 32)*5/9;
        return temp;
    }
}
