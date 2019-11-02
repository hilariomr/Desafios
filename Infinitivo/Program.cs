using System;

namespace Infinitivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Digite um verbo no infinitvo: ");
            string verbo = Console.ReadLine ();
            verbo = verbo.ToLower ();
            bool Conj1 = verbo.EndsWith ("ar");
            bool Conj2 = verbo.EndsWith ("er");
            bool Conj3 = verbo.EndsWith ("ir");

            
            if (Conj1) {
                Console.WriteLine ("Verbo da 1° Conjugação. ");
            } else if (Conj2) {
                Console.WriteLine ("Verbo da 2° Conjugação. ");
            } else if (Conj3) {
                System.Console.WriteLine ("Verbo da 3° Conjugação. ");
            } else {
                System.Console.WriteLine ("Verbo não está no infinitivo. ");
            } 
        }
    }
}

//Crie um programa que permita ao usuário entrar com um verbo no infinitivo 
//e imprimir uma das mensagens:
//Verbo não está no infinitivo.
//Verbo da 1ª- conjugação.
//Verbo da 2ª- conjugação.
//verbo da 3ª- conjugação.