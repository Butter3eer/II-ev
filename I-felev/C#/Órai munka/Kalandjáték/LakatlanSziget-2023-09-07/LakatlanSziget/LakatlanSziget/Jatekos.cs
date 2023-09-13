using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakatlanSziget
{
    internal class Jatekos
    {
        List<string> targyak = new List<string>();
        List<string> skippek = new List<string>();
        int hp = 100;

        public List<string> Targyak { get => targyak; set => targyak = value; }
        public List<string> Skippek { get => skippek; set => skippek = value; }
        public int Hp { get => hp; set => hp = value; }
    }
}
