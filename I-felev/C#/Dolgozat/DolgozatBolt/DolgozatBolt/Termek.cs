using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatBolt
{
    internal class Termek
    {
        private string kivalasztottAruNev;
        private int kivalasztottAruDarabAr;
        private int vasaroltMennyiseg;

        public Termek(string kivalasztottAruNev, int kivalasztottAruDarabAr, int vasaroltMennyiseg)
        {
            this.kivalasztottAruNev = kivalasztottAruNev;
            this.kivalasztottAruDarabAr = kivalasztottAruDarabAr;
            this.vasaroltMennyiseg = vasaroltMennyiseg;
        }

        public int fizetendoAr()
        {
            return kivalasztottAruDarabAr * VasaroltMennyiseg;
        }

        public string KivalasztottAruNev { get => kivalasztottAruNev; set => kivalasztottAruNev = value; }
        public int KivalasztottAruDarabAr { get => kivalasztottAruDarabAr; set => kivalasztottAruDarabAr = value; }
        public int VasaroltMennyiseg { get => vasaroltMennyiseg; set => vasaroltMennyiseg = value; }

        public override string ToString()
        {
            return $"Kiválasztott termék neve és darab ára: {kivalasztottAruNev} / {KivalasztottAruDarabAr} és a vásárolt mennyiség: {VasaroltMennyiseg}";
        }
    }
}
