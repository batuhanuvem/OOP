using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Tavuk : Kus , IUcabilir
    {
        public int YumurtaSayisi { get; set; }

        public int YumurtlamaSuresi { get; set; }
        public double UcabileceğiMaxYukseklik { get ; set; }
        public string UcabilecegiMaxYukseklikBirimi { get ; set ; }

        public void Uc()
        {
            
        }
    }
}
