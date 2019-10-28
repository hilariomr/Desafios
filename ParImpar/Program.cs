using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            System.Console.WriteLine("Insira um número");
            num1 = int.Parse (Console.ReadLine());

            if (num1 % 2 == 0){
                System.Console.WriteLine("O número " + num1 + " é par");
            } else {
                System.Console.WriteLine("O número " + num1 + " é impar");
            }
        }
    }
}
