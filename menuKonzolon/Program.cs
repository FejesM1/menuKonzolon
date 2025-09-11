using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuKonzolon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev = "";
            bool ffi = true;
            string szulEV; 
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
                    Console.WriteLine("SIkeresen rögzítettük az adatokat. Enterre tovább...");
                    Console.ReadLine();
                }
                else if (valasz == "7")
                {

                }
                else if (valasz == "67")
                {

                }
                else
                {
                    Console.WriteLine("Nem létező menüpontm, kérem válasszon másikat");
                }
            } while (valasz != "3");
        }
    }
}
