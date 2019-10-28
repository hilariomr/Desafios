using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseRetangulo, alturaRetangulo;

            System.Console.WriteLine("Digite a base do retângulo: ");
            baseRetangulo = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a altura do retângulo: ");
            alturaRetangulo = int.Parse(Console.ReadLine());

            double perimetroRet = (baseRetangulo + alturaRetangulo) * 2;
            double areaRet = baseRetangulo*alturaRetangulo;
            double diagonalRet = (baseRetangulo * baseRetangulo) + (alturaRetangulo * alturaRetangulo);

            System.Console.WriteLine("Perimetro do Retangulo: " + perimetroRet);
            System.Console.WriteLine("Area do Retangulo: " + areaRet);
            System.Console.WriteLine("Diagonal do Retangulo: " + diagonalRet);

        }
    }
}
