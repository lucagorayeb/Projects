using System;

class Program{

    static void Main(){
    Console.WriteLine("JOGO DA ADIVINHAÇÃO");

    int num = Sorteia();
    int valor = Palpite();

    Guess(valor, num);
    }


    static void Guess(int r, int numero){
        while(r!=numero){
            if(r > numero){
                Console.WriteLine("Muito alto");
                Console.Clear();
            }else{
                Console.WriteLine("Muito Baixo");
                Console.Clear();
            }

            r = Palpite();
        }

        Console.WriteLine("Parabéns você adivinhou o número");
    }

    static int Sorteia(){
        Random random = new();
        int numero = random.Next(0, 1000); 

        return numero;
    }

    static int Palpite(){
        Console.WriteLine("Digite um número: ");
        int n = Convert.ToInt32(Console.ReadLine());

        return n;
    }

}

