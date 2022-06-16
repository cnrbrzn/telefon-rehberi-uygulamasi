namespace telefon_rehberi_uygulamasi
{
    class Rehber
    {
        private List<Kisi> kisiList = new List<Kisi>();

        public List<Kisi> KisiList { get => kisiList; set => kisiList = value; }

        public Rehber()
        {
            KisiList = new List<Kisi>();
            KisiList.Add(new Kisi("AHMET", "YILMAZ", "5079871211"));
            KisiList.Add(new Kisi("BUSE", "ZENGIN", "5356543412"));
            KisiList.Add(new Kisi("CAN", "DEMIR", "5373215613"));
            KisiList.Add(new Kisi("DENIZ", "ARDA", "5387417814"));
            KisiList.Add(new Kisi("EZGI", "YAGMUR", "5458529015"));
        }

        public void RehbereKaydet()
        {
            Console.Clear();
            Kisi k = new Kisi();
            Console.Write("Lütfen isim giriniz             : ");
            k.Isim = Console.ReadLine().ToUpper();
            Console.Write("Lütfen soyisim giriniz          : ");
            k.Soyisim = Console.ReadLine().ToUpper();
            Console.Write("Lütfen telefon numarası giriniz : ");
            k.TelefonNumarasi = Console.ReadLine().ToUpper();
            KisiList.Add(k);
            RehberiListele();
        }
        public void RehberdenNumaraSil()
        {
            Console.Clear();
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string silinecek = Console.ReadLine().ToUpper();
            int sonuc = 0;
            foreach (Kisi kisi in KisiList)
            {
                if (kisi.Isim == silinecek || kisi.Soyisim == silinecek)
                {
                    sonuc++;
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", kisi.Isim);
                    string onay = Console.ReadLine();
                    if (onay == "y")
                    {
                        KisiList.Remove(kisi);
                        Console.Clear();
                        RehberiListele();
                        break;
                    }
                    else if (onay == "n")
                        Environment.Exit(0);
                }
            }
            if (sonuc == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                string secim = Console.ReadLine();
                if (secim == "2")
                    RehberdenNumaraSil();
                else
                    Environment.Exit(0);
            }
        }
        public void RehberdeNumaraGuncelle()
        {
            Console.Clear();
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string guncellenecek = Console.ReadLine().ToUpper();
            int sonuc = 0;
            foreach (Kisi kisi in KisiList)
            {
                if (kisi.Isim == guncellenecek || kisi.Soyisim == guncellenecek)
                {
                    sonuc++;
                    Console.Write("Lütfen güncel numarayı giriniz: ");
                    kisi.TelefonNumarasi = Console.ReadLine();
                    RehberiListele();
                    break;
                }
            }
            if(sonuc==0)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için  : (1)");
                    Console.WriteLine("* Yeniden denemek için            : (2)");
                    string secim = Console.ReadLine();
                    if (secim == "2")
                        RehberdeNumaraGuncelle();
                    else
                        Environment.Exit(0);
                }
        }
        public void RehberiListele()
        {
            Console.Clear();
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var kisi in KisiList)
            {
                Console.WriteLine("İsim             : " + kisi.Isim);
                Console.WriteLine("Soyisim          : " + kisi.Soyisim);
                Console.WriteLine("Telefon Numarası : " + kisi.TelefonNumarasi);
                Console.WriteLine("-");
            }
        }
        public void RehberdeAramaYap()
        {
            Console.Clear();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.Clear();
                Console.Write("Lütfen arama yapmak istediğiniz isim veya soyismi giriniz: ");
                string search = Console.ReadLine().ToUpper();
                int sonuc=0;
                foreach (Kisi kisi in KisiList)
                {
                    if (kisi.Isim == search || kisi.Soyisim == search)
                    {
                        sonuc++;
                        Console.WriteLine("Arama Sonuçlarınız:");
                        Console.WriteLine("**********************************************");
                        Console.WriteLine("İsim             : " + kisi.Isim);
                        Console.WriteLine("Soyisim          : " + kisi.Soyisim);
                        Console.WriteLine("Telefon Numarası : " + kisi.TelefonNumarasi);
                        Console.WriteLine("-");
                        break;
                    }
                }
                if(sonuc==0)
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                    }
            }
            else if (secim == "2")
            {
                Console.Clear();
                Console.Write("Lütfen arama yapmak istediğiniz telefon numarasını giriniz: ");
                string search = Console.ReadLine();
                int sonuc=0;
                foreach (Kisi kisi in KisiList)
                {
                    if (kisi.TelefonNumarasi == search || kisi.TelefonNumarasi == search)
                    {
                        sonuc++;
                        Console.WriteLine("Arama Sonuçlarınız:");
                        Console.WriteLine("**********************************************");
                        Console.WriteLine("İsim             : " + kisi.Isim);
                        Console.WriteLine("Soyisim          : " + kisi.Soyisim);
                        Console.WriteLine("Telefon Numarası : " + kisi.TelefonNumarasi);
                        break;
                    }
                }
                if(sonuc==0)
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                    }
            }
        }
    }
}