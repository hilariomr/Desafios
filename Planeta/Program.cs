using System;

namespace Planeta
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesoTerra, pesoPlaneta; 
            int numEscolhido;
            double gravMercurio = 0.37;
            double gravVenus = 0.88;
            double gravMarte = 0.38;
            double gravJupiter = 2.64;
            double gravSaturno = 1.15;
            double gravUrano = 1.17;

            System.Console.Write("Digite o peso do objeto na terra: ");
            pesoTerra = double.Parse (Console.ReadLine());

            System.Console.WriteLine("Digite o número do planeta para conversão:");
            System.Console.WriteLine(" 1 - Mercúrio");
            System.Console.WriteLine(" 2 - Vênus");
            System.Console.WriteLine(" 3 - Marte");
            System.Console.WriteLine(" 4 - Júpiter");
            System.Console.WriteLine(" 5 - Saturno");
            System.Console.WriteLine(" 6 - Urano");
            numEscolhido = int.Parse (Console.ReadLine());
            

                switch(numEscolhido)
                {
                    case 1:
                    pesoPlaneta = (pesoTerra/10) * gravMercurio;
                    System.Console.WriteLine($"{pesoTerra}kg na terra é equivalente a {pesoPlaneta}kg em Mercurio.");
                    break;
                    
                    case 2:
                    pesoPlaneta = (pesoTerra/10) * gravVenus;
                    System.Console.WriteLine($"{pesoTerra}kg na terra é equivalente a {pesoPlaneta}kg em Venus.");
                    break;

                    case 3:
                    pesoPlaneta = (pesoTerra/10) * gravMarte;
                    System.Console.WriteLine($"{pesoTerra}kg na terra é equivalente a {pesoPlaneta}kg em Marte.");
                    break;

                    case 4:
                    pesoPlaneta = (pesoTerra/10) * gravJupiter;
                    System.Console.WriteLine($"{pesoTerra}kg na terra é equivalente a {pesoPlaneta}kg em Jupiter.");
                    break;

                    case 5:
                    pesoPlaneta = (pesoTerra/10) * gravSaturno;
                    System.Console.WriteLine($"{pesoTerra}kg na terra é equivalente a {pesoPlaneta}kg em Saturno.");
                    break;

                    case 6:
                    pesoPlaneta = (pesoTerra/10) * gravUrano;
                    System.Console.WriteLine($"{pesoTerra}kg na terra é equivalente a {pesoPlaneta}kg em Urano");
                    break;
                    
                }
        }
    }
}

//*Escrever uma aplicação que leia um peso na Terra e o número de um planeta e imprima o valor 
//do seu peso neste planeta. A relação de planetas é dada a seguir juntamente com o valor 
//das gravidades relativas à Terra: */