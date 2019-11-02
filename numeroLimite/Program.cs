using System;

namespace numeroLimite
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 75;

            for(int i = 1; i <= num1; i= i+2)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}

//Criar uma aplicação que leia um número que será o limite superior de um intervalo e 
//imprimir todos os números ímpares menores do que esse número.