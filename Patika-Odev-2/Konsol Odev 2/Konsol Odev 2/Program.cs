//Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
//her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını
//console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

using System.Collections;

ArrayList sayilar = new ArrayList();

try
{
    for (int i = 0; i < 20; i++)
    {
        Console.WriteLine("{0}. sayıyı giriniz:", i + 1);
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 0)
        {
            throw new Exception("Negatif sayı girdiniz");
        }
        sayilar.Add(n);
    }
}
catch (Exception)
{

    throw new Exception("Lütfen sayı giriniz.");
}
sayilar.Sort();
sayilar.Reverse();

ArrayList enBuyuk = sayilar.GetRange(0, 3);
ArrayList enKucuk = sayilar.GetRange(17, 3);

foreach (int buyuk in enBuyuk)
{
    Console.WriteLine(buyuk);
}


foreach (int kucuk in enKucuk)
{
    Console.WriteLine(kucuk);
}

Ortalama.OrtalamaHesapla(enBuyuk);
Ortalama.OrtalamaHesapla(enKucuk);
class Ortalama
{
    public static void OrtalamaHesapla(ArrayList sayilar)
    {
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        double ortalama = (double)toplam / sayilar.Count;
        Console.WriteLine("Ortalama: {0}", ortalama);
    }
    
   
}