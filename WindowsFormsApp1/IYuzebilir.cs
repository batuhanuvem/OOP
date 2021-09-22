using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface IYuzebilir  // İnterface'in onüne erişim belirleyici yazılabilir.
    {
        double MaxInebilecegiDerinlik { get; set; }
        void Yuz(); // Interfac içindeki elemanlara erişim belirleyici yazılamaz.

    }
}
