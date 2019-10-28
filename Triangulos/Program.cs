using System;

namespace Triangulos {
    class Program {
        static void Main (string[] args) {
            int altTri;

            System.Console.WriteLine ("Insira a altura do triangulo: ");
            altTri = int.Parse (Console.ReadLine ());

            for (int i = 0; i <= altTri; i++) {
                for (int j = i; j < altTri ; j++) {
                    System.Console.Write ("*");
                }
                System.Console.WriteLine ();
            }

        }
    }
}