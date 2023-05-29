namespace Odev18BatuhanHaybek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Malzeme> malzemeListesi = new List<Malzeme>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    malzemeListesi.Add(Calisan.MalzemeCek());
                    Calisan calisan = new Calisan(malzemeListesi[j], Calisanlar.Calisan1);
                    Console.WriteLine($"{i+1}. Calisanin cektigi anahtar {j}. anahtari {malzemeListesi[j]}");



                }
                if (malzemeListesi[0] != malzemeListesi[1])
                {
                    Console.WriteLine("Hediyeyi Kazandiniz Tebrikler");
                }
                Console.WriteLine("-----------------------------------");
                malzemeListesi.Clear();
            }




        }
    }
}