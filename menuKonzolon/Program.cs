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
            
            
            int menuLeft = 10; 
            int menuTop = 5;   

            do
            {
                Console.Clear();
                Console.Beep();
                Console.Title = "Személyes adatok kezelése";

                
                Console.SetCursorPosition(menuLeft, menuTop);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔══════════════════════════════════════════════╗");
                Console.SetCursorPosition(menuLeft, menuTop + 1);
                Console.WriteLine("║      Személyes adatok kezelése - Menü       ║");
                Console.SetCursorPosition(menuLeft, menuTop + 2);
                Console.WriteLine("╠══════════════════════════════════════════════╣");
                Console.ResetColor();

                Console.SetCursorPosition(menuLeft, menuTop + 3);
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("║  1  │ Személyes adatok bevitele             ║");
                Console.SetCursorPosition(menuLeft, menuTop + 4);
                Console.WriteLine("║  2  │ Személyes adatok kiírása              ║");
                Console.SetCursorPosition(menuLeft, menuTop + 5);
                Console.WriteLine("║  3  │ Kilépés                               ║");
                Console.ResetColor();

                Console.SetCursorPosition(menuLeft, menuTop + 6);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╚══════════════════════════════════════════════╝");
                Console.ResetColor();

                Console.SetCursorPosition(menuLeft, menuTop + 8);
                Console.WriteLine("A megfelelő menüpont számával választhat:");
                valasz = Console.ReadLine();

                if (valasz == "1")
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
                else if (valasz == "2")
                {
                    Console.WriteLine($"Név: {nev}\n" +
                        $"Neme: {(ffi ? "férfi" : "nő")}\n" +
                        $"Születési év: {szulEV}\n");
                    Console.WriteLine("Enterre tovább...");
                    Console.ReadLine();
                }
                else if (valasz == "3")
                {
                    Console.WriteLine("Biztosan ki akar lépni (i/n)?: ");
                    valasz = Console.ReadLine() != "i" ? " " : "3"; 
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nem létező menüpont, kérem válasszon másikat");
                    Console.ResetColor();
                    Console.WriteLine("Enterre tovább...");
                    Console.ReadLine();
                }
            } while (valasz != "3");
        }
    }
}
