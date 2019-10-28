using System;

namespace TrocaVariavel
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            System.Console.WriteLine("Insira o primeiro numero: ");
            num1 = int.Parse (Console.ReadLine());
            System.Console.WriteLine("Insira o segundo numero: ");
            num2 = int.Parse (Console.ReadLine());

            if (num1 != num2){
                num3 = num1;
                num1 = num2;
                num2 = num3;

                System.Console.WriteLine($"{num1}  {num2}");
            } else {
                System.Console.WriteLine("Numero Invalido");
            }
            
        }
    }
}


//Criar uma aplicação que leia dois valores para as variáveis A e B, efetuar a troca dos valores de forma que a variável 
//A passe a ter o valor da variável B e a variável B passe a ter o valor da variável A. Apresentar os valores trocados.