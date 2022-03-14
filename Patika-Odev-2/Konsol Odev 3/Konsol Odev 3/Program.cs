﻿//Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve
//dizinin elemanlarını sıralayan programı yazınız

using System.Collections;


Console.WriteLine("Bir cümle giriniz : ");
string cumle = Console.ReadLine();
ArrayList sesliHarfler = new ArrayList();
char[] sabitSesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
char[] harfler = new char[cumle.Length];
harfler = cumle.ToCharArray();
foreach (var harf in harfler)
{
    foreach (var sabitSesli in sabitSesliHarfler)
    {
        if (harf == sabitSesli)
        {
            sesliHarfler.Add(harf);
        }
    }

}

foreach (var item in sesliHarfler)
{
    Console.Write(item + " ");
}

