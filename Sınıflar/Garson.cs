using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    public class Garson:Personel,IKasiyer
    {
        public int MasaAdet{ get; set; }
        public string ServisDurumu { get; set; } //servislerde hangi iş alanını yapacak
        int IKasiyer.fisadet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IKasiyer.Kasa { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
