using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    public class Asci : Personel
    {
        public string YemekAd { get; set; }
        public int Porsiyon { get; set; }

        public string[] Yemek(string yemekler)
        {
            string [] Yemekler = new string[3] { "kuru", "fasulye","musakka"} ;
            return Yemekler;
                     

        }




    }
}
