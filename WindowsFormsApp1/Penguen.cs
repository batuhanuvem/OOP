using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Penguen : Kus , IYuzebilir
    {
        public double YuruyusHizi { get; set; }
        public double MaxInebilecegiDerinlik { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
}
