//Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
//(ArrayList sınıfını kullanara yazınız.)

using System.Collections;

ArrayList asalSayilar = new ArrayList();
ArrayList digerSayilar = new ArrayList();

Console.WriteLine("20 adet pozitif sayı giriniz:");

for (int i = 0; i < 20; i++)
{
    Console.WriteLine("{0}. sayıyı giriniz:", i + 1);
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi > 0)
    {
        if (sayi == 1)
        {
            Console.WriteLine("1 sayısı asal sayı değildir.");
        }
        else
        {
            bool asalMi = true;
            for (int j = 2; j < sayi; j++)
            {
                if (sayi % j == 0)
                {
                    asalMi = false;
                    break;
                }
            }
            if (asalMi)
            {
                asalSayilar.Add(sayi);
            }
            else
            {
                digerSayilar.Add(sayi);
            }
        }
    }
    else
    {
        Console.WriteLine("Girilen sayı pozitif olmalıdır.");
    }
}

asalSayilar.Sort();
digerSayilar.Sort();

Console.WriteLine("Asal sayılar:");
foreach (int sayi in asalSayilar)
{
    Console.WriteLine(sayi);
}
Console.WriteLine("Asal olmayan sayılar:");
foreach (int sayi in digerSayilar)
{
    Console.WriteLine(sayi);
}