// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----Soru 1-----");
//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş
//olduğu sayılardan çift olanlar console'a yazdırın
Console.WriteLine("Bir sayı giriniz:");
int length = Convert.ToInt32(Console.ReadLine());
int[] numberArray = new int[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine("{0}. sayıyı giriniz:", i + 1);
    numberArray[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < numberArray.Length; i++)
{
    if (numberArray[i] % 2 == 0)
    {
        Console.WriteLine("{0} sayısı çift", numberArray[i]);
    }
    else
    {
        Console.WriteLine("{0} sayısı tek", numberArray[i]);
    }
}

Console.WriteLine("-----Soru 2-----");
//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
//Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın
Console.WriteLine("Bir sayı giriniz:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ikinci sayıyı giriniz:");
int m = Convert.ToInt32(Console.ReadLine());
int[] nmarr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("{0}. sayıyı giriniz:", i + 1);
    nmarr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < nmarr.Length; i++)
{
    if (nmarr[i] % m == 0)
    {
        Console.WriteLine("{0} sayısı {1}'e tam bölünüyor", nmarr[i], m);
    }
    else if (nmarr[i] == m)
    {
        Console.WriteLine("{0} sayısı {1}'e eşit", nmarr[i], m);
    }
    else
    {
        Console.WriteLine("{0} sayısı {1}'e tam bölünmez", nmarr[i], m);
    }

}

Console.WriteLine("-----Soru 3-----");
//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
//Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa
//doğru console'a yazdırın.

int positiveNumber = Convert.ToInt32(Console.ReadLine());
string[] wordArray = new string[positiveNumber];
for (int i = 0; i < positiveNumber; i++)
{
    Console.WriteLine("{0}. kelimeyi giriniz:", i + 1);
    wordArray[i] = Convert.ToString(Console.ReadLine());
}
foreach (string word in wordArray)
{
    Console.WriteLine(word);
}
Array.Reverse(wordArray);
foreach (string word in wordArray)
{
    Console.WriteLine(word);
}

Console.WriteLine("----Soru 4-----");
//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
//Cümledeki toplam kelime ve harf sayısını console'a yazdırın

string sentence = Console.ReadLine();
string[] wordArray2 = sentence.Split(' ');
int wordCount = wordArray2.Length;
int letterCount = 0;
foreach (string word in wordArray2)
{
    letterCount += word.Length;
}
Console.WriteLine("{0} kelime ve {1} harf var", wordCount, letterCount);
