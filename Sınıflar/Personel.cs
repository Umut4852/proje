using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    public abstract class Personel
    {
        public int ID { get; set; }
        public int sifre { get; set; }
        public string isim { get; set; }
        public int yas { get; set; }
        public string cinsiyet { get; set; }
        public int maas { get; set; }
        public int calismasuresi { get; set; }

    }
}
