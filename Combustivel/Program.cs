using System;

namespace Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempoViagem, mediaVelocidade;

            System.Console.WriteLine("Digite a velocidade media realizada: ");
            mediaVelocidade = int.Parse (Console.ReadLine());
            System.Console.WriteLine("Digite o tempo gasto na viagem: ");
            tempoViagem = int.Parse (Console.ReadLine());

            double distanciaViagem, combustivelViagem;
            distanciaViagem = tempoViagem * mediaVelocidade;
            combustivelViagem = distanciaViagem / 12;

            System.Console.WriteLine("Dados da viagem: ");
            System.Console.WriteLine("Velocidade Media: " + mediaVelocidade);
            System.Console.WriteLine("Tempo gasto de viagem: " + tempoViagem);
            System.Console.WriteLine("Distancia percorrida: " + distanciaViagem);
            System.Console.WriteLine("Consumo de combustivel: " + combustivelViagem);
        }
    }
}
