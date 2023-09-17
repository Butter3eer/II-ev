using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalandjatek_2023_09_07
{
    internal class Kalandor : Mechanics
    {
        int elet = 100;
        int dobasok = 5;

        public int Elet { get => elet; set => elet = value; }
        public int Dobasok { get => dobasok; set => dobasok = value; }

        public string Lehetosegek(Kalandor jatekos)
        {
            Random rnd = new Random();
            int szam = rnd.Next(1, 6);

            string veg = "";

            switch (szam)
            {
                case 1:
                    veg = "Találkozol egy nagy, éhes tigrissel.";
                    jatekos.Dobasok--;
                    break;
                case 2:
                    veg = "Átkelsz egy veszélyes folyón, és az áramlat elragad.";
                    jatekos.Dobasok--;
                    break;
                case 3:
                    veg = "Megbotolsz egy csapdában.";
                    jatekos.Dobasok--;
                    break;
                case 4:
                    veg = "Eltévedsz a dzsungelben.";
                    jatekos.Dobasok--;
                    break;
                case 5:
                    veg = "Egy mérgező kígyó támad rád.";
                    jatekos.Dobasok--;
                    break;
            }
            return veg;
        }

        public string DobasEredmeny(Kalandor jatekos, int dobasSzam)
        {
            string veg = "";

            switch (dobasSzam)
            {
                case 1:
                    jatekos.Elet -= 35;
                    veg = $"1-et dobtál!\nKritikális sebzés ért!\n A karaktered sikeresen eltörte a lábát. Senki se tudja hogyan. Vesztettél 35 életpontot! \nJelenlegi életpontjaid: {jatekos.Elet}";
                    break;
                case 2:
                    jatekos.Elet -= 20;
                    veg = $"2-őt dobtál!\nNem voltál szerencsés, a karaktered valahogy sikeresen félrenyelte a saját lélegzetvételét... Vesztettél 20 életpontot. \nJelenlegi életpontjaid: {jatekos.Elet}";
                    break;
                case 3:
                    jatekos.Elet -= 10;
                    veg = $"3-at dobtál!\nEsemények közepette méhek támadtak meg! Nem tudnak tenni sokat, mert aranyosak és méhecskék, de kellemetlenség miatt vesztettél 10 életpontot. \nJelenlegi életpontjaid: {jatekos.Elet}";
                    break;
                case 4:
                    jatekos.Elet -= 5;
                    veg = $"4-et dobtál!\nKalandozás közben honvágyad lett, ezért érzelmi válságba sodortad magad, ezzel veszítve 5 életpontot. \nJelenlegi életpontjaid: {jatekos.Elet}";
                    break;
                case 5:
                    veg = $"5-öt dobtál!\nVáratlan dolog történt! Ugyanis nem történt semmi! \nÖsszezavarodottan de magabiztosan mész tovább jelenlegi életpontjaid ({jatekos.Elet}) megörzésével.";
                    break;
                case 6:
                    jatekos.Elet += 5;
                    veg = $"6-ot dobtál!\nMeghallasz egy nagyon halk de határozott csilingelő hangot, melyre felfigyelve egy tündérrel találod szemben magad. Nem érted a nyelvet amit beszél, de felajánl neked egy innivalónak kinéző ajándékot, melyet elfogadsz, amely egy HEALING POTION volt. \nSzereztél 5 életpontot, mivel tündér méretű volt. \nJelenlegi életpontjaid: {jatekos.Elet}";
                    break;
            }

            Console.ReadLine();

            return veg;
        }
    }
}
