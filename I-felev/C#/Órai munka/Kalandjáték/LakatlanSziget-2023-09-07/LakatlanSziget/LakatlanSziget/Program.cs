using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LakatlanSziget
{
    internal class Program
    {
        static void Main()
        {
            Kezdes();
        }

        static bool kapE = false;
        static Encounters encounters = new Encounters();

        static void Kezdes()
        {
            Console.WriteLine("Üdvözöllek a Lakatlan Szigeten! Nem egy kellemes hely ez tudom, de ahhoz hogy túlélj fel kell kutatnod az egész szigetet, hogy találhass Eszközöket, Élelmet és Vizet. Ezek kulcsfontosságú eszközök, amelyek átsegítenek a Szigeten! c:");
            Console.ReadLine();
            Console.WriteLine("\nA kezdéshez csak egy Entert kell nyomnod! Kellemes Szórakozást!^-^");
            Console.ReadLine();
            Console.Clear();

            encounters.Encounter1();
            encounters.Encounter2();
            encounters.Encounter3();
            encounters.Encounter4();

            ending();

        }

        static void ending()
        {
            if (encounters.player.Skippek.Count == 4)
            {
                Console.WriteLine("A sok lehetőség és kaland helyett te a menekülést és egyedüllétet választottad minden esetben. Ennek okául a fáradtságtól, szomjúságtól és éhinségtől kimerülten összeestél és soha nem jutottál ki a szigetről.");
            }
            else if (encounters.player.Skippek.Count != 4 && encounters.player.Hp != 100 && !encounters.player.Targyak.Contains("kiskés"))
            {
                Console.WriteLine("A pókkal való találkozás után nem találtál semmit, ami segített volna a sérüléseden vagy kijutásodban a szigetről, szóval egy szebb fát keresve magadnak lerogytál a tövébe és az idővel elfertőződött sérüléseddel elaludtál örökké.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nVÉGE");
                Console.ReadLine();
            }
        }
    }
}
