using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    public class Kurye:Personel
    {
        public string bolge { get; set; }
        public int paketadet { get; set; }
        public string motor { get; set; }
        public string kuryeadi(string kurye)
        {
            kurye = "ahmet";
            return kurye;
        }
    }
}
