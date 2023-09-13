using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LakatlanSziget
{
    internal class Encounters : EncounterTorpe
    {
        public Jatekos player = new Jatekos();

        public void Loading()
        {
            Thread.Sleep(1000);
            Console.Write("\n.");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".\n\n");
            Thread.Sleep(1000);
        }

        public void Encounter1()
        {
            Loading();

            Console.Write("Miközben elindultál felfedezni a szigetet összefutottál egy Törpével, aki felajánlotta, hogy ad élelmet, viszont válaszolnod kell legalább egyszer jól a 3 találos kérdésére! Elvállalod a kihívást? [I/N] >:) ");

            string valasz = Console.ReadLine();

            if (valasz == null || "IiNn".Contains(valasz) == false)
            {
                Console.WriteLine("\nHibás input!");
                Console.ReadLine();
                Console.Clear();
                Encounter1();
            }
            else if (valasz[0] == 'I' || valasz[0] == 'i')
            {
                if (Kerdes1() || Kerdes2() || Kerdes3())
                {
                    Console.WriteLine("\nGratulálok a megszerzett élelemért! :D");
                    player.Targyak.Add("elelem");
                }
                else
                {
                    Console.WriteLine("\nSajnos nem tudtál válaszolni a Törpe kérdéseire, szóval élelem csomag nélkül haladsz tovább a szigeten. :c");
                }
            }
            else if (valasz[0] == 'N' || valasz[0] == 'n')
            {
                Console.WriteLine("\nElutasítva a Törpe élelmét továbbhaladsz a szigeten.");
                player.Skippek.Add(valasz);
            }

            Console.ReadLine();
            Console.Clear();
        }

        public bool Kerdes1()
        {
            bool kapE = false;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\"Rendben Fiam!\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- felelte a Törpe.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\"Az első furfangos kérdésem az lenne, hogy amikor C#-ban furfangozol hány string értéke van mégiscsak egy tabulátornak?\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- tette fel első furfangos kérdését.\n");
            string kerdesValasz = Console.ReadLine();

            if (kerdesValasz == "12")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\"Ooooh nagyon jártas kis Kalandor vagy te! :D\"");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - felelte a Furfangos Törpe, majd átadta a felajánlott naagy zsáknyi élelmet!");
                kapE = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\"Ohohoho! Nagyon furcsa dolgokat mondasz te! A helyes válasz 12 volt!!\"");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - kacagott nagyot a Törpe, miközben legyintve készült következő kérdésével.");
                kapE = false;
            }
            Console.ReadLine();
            Console.Clear();
            return kapE;
        } 

        public bool Kerdes2()
        {
            bool kapE = false;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\"Akkor következzen is a következő feladvány!\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- folytatta.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\"A második kérdés úgy szól, hoooogy melyik karakter segítségével tudunk string kiírásnál idézőjelet írni, hogy az a konzolon is látszódjon? ^.^\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- tette fel folytatásként kérdését a Törpe.\n");
            string kerdesValasz = Console.ReadLine();

            if (kerdesValasz == "\\")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\"Tyűha! Ezt még én se tudtam egészen tegnapig!\"");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - felelte meglepetten a Törpe, majd átadta a felajánlott naagy zsáknyi élelmet!");
                kapE = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\"Haha! Majdnem! De csak majdnem... A helyes válasz \\ volt!\"");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - rázta a fejét a Törpe.");
                kapE = false;
            }
            Console.ReadLine();
            Console.Clear();
            return kapE;
        }

        public bool Kerdes3()
        {
            bool kapE = false;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\"És el is értünk az utosló feladványhoz!\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- folytatta.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\"Nagyon fülelj, mert ha ezt is eltéveszted nem lesz ám itt lakoma!\nA harmadik kérdésem az lenne, hogy mennyi egy töketlen fecske maximális repülési sebessége?\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- tette fel utolsó roppant furfangos kérdését a Törpe. [Csak pontos idézet elfogadott]\n");
            string kerdesValasz = Console.ReadLine();

            string helyes = "Attól függ. Afrikai, vagy Európai fecskéé?";

            if (kerdesValasz == helyes || kerdesValasz == helyes.ToLower())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\"Azt, azt nem tudom. (A híd őre a szurdokba repül.)\"");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - felelte meglepetten a Törpe, majd átadta a felajánlott naagy zsáknyi élelmet!");
                kapE = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\"Ejnye! valaki nagyon nem figyelt oda tv nézés közben!!\"");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - nézett haragosan a Törpe.");
                kapE = false;
            }
            Console.ReadLine();
            Console.Clear();
            return kapE;
        }

        public void Encounter2()
        {
            Loading();

            Console.Write("A Törpével való találkozás után hirtelen valami hajszálra hasonlító anyag lepte el az egész tested. Meglátsz magad előtt egy hatalmas pókhálót ami előtt egy legalább Bud Spencer méretű pók álldogál! Ha tudsz könnyen válaszolni a következő egyszerű matematikai feladatra még időben elosonhatsz mellette! Kiállod a próbát? [I/N] ");
            string input = Console.ReadLine();

            if (input == null || "IiNn".Contains(input) == false)
            {
                Console.WriteLine("\nHibás input!");
                Console.ReadLine();
                Console.Clear();
                Encounter2();
            }
            else if (input[0] == 'I' || input[0] == 'i')
            {
                Console.Write("\n 3 + 2 = ? ");
                string valasz = Console.ReadLine();

                if (valasz == "5")
                {
                    Console.WriteLine("\nHELYES!\nIdőben elsuhantál a pók mellett és folytattad utad a szigeten víz után.");
                }
                else
                {
                    player.Hp -= 20;
                    Console.WriteLine($"JAJ NE!\nA pók meglátott!!\nHatalmas sebességgel előtted termett és egy marással a földre terített.\nGyorsan mielőtt újra támadhatott volna a pók elgurultál a lábai alatt és életedért futva éppenhogy de elmenekültél!! \n(Veszítettél 20 hp-t, jelenlegi hp: {player.Hp})");
                }
            }
            else if (input[0] == 'N' || input[0] == 'n')
            {
                Console.WriteLine("\nGyávaság futni, de hasznos! Ezzel a célmondattal amint megláttad a pókot azonnal vissza is fordultál és újabb irányokba kezdtél el kutatni víz vagy más eszközök után.");
                player.Skippek.Add(input);
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void Encounter3()
        {
            Loading();

            Console.WriteLine("Következő akadályként a sok keresgélés közepette egy titkos ajtó előtt találod magad.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Csak egy szó, palindróm, és ajtót nyitom.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ez az egyetlen szöveg áll az ajtón zöld betűkkel. Megpróbálod kinyitni? [I/N] ");
            string input = Console.ReadLine();

            if (input == null || "IiNn".Contains(input) == false)
            {
                Console.WriteLine("\nHibás input!");
                Console.ReadLine();
                Console.Clear();
                Encounter3();
            }
            else if (input[0] == 'I' || input[0] == 'i')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Kérem a szót: ");
                Console.ForegroundColor = ConsoleColor.White;
                string valasz = Console.ReadLine();

                if (ajtoSzo(valasz))
                {
                    Console.WriteLine("\nMiután megadtad az ajtónak a szót az enyhe remegés után kitárta lassan magát és mögötte megtaláltad az összes dolgot amire valaha szükséged lehet, hogy kijuss a szigetről!!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nalma, futópad, gépfegyver, kiskés, gránát, olló, kanál\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Ezt a sokmindent nagyon gyorsan el is raktad a hátizsákodba, majd motivációval és tele mindennel kezdesz neki az utolsó szakasznak a kalandodból! :D");

                    List<string> items = new List<string>() { "alma", "futópad", "gépfegyver", "kiskés", "gránát", "olló", "kanál" };

                    foreach (string item in items)
                    {
                        player.Targyak.Add(item);
                    }
                }
                else
                {
                    Console.WriteLine("\nSok gondolkodás után végül nem sikerült kitárni az ajtót, amely a rossz próbálkozás után egy szempillantás alatt eltűnt. Ezen furcsa találkozáson gondolkodva tovább ballagsz a szigeten.");
                }               
            }
            else if (input[0] == 'N' || input[0] == 'n')
            {
                Console.WriteLine("\nAz ajtó hirtelen és megbízhatatlan megjelenése miatt inkább továbbállsz.");
                player.Skippek.Add(input);
            }
            Console.ReadLine();
            Console.Clear();
        }

        public bool ajtoSzo(string valasz)
        {
            Loading();

            valasz = valasz.ToLower();

            char[] bevittSzo = valasz.ToCharArray();
            bevittSzo = bevittSzo.Reverse().ToArray();
            string forditottValasz = new string(bevittSzo);

            if (valasz == forditottValasz)
            {
                return true;
            }
            return false;
        }

        public void Encounter4()
        {
            Loading();

            Console.Write("Sok sok sétálás után egy sivatagos területen találod magad, ahol megpillantasz egy csillogó fényt a távolban. Oázis reményében odasietsz, viszont egy üveg asztalt találsz ott rajta egyetlen dobókockával. Dobsz vele? [I/N] ");
            string input = Console.ReadLine();

            if (input == null || "IiNn".Contains(input) == false)
            {
                Console.WriteLine("\nHibás input!");
                Console.ReadLine();
                Console.Clear();
                Encounter4();
            }
            else if (input[0] == 'I' || input[0] == 'i')
            {
                Console.WriteLine("\nA kezedbe vetted a meglepően súlyosabb dobókockát, majd egy jól irányzott mozdulattal dobtál vele az üvegasztalra.");
                Console.ReadLine();

                Loading();

                Random random = new Random();
                int dobas = random.Next(1, 7);

                if (dobas == 6)
                {
                    Console.Write("\nA kocka pördült egy ideig és végül a ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("6");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-oson landolt, mire a kis üvegasztal fehéren kezdett el ragyogni és fényével elvakítva eltűnt, majd mire a fény alább hagyott egy ajtó lett a helyén, amely az otthonod ajtaja volt. Hevesen kinyitva az otthonod tárult a szemeid elé, majd amint bentebb tetted a lábad a küszöbön az ajtó bevágódott mögötted! Minden történet ellenére sokadik kinyitásra se lett már ott a sivatag többé.");
                }
                else
                {
                    if (player.Targyak.Contains("kiskés"))
                    {
                        Console.Write("\nA kocka pördült egy ideig és végül a ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{dobas}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("számon landolt.");

                        Console.Write("\nAmint elfordultál az asztaltól hirtelen összeesett alattad a talaj és egy kötélcsapda tárta fel magát a homok alól!\nA kötelek teljesen beborítottak, viszont sélsebes reakcióval előkaptad a hátizsákodból a ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("kiskés");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("-t, és kivágtad magad a kötelek szorításából!\nKisebb szívbajjal megúsztad a csapdát. \nA kis üvegasztal fehéren kezdett el ragyogni és fényével elvakítva eltűnt, majd mire a fény alább hagyott egy ajtó lett a helyén, amely az otthonod ajtaja volt. Hevesen kinyitva az otthonod tárult a szemeid elé, majd amint bentebb tetted a lábad a küszöbön az ajtó bevágódott mögötted! Minden történet ellenére sokadik kinyitásra se lett már ott a sivatag többé.");
                    }
                    else
                    {
                        Console.Write("\nA kocka pördült egy ideig és végül a ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{dobas}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" számon landolt.");

                        Console.WriteLine("\nAmint elfordultál az asztaltól hirtelen összeesett alattad a talaj és egy kötélcsapda tárta fel magát a homok alól!\nA táskádban nem volt semmi, ami segíthetett volna rajtad, úgyhogy egy pár másodperc alatt a kötelek teljesen rászorultak a végtagjaidra, ezzel harcképtelenné téve és egy emlékeztetőt adva a jövőbéli vándoroknak, mikor meglátják majd kötéllel borított csontjaid a tündérmesébe illő üvegasztal mellett.");
                    }
                }
            }
            else if (input[0] == 'N' || input[0] == 'n')
            {
                Console.WriteLine("\nÉrdeklődés hiányában elvándoroltál az üvegasztalos dobókockától és csak egyetlen kérdéssel a fejedben vonultál tovább a szigeten.\nMiért volt egy üvegasztalon egy dobókocka a sivatag kellős közepén?");
                player.Skippek.Add(input);
                
            }
            Console.ReadLine();
            Console.Clear();
        }

    }
}
