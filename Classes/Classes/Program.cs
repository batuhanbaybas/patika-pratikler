Calisan calisan1 = new Calisan();
calisan1.Ad = "Berkcan";
calisan1.Soyad = "Gümüşışık";
calisan1.No = 123456;
calisan1.Departman = "Yazılım Geliştirme";

calisan1.CalisanBilgiler();

Calisan calisan2 = new Calisan();
calisan2.Ad = "Şevval";
calisan2.Soyad = "Baydemir";
calisan2.No = 123457;
calisan2.Departman = "Sosyal Medya";

calisan2.CalisanBilgiler();
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgiler()
    {
        Console.WriteLine("Çalışan Adı {0}", Ad);
        Console.WriteLine("Çalışan Soyadı {0}", Soyad);
        Console.WriteLine("Çalışan Numarası {0}", No);
        Console.WriteLine("Çalışan Departmanı {0}", Departman);
    }
}