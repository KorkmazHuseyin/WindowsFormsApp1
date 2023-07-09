using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Kisiler
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string DogumiYeri { get; set; }
        public override string ToString()
        {
            return Adi + " "+Soyadi +" "+ DogumiYeri;
        }


    }
}
