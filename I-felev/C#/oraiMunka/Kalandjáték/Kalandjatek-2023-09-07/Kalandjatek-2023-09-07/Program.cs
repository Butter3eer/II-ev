using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kalandjatek_2023_09_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalandor jatekos = new Kalandor();
            Jatek(jatekos);
        }

        static int dobasSzam = 0;

        static void Jatek(Kalandor jatekos)
        {
            Console.WriteLine(@"-- Melyik úton szeretnél átkelni?
                a: Hosszú, de biztonságos úton
                b: Rövid, de veszélyes úton");
            string valasz = Console.ReadLine();

            if (valasz == "a" || valasz == "A")
            {
                Console.WriteLine("\nGratulálok! Odaértél biztonságban! ^^");
            }
            else if (valasz == "b" || valasz == "B")
            {
                while ( jatekos.Elet > 0 && jatekos.Dobasok != 0)
                {
                    Console.WriteLine(jatekos.Lehetosegek(jatekos));
                    Console.ReadLine();
                    Console.Write("Dobj a kockával [Nyomj egy entert]:\n ");
                    Thread.Sleep(2000);
                    Random rnd = new Random();
                    dobasSzam = rnd.Next(1, 7);

                    if (dobasSzam != 1)
                    {
                        Console.WriteLine(jatekos.DobasEredmeny(jatekos, dobasSzam));
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("1-est dobtál, ameddig nem dobsz mást nem juthatsz ki a szintről!");

                        while (dobasSzam == 1 && jatekos.Elet > 0)
                        {                           
                            Console.WriteLine(jatekos.DobasEredmeny(jatekos, dobasSzam));
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }

                if (jatekos.Elet <= 0)
                {
                    Console.WriteLine("Az élet elhagyta lassan a tested, és így nem értél át a dzsungelen! :c");
                }
                else if (jatekos.Dobasok == 0)
                {
                    Console.WriteLine("Gratulálok! Kalandokkal és élményekkel (esetleg sebekkel) értél át a dzsungelen!");
                }
            }
            else
            {
                Console.WriteLine("Hibás bevitel!");
            }
        }
    }
}
