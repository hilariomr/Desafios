using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempCentigrados;

            System.Console.WriteLine("Digite a temperatura a ser convertida: ");
            tempCentigrados = int.Parse (Console.ReadLine());

            double tempFahrenheit;

            tempFahrenheit = ((9*tempCentigrados) + 160) / 5;

            System.Console.WriteLine(tempCentigrados + " Centigrados convertidos para Farenheit é: " + tempFahrenheit);


        }
    }
}
