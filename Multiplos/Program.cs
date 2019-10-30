using System;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            System.Console.Write("Digite um número: ");
            num1 = int.Parse (Console.ReadLine());

            if (num1 % 3 == 0 )
            {
                System.Console.WriteLine($"O número {num1} é multiplo de 3");
            }else{
                System.Console.WriteLine($"O número {num1} não é multiplo de 3");
            }
        }
    }
}

//Crie um programa que peça para o usuário entrar com um número e imprimir uma das mensagens:
// é multiplo de 3 ou não é multiplo de 3.