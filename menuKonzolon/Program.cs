using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace menuKonzolon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev = "";
            bool ffi = true;
            int szulEV = 0; 
            string valasz = "";
            do
            {
                //Console.Beep();
                Console.Clear();
                Console.Title = "Személyes adatok kezelése";
                Console.WriteLine("6 - Személyes adatok bevitele");
                Console.WriteLine("7 - Személyes adatok kiírása");
                Console.WriteLine("67 - Kilépés\n");
                Console.WriteLine("A megfelelő menüpont számával választhat");
                valasz = Console.ReadLine();
                //if-fel szépen végigmehetnénk
                if (valasz == "6")
                {
                    Console.Write("Kérem, adja meg a nevet: ");
                    nev = Console.ReadLine();
                    Console.Write("Neme (f/n): ");
                    ffi = Console.ReadLine() == "f";
                    Console.Write("Kérem, adja meg a születési évét: ");
                    szulEV = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sikeresen rögzítettük az adatokat. Enterre tovább...");
                    Console.ReadLine();
                }
                else if (valasz == "7")
                {
                    Console.WriteLine($"Név: {nev}\n" +
                        $"Neme: {ffi}\n" +
                        $"Születési év: {szulEV}\n");
                    Console.WriteLine("Enterre tovább...");
                    Console.ReadLine();

                }
                else if (valasz == "67")
                {
                    Console.WriteLine("Biztosan ki akar lépni (i/n)?: ");
                    valasz = Console.ReadLine() != "i" ? " " : "67"; 
                }
                else
                {
                    Console.WriteLine("Nem létező menüpontm, kérem válasszon másikat");
                }
            } while (valasz != "67");
        }
    }
}
