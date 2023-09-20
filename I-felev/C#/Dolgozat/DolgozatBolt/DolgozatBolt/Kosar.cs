using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatBolt
{
    internal class Kosar
    {
        private List<Termek> termekek;

        public Kosar()
        {
            this.termekek = new List<Termek>();
        }

        public void kosarMegtolt(Termek termek)
        {
            termekek.Add(termek);
        }

        public int kosarbanAr()
        {
            int darab = 0;
            int darabAr = 0;
            int eredmeny = 0;

            foreach (var item in termekek)
            {
                darab += item.VasaroltMennyiseg;
                darabAr += item.KivalasztottAruDarabAr;
                eredmeny += darab * darabAr;
            }
            return eredmeny;
        }

        public override string ToString()
        {
            string szoveg = "";
            foreach (var item in termekek)
            {
                szoveg += $"{item.KivalasztottAruNev} : {item.VasaroltMennyiseg} : {item.fizetendoAr()}\n";
            }
            return szoveg + $"\nA kosár össz ára: {this.kosarbanAr()}";
        }
    }
}
