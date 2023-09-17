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
            //F5();
            //F6();
            //F7();
            //F8();
            //F9();
            //F10();
            //F11();
            //F12();
            //F13();
            //F14();
            //F15();
            //F16();
            F17();
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
            Console.Write("A oldal: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("B oldal: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("K/T: ");
            char karakter = Convert.ToChar(Console.ReadLine());

            if (karakter == 'K')
            {
                Console.WriteLine($"A téglalap kerülete: {(a + b) * 2}");
            }
            else if (karakter == 'T')
            {
                Console.WriteLine($"A téglalap területe: {a * b}");
            }
            else
            {
                Console.WriteLine("Érvénytelen karakter!");
            }
        }

        static void F6()
        {
            Console.Write("Pontszám: ");
            int pont = Convert.ToInt32(Console.ReadLine());

            if (pont >= 0 && pont <= 42)
            {
                Console.WriteLine("Elégtelen.");
            }
            else if (pont >= 43 && pont <= 57)
            {
                Console.WriteLine("Elégséges.");
            }
            else if (pont >= 58 && pont <= 72)
            {
                Console.WriteLine("Közepes.");
            }
            else if (pont >= 73 && pont <= 87)
            {
                Console.WriteLine("Jó.");
            }
            else if (pont >= 88 && pont <= 100)
            {
                Console.WriteLine("Jeles.");
            }
        }

        static void F7()
        {
            Console.Write("Hónap száma: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam == 1 || szam == 2 || szam == 12)
            {
                Console.WriteLine("Tél van.");
            }
            else if (szam >= 3 && szam <= 5) 
            {
                Console.WriteLine("Tavasz van.");
            }
            else if (szam >= 6 && szam <= 8)
            {
                Console.WriteLine("Nyár van.");
            }
            else if (szam >= 9 && szam <= 11)
            {
                Console.WriteLine("Ősz van.");
            }
        }

        static void F8()
        {
            Console.Write("Fej vagy írás? [0/1]: ");
            int tipp = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int eredmeny = random.Next(0, 2);

            if (tipp == eredmeny)
            {
                Console.WriteLine("Gratulálok!");
            }
            else
            {
                Console.WriteLine("Próbálja újra.. :c");
            }
        }

        static void F9()
        {
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
        }

        static void F10()
        {
            List<int> lista = new List<int>();

            while (lista.Sum() <= 100)
            {
                Console.Write("Szám: ");
                lista.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }

        static void F11()
        {
            Console.Write("Szám: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int osszeg = 0;

            if (szam % 2 == 0)
            {
                for (int i = szam - 1; i >= 0; i -= 2)
                {
                    osszeg += i;
                }
            }
            else
            {
                for (int i = szam - 2; i >= 0; i -= 2)
                {
                    osszeg += i;
                }
            }
            
            Console.WriteLine($"Összeg: {osszeg}");
        }

        static void F12()
        {
            Console.Write("Összeg: ");
            int osszeg = Convert.ToInt32(Console.ReadLine());

            int ketszaz = 0;
            int szaz = 0;
            int otven = 0;
            int husz = 0;
            int tiz = 0;
            int ot = 0;

            if (osszeg <= 1000)
            {
                while (osszeg > 199)
                {
                    osszeg -= 200;
                    ketszaz++;
                }

                while (osszeg > 99)
                {
                    osszeg -= 100;
                    szaz++;
                }

                while (osszeg > 49)
                {
                    osszeg -= 50;
                    otven++;
                }

                while (osszeg > 19)
                {
                    osszeg -= 20;
                    husz++;
                }

                while (osszeg > 9)
                {
                    osszeg -= 10;
                    tiz++;
                }

                while (osszeg > 4)
                {
                    osszeg -= 5;
                    ot++;
                }

                if (osszeg > 0)
                {
                    ot--;
                    tiz++;
                }

                if (ot % 2 == 0 && ot > 1)
                {
                    ot -= 2;
                    tiz++;
                }

                if (tiz % 2 == 0 && tiz > 1)
                {
                    tiz -= 2;
                    husz++;
                }

                if (husz % 2 == 0 && tiz >= 1 && husz > 1)
                {
                    husz -= 2;
                    tiz--;
                    otven++;
                }

                if (otven % 2 == 0 && otven > 1)
                {
                    otven -= 2;
                    szaz++;
                }

                if (szaz % 2 == 0 && szaz > 1)
                {
                    szaz -= 2;
                    ketszaz++;
                }
            }

            Console.WriteLine($"200: {ketszaz}");
            Console.WriteLine($"100: {szaz}");
            Console.WriteLine($"50: {otven}");
            Console.WriteLine($"20: {husz}");
            Console.WriteLine($"10: {tiz}");
            Console.WriteLine($"5: {ot}");
        }

        static void F13()
        {
            Random random = new Random();
            int eredmeny = random.Next(0, 101);

            Console.Write("Tipp: ");
            int tipp = Convert.ToInt32(Console.ReadLine());

            while (tipp != eredmeny)
            {
                if (tipp < eredmeny)
                {
                    Console.WriteLine("A szám nagyobb volt.");
                }
                else
                {
                    Console.WriteLine("A szám kisebb volt.");
                }

                Console.Write("Tipp: ");
                tipp = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("GRATULÁLOK!");
        }

        static void F14()
        {
            Console.Write("Szöveg: ");
            string szoveg = Console.ReadLine();

            Console.WriteLine(@"Mit szeretne csinálni?
                                a: Nagy betűssé alakítani
                                b: Kisbetűssé alakítani
                                c: Lekérdezni a hosszát
                                d: Összehasonlítani egy másik szöveggel
                                e: Egy részét kiíratni
                                f: Kilépni");
            string valasz = Console.ReadLine();

            while (valasz != "f")
            {
                if (valasz == "a")
                {
                    Console.WriteLine($"{szoveg.ToUpper()}");
                }
                else if (valasz == "b")
                {
                    Console.WriteLine($"{szoveg.ToLower()}");
                }
                else if ( valasz == "c")
                {
                    Console.WriteLine($"{szoveg.Length} a hossza.");
                }
                else if ( valasz == "d")
                {
                    Console.WriteLine("Összehasonlítandó szöveg: ");
                    string szoveg2 = Console.ReadLine();

                    if (szoveg == szoveg2)
                    {
                        Console.WriteLine("Azonos a kettő szöveg!");
                    }
                    else
                    {
                        Console.WriteLine("Nem azonos a kettő szöveg!");
                    }
                }
                else if (valasz == "e")
                {
                    Console.WriteLine($"{szoveg.Substring(1, 2)}");
                }
                else
                {
                    Console.WriteLine("Rossz input!");
                }

                Console.WriteLine(@"Mit szeretne csinálni?
                                a: Nagy betűssé alakítani
                                b: Kisbetűssé alakítani
                                c: Lekérdezni a hosszát
                                d: Összehasonlítani egy másik szöveggel
                                e: Egy részét kiíratni
                                f: Kilépni");
                valasz = Console.ReadLine();
            }
        }

        static void F15()
        {
            int[] tomb = new int[25];

            Random random = new Random();

            for (int i = 0; i < 25; i++)
            {
                int szam = random.Next(0, 100);
                tomb[i] = szam;
            }

            for (int i = 0; i < 25; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(Math.Pow(i, 2) + ", ");
                }
            }
        }

        static void F16()
        {
            int[] tomb = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Szám: ");
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write(tomb[i] + ", ");
            }

            for (int i = 4; i >= 0; i--)
            {
                Console.Write(tomb[i] + ", ");
            }

            for (int i = 0; i < 5; i += 2)
            {
                Console.Write(tomb[i] + ", ");
            }

            Console.Write("Szám 1-5: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(tomb[index]);
        }

        static void F17()
        {
            Random random = new Random();

            int[] tomb1 = new int[5];
            int[] tomb2 = new int[5];
            int[] tomb3 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                int tag = random.Next(0, 6);
                tomb1[i] = tag;
                int tag2 = random.Next(0, 6);
                tomb2[i] = tag2;
            }

            for (int i = 0; i < 5; i++)
            {
                int szam = tomb1[i] + tomb2[i];
                tomb3[i] = szam;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write(tomb1[i] + ", ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(tomb2[i] + ", ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(tomb3[i] + ", ");
            }
        }
    }
}
