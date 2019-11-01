using System;

namespace Crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3] {44, 300, 10};
            

            Array.Sort(numeros);
            foreach (int numero in numeros)
                {
                    System.Console.WriteLine(numero);
                }
        }
    }
}
