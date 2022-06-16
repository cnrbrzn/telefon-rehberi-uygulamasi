namespace telefon_rehberi_uygulamasi
{
    public class Kisi
    {
        string isim;
        string soyisim;
        string telefonNumarasi;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string TelefonNumarasi { get => telefonNumarasi; set => telefonNumarasi = value; }

        public Kisi(string isim, string soyisim, string telefonNumarasi)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.telefonNumarasi = telefonNumarasi;
        }
        public Kisi()
        {
        }
    }
}