Console.WriteLine("**** Patika.dev - C# 101 -Algoritma Soruları ******");
Console.WriteLine("*****************");
Console.WriteLine("Birinci Soru: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.");

Console.Write("Bir sayı gir: ");
int sayi = int.Parse(Console.ReadLine());

int[] sayilar = new int[sayi];

for (int i = 0; i < sayi; i++)
{
    Console.Write(+ (i+1) + ". sayiyi gir:");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < sayilar.Length; i++)
{
    int kalan = sayilar[i]%2;
    if(kalan==0){
        Console.WriteLine(sayilar[i]);
    }else{
    
    }
}

Console.WriteLine("*****************");
Console.WriteLine("İkinci Soru: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.");

Console.Write("Bir sayı gir: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Bir sayı daha gir kanka: ");
int m = int.Parse(Console.ReadLine());

int[] sayilar1 = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write(+ (i+1) + ". sayiyi gir kankam:");
    sayilar1[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < sayilar1.Length; i++)
{
    int kalan = sayilar1[i]%2;

    if(sayilar[i]%m == 0 || sayilar[i] == m ){
        Console.WriteLine(sayilar[i]);
    }else{
    }
}

Console.WriteLine("*****************");
Console.WriteLine("Üçüncü Ödev: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.");

Console.Write("Bir sayı gir kankam: ");
int sayim = int.Parse(Console.ReadLine());


string[] kelimeDizisi = new string[sayim];

for (int i = 0; i < sayim; i++)
{
    Console.Write("Bir kelime gir kanka:");
    kelimeDizisi[i] = Convert.ToString(Console.ReadLine());
}
foreach (string kelime in kelimeDizisi)
{
    Console.WriteLine(kelime);
}

Array.Reverse(kelimeDizisi); // reverse ile dizideki elemanları tersten yazdırdım.

foreach(string kelime in kelimeDizisi)
{
 Console.Write("" + kelime);
}

Console.WriteLine("*****************");
Console.WriteLine("Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.");



Console.Write("Bir cümle gir kanka:");
string cumle = Convert.ToString(Console.ReadLine()); // cümle aldım
string[] kelimeler = cumle.Split(" "); // cümleyi kelimelere ayırdım.
char[] harf = cumle.ToCharArray(); // cümleyi harflerine ayırdım

Console.WriteLine("Verilen Cümlede {0} Kelime Vardır.", kelimeler.Length);
Console.WriteLine("Verilen Cümlede {0} harf Vardır.", harf.Length);



