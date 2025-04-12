using System;

namespace EXERCICIO3{
    class Program{
        static void Main(String[] args){
            Console.WriteLine("Informe o primeiro numero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero:");
            int numero2 = int.Parse(Console.ReadLine());

            int maiornumero = 0;

             if (numero1 > numero2) {
                maiornumero = numero1;
            } else {
                maiornumero = numero2;
            }

            Console.WriteLine("O maior número é " + maiornumero);

        }
    }
}