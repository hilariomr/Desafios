using System;

namespace Alfabetica
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[2] {"Julio", "Astolfo"};
            

            
            foreach (string nome in nomes)
            {
                Array.Sort(nomes);
                System.Console.WriteLine(nome);
            }


        }
    }
}

//Criar uma aplicação que entre com dois nomes e imprimi-los em ordem alfabética.