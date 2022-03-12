// See https://aka.ms/new-console-template for more information
int sayi1 = 5;
int sayi2 = 7;
bool sonuc = sayi2 > sayi1;
sayi1 += 2;
sayi1 = sayi1 + 2;
sayi1 /= 3;
Console.WriteLine(sayi1);


bool isSuccess = true;
bool isComplite = true;


if (isComplite && isComplite)
{
    Console.WriteLine("iki koşulda doğru ");
}
if (isSuccess || !isSuccess)
{
    Console.WriteLine("bir koşul sağlanıyor ");
}



Console.WriteLine(sonuc);
sonuc = sayi1 > sayi2;
Console.WriteLine(sonuc);
sonuc = sayi2 >= sayi1;
Console.WriteLine(sonuc);


int sonuc2 = sayi1 % 3;
Console.WriteLine(sonuc2)

