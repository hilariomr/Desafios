using System;

namespace Alfabetica
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[3] {"Julio", "Astolfo", "Maria"};
            

            Array.Sort(nomes);
            foreach (string nome in nomes)
                {
                    System.Console.WriteLine(nome);
                }
        }
    }
}

//Criar uma aplicação que entre com dois nomes e imprimi-los em ordem alfabética.