using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LİG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******SÜPER FİNAL HAFTASINA HOŞGELDİNİZ******");
            int fb = 0;
            int gs = 0;
            int bjk = 0;
            int başak = 0;

            int a1, a2, a3;
            int b1, b2, b3;
            int c1, c2, c3;
            int d1, d2, d3;

            Random rastgele = new Random(); // birinci maçlar
            a1 = rastgele.Next(0, 5);
            b1 = rastgele.Next(0, 5);
            c1 = rastgele.Next(0, 5);
            d1 = rastgele.Next(0, 5);
            Console.WriteLine("****** Birinci Hafta *******");
            Console.WriteLine();
            Console.WriteLine("Fenerbahçe "+a1+"-"+b1+" Galatasaray");
            Console.WriteLine("Beşiktaş "+c1+"-"+d1+" Başakşehir");
            if (a1 > b1)
            {
                fb = fb + 3;
                gs = gs + 0;
            }
            else if (b1 > a1)
            {
                fb = fb + 0;
                gs = gs + 3;
            }
            else if (b1 == a1)
            {
                fb = fb + 1;
                gs = gs + 1;
            }
            if (c1 > d1)
            {
                bjk = bjk + 3;
                başak = başak + 0;
            }
            else if (d1 > c1)
            {
                bjk = bjk + 0;
                başak = başak + 3;
            }
            else if (d1 == c1)
            {
                bjk = bjk + 1;
                başak = başak + 1;
            }



            Console.WriteLine("Lig Tablosu");
            Console.WriteLine();
            Console.WriteLine("Fenerbahçe "+fb);
            Console.WriteLine("Galatasaray "+gs);
            Console.WriteLine("Beşiktaş "+bjk);
            Console.WriteLine("Başakşehir "+başak);

            Console.Read();

        }
    }
}
