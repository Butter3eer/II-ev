using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalandjatek_2023_09_07
{
    internal interface Mechanics
    {
        string Lehetosegek(Kalandor jatekos);
        string DobasEredmeny(Kalandor jatekos, int dobasSzam);
    }
}
