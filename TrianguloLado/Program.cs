using System;

namespace TrianguloLado
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            System.Console.WriteLine("Insira o primeiro número: ");
            num1 = int.Parse (Console.ReadLine());
            System.Console.WriteLine("Insira o segundo número: ");
            num2 = int.Parse (Console.ReadLine());
            System.Console.WriteLine("Insira o Terceiro número: ");
            num3 = int.Parse (Console.ReadLine());

            if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
            {
                System.Console.WriteLine("Os números podem ser lados de um triângulo");
            }else{
                System.Console.WriteLine("Os números não podem ser lados de um triângulo");
            }
        }
    }
}

//Criar uma aplicação que peça para o usuário três números e verificar se eles podem ou não ser lados de um triângulo.
// Imprimir a classificação segundo os lados ou uma mesagem dizendo que os lados não fazem parte de um triângulo.
// Para ser um triângulo válido, o comprimento de um lado do triângulo é sempre menor do que a soma dos outros dois.