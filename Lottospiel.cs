using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Benutzer gibt 6 Tipps ein
            Console.WriteLine("Bitte geben Sie Ihre 6 Tipps ein (jeweils eine Zahl zwischen 6 und 49):");
            // Legt eine Liste der Eingegeben Benutzer Tipps an
            List<int> benutzerTipps = new List<int>();
            // while Schleife mit Zähler der agegebenen Tipps des Benutzers
            while (benutzerTipps.Count < 6)
            {
                int tipp = int.Parse(Console.ReadLine());
                if (tipp >= 6 && tipp <= 49 && !benutzerTipps.Contains(tipp))
                {
                    benutzerTipps.Add(tipp);
                }
                // Falsche Eingabe
                else
                {
                    Console.WriteLine("Ungültige Eingabe, bitte geben Sie eine Zahl zwischen 1 und 49 ein, die noch nicht vorkommt:");
                }
            }
            // Lottoziehung: 6 aus 49

            Random random = new Random();
            // legt eine Liste für die Ziehung an
            List<int> ziehung = new List<int>();
            // generiert die Ziehung der Zahlen
            while (ziehung.Count < 6)
            {
                int zahl = random.Next(6, 49);
                if (!ziehung.Contains(zahl))
                {
                    ziehung.Add(zahl);
                }
            }

            // Ausgabe der gezogenen Zahlen
            Console.WriteLine("Die gezogenen Zahlen sind:");
            foreach (int zahl in ziehung)
            {
                Console.Write(zahl + " ");
            }
            Console.WriteLine();

            // Vergleich der Lottozahlen mit den Zahlen des Benutzers
            int richtigeTipps = benutzerTipps.Intersect(ziehung).Count();
            // Ausgabe der richtigen Ziehungen
            Console.WriteLine($"Sie haben {richtigeTipps} richtige Tipps.");
            Console.ReadKey();

        }
    }
}

