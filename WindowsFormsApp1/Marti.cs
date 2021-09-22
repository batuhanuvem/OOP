using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Marti : Kus , IYuzebilir , IUcabilir
    {
        public double YuzmeDerinligi { get; set; }
        public double MaxInebilecegiDerinlik { get ; set ; }
        public double UcabileceğiMaxYukseklik { get ; set ; }
        public string UcabilecegiMaxYukseklikBirimi { get; set ; }

        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
}
