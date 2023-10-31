using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dikdortgennesneolusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(12, 2);
            Console.WriteLine("Dikdörtgenin alanı=" + dikdortgen.alanHesapla());
            Console.WriteLine("Dikdörtgenin alanı=" + dikdortgen.cevreHesapla());
        }
        class Dikdortgen
        {
            private uint kisaKenar, uzunKenar;
            public Dikdortgen(uint kisaKenar, uint uzunKenar)
            {
                this.kisaKenar = kisaKenar;
                this.uzunKenar = uzunKenar;
            }
            public uint alanHesapla()
            {
                return kisaKenar * uzunKenar;
            }
            public uint cevreHesapla()
            {
                return 2 * (kisaKenar + uzunKenar);
            }
        }
    }
}

