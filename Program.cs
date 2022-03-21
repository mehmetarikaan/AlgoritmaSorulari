Console.WriteLine("**** Patika.dev - C# 101 -Algoritma Soruları ******");
Console.WriteLine("*****************");
Console.WriteLine("Birinci ödev: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.");

Console.Write("Bir sayı gir: ");
int sayi = int.Parse(Console.ReadLine());

int[] sayilar = new int[sayi];

for (int i = 0; i < sayi; i++)
{
    Console.Write(+ (i) + ". sayiyi gir:");
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
Console.WriteLine("İkinci ödev: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.");



