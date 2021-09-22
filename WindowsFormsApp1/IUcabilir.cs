using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IUcabilir
    {
        void Uc();

        double UcabileceğiMaxYukseklik { get; set; }

        string UcabilecegiMaxYukseklikBirimi { get; set; }
    }
}
