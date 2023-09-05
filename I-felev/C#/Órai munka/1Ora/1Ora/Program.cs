using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Ora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //F1();
            //F2();
            //F3();
            //F4();
            F5();
        }

        static void F1()
        {
            Console.Write("Medence átmérője: ");
            double atmero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Medence mélysége: ");
            double melyseg = Convert.ToDouble(Console.ReadLine());

            double eredmeny = Math.Round(Math.Pow(atmero / 2, 2) * Math.PI * melyseg, 2);
            Console.WriteLine($"A medencében {eredmeny} köbméter víz fér el");
        }

        static void F2()
        {
            Console.Write("Szélesség: ");
            double szelesseg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Magasság: ");
            double magassag = Convert.ToDouble(Console.ReadLine());

            double eredmeny = Math.Ceiling(Math.Ceiling(magassag / 0.2) * Math.Ceiling(szelesseg / 0.2) * 1.1);
            Console.WriteLine($"{eredmeny} db csempére van szükség.");
        }

        static void F3()
        {
            Console.Write("Szám 1: ");
            double szam1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A megadott szám a {Math.Floor(szam1)} és a {Math.Floor(szam1 + 1)} egész számok között van, és ezek közül a {Math.Round(szam1)} számhoz van közelebb.");
            Console.WriteLine($"A szám egész része: {Math.Floor(szam1)}");
            Console.WriteLine($"A szám törtrésze: {Math.Round(szam1 - Math.Floor(szam1), 2)}");
        }

        static void F4()
        {
            Console.Write("A oldal: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("B oldal: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("C oldal: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c || a + c > b || b + c > a)
            {
                Console.WriteLine($"A háromszög kerülete: {a + b + c}");
            }
            else
            {
                Console.WriteLine("Érvénytelen háromszög!");
            }
        }

        static void F5()
        {

        }
    }
}
