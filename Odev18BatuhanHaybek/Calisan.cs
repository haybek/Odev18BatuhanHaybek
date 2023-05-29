using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev18BatuhanHaybek
{
    public class Calisan
    {
        public Calisan(Malzeme malzeme, Calisanlar calisan)
        {
            CalisanAdi = calisan;
            Malzeme = malzeme;
        }

        public Malzeme Malzeme { get; set; }
        public Calisanlar CalisanAdi { get; set; }


        public static Malzeme MalzemeCek()
        {
            Random rastgele = new Random();

            int sayi = rastgele.Next(0, 2);

            switch (sayi)
            {
                case 0:
                    return Malzeme.Cam;
                case 1:
                    return Malzeme.Seramik;
                default:
                    return Malzeme.Cam;
            }





        }

    }
}
