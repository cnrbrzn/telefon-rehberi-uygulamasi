namespace telefon_rehberi_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Rehber rehber = new Rehber();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            string islem = Console.ReadLine();
            switch (islem)
            {
                case "1":
                    rehber.RehbereKaydet();
                    break;
                case "2":
                    rehber.RehberdenNumaraSil();
                    break;
                case "3":
                    rehber.RehberdeNumaraGuncelle();
                    break;
                case "4":
                    rehber.RehberiListele();
                    break;
                case "5":
                    rehber.RehberdeAramaYap();
                    break;
                default:
                    Console.WriteLine("Lütfen 1-5 arası bir değer giriniz.");
                    break;
            }
        }
    }
}

