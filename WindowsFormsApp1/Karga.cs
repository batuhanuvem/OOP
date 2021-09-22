using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Karga : Kus, IUcabilir
    {
        public double UcabileceğiMaxYukseklik { get ; set ; }
        public string UcabilecegiMaxYukseklikBirimi { get ; set ; }

        public void Uc()
        {
        }
    }
}
