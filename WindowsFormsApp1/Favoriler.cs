using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Favoriler
    {
        public string Meyve { get; set; }
        public string Sebze { get; set; }
        public int Sayi { get; set; }

        public override string ToString()
        {
            return Meyve + " " + Sebze + " " + Sayi; 
        }

    }
}
