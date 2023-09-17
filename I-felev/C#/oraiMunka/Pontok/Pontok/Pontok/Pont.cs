using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pontok
{
    internal class Pont
    {
        private int x;
        private int y;

        public Pont()
        {
            this.x = 0;
            this.y = 0;
        }

        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Pont(int szam)
        {
            Random random = new Random();

            this.x = random.Next(-szam, szam);
            this.y = random.Next(-szam, szam);
        }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public double Tavolsag()
        {
            double c = Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)), 2);

            return c;
        }

        public double TavolsagKettoKozt(int x1, int y1, int x2, int y2)
        {
            int x3 = 0;
            int y3 = 0;

            if (x1 < 0)
            {

            }
        }

        public override string ToString()
        {
            return $"[{this.x};{this.y}]";
        }
    }
}
