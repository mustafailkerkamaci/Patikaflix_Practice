using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix_Practice
{
    public class Dizi // dizi listemin almasi gereken ozeliklerin oldugu duzu classi
    {
        public string DiziAdi { get; set; }
        public int YapimYili { get; set; }
        public string Turu { get; set; }
        public int YayinTarihi { get; set; }
        public string Yonetmen { get; set; }
        public string Platform { get; set; }

        public Dizi(string diziAdi, int yapimYili, string turu, int yayinTarihi, string yonetmen, string platform)
        {
            DiziAdi = diziAdi;
            YapimYili = yapimYili;
            Turu = turu;
            YayinTarihi = yayinTarihi;
            Yonetmen = yonetmen;
            Platform = platform;
        }


    }
}
