using System;

namespace Lab5ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 2 Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura este sau nu palindrom */

            Console.WriteLine("Introduceti sirul de caractere = ");
            string sir = Console.ReadLine();

            string mesajPozitiv = "Sirul " + sir + " este palindrom";
            string mesajNegativ = "Sirul " + sir + " nu este palindrom";

            if (string.IsNullOrEmpty(sir) || string.IsNullOrWhiteSpace(sir))
            {
                Console.WriteLine("Nu ai introdus nimic, sau ai introdus spatiu gol. Ruleaza din nou programul.");
                return;
            }

            // sirul e automat palindrom daca are strict 1 caracter
            if (sir.Length == 1)
            {
                Console.WriteLine(mesajPozitiv);
                return;
            }

            bool palindrom = VerificaSirPalindrom(sir);

            if (palindrom == true) Console.WriteLine(mesajPozitiv);
            else Console.WriteLine(mesajNegativ);
        }

        public static bool VerificaSirPalindrom(string sir)
        {
            string inversSir = string.Empty;

            for (int i = sir.Length - 1; i >= 0; i--)  
            {
                inversSir = inversSir + sir[i].ToString();
            }

            if (sir == inversSir) return true;

            return false;

        }
    }
}
