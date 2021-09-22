using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k9_StaticConst
{
    class Matematik
    {
        public const double EulerSabiti = 0.577721; // Bu değer programın her noktasında bu sayı ile çalışacak, sonradan değeri değiştirilemez.

        public const double PisagorSabiti = 1.4142195; //Karekök 2'nin değeri.

        public static double KarelerFakiniAl(double sayi1, double sayi2)
        {
            var sayi1Karesi = Math.Pow(sayi1, 2);
            var sayi2Karesi = Math.Pow(sayi2, 2);
            var karelerFarki = sayi1Karesi - sayi2Karesi;
            return karelerFarki;
        }
    }
}
