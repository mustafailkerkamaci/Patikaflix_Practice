using System;
using System.Collections.Generic;
using Patikaflix_Practice;


// Dizileri tutacak olan listemi olusturuyorum degisken olarak Dizi classini ekliyorum.
List <Dizi> diziler = new List<Dizi>();

Console.WriteLine("PATIKAFLIX");

bool yeniDiziEkle = true;
while (yeniDiziEkle) // ana program dongusu yeniDiziEkle true oldugu surece calisacak.
{
    Console.WriteLine("\nYeni Dizi Ekliyorsun: ");

    //dizinin adini aliyorum
    Console.Write("Dizi Adi: ");
    string diziAdi = Console.ReadLine();

    //dizinin yapim yilini aliyorum
    int yapimYili;
    while (true) // yapim yilini alirken kullanicinin gecerli bir sayi girmesini sagliyorum
    {
        Console.Write("Yapim Yili: ");
        if (int.TryParse(Console.ReadLine(), out yapimYili) && yapimYili > 0)
        {
            break; // gecerli bir sayi girildiyse donguden cik
        }
        Console.WriteLine("Lutfen gecerli bir yapim yili giriniz!");
    }

    Console.WriteLine("Turu :");
    string turu = Console.ReadLine();

    // dizinin yayin tarihini aliyorum
    int yayinTarihi;
    while (true) // yayin tarihini alirken kullanicinin gecerli bir sayi girmesini sagliyorum
    {
        Console.Write("Yayin Tarihi: ");
        if (int.TryParse(Console.ReadLine(), out yayinTarihi) && yayinTarihi > 0)
        {
            break; // gecerli bir sayi girildiyse donguden cik
        }
        Console.WriteLine("Lutfen gecerli bir yayin tarihi giriniz!");
    }

    // dizinin yonetmenini aliyorum
    Console.Write("Yonetmen: ");
    string yonetmen = Console.ReadLine();

    // dizinin platformunu aliyorum
    Console.Write("Yayinlandigi Platform: ");
    string platform = Console.ReadLine();


    // Gerekli olan bilgileri aldiktan sona dizi nesnesini olustup Dizi listeme eklioyrum.

    Dizi yeniDizi = new Dizi(diziAdi, yapimYili, turu, yayinTarihi, yonetmen, platform);
    diziler.Add(yeniDizi); // yeniDiziyi olustur ve diziler listesine ekle diyorum.

    //Kullaniciya baska dizi eklemek isteyip istemedigini soruyorum.
    Console.Write("Baska bir dizi eklemek istiyor musun? (E/H): ");
    string cevap = Console.ReadLine().ToUpper(); // kullanicinin cevabini aliyorum ve buyuk harfe ceviriyorum
    if (cevap == "H")
    {
        yeniDiziEkle = false; // eger kullanici H harfini girerse yeni dizi ekleme dongusunu sonlandiriyorum.
    }


}

//Dizi girisi bittikten sonra..

Console.WriteLine("\nDizi Girisi Sonlandi.");

//(Odevde istenen)Komedi dizilerinden yeni bir liste olusturacagim.

var komediDizileri = diziler // diziler verilerinden komedidizileri filtreliyorum
    .Where(d => d.Turu.Equals("Komedi")) // Turu Komedi olan dizileri aliyorum
    .Select(d => new KomediDizi // KomediDizi classindan yeni bir nesne olusturuyorum
    {
        DiziAdi = d.DiziAdi,
        Turu = d.Turu,
        Yonetmen = d.Yonetmen
    })
    .ToList(); // Listeye ceviriyorum
//Yeni liseteyi ekrana yazdiracagim.
//Butun Ozellikleri ile ekrana yazdiriyorum.
Console.WriteLine("Komedi Dizileri -->");
foreach(var item in komediDizileri) // komedi dizileri listesini tek tek yazdiriyorum
{
    Console.WriteLine($"Dizi Adi: {item.DiziAdi}, Turu: {item.Turu}, Yonetmen: {item.Yonetmen}");
}

//Once dizi isimleri sonrada yonetmen isimleri baz alinarak yazilisi
Console.WriteLine("\nOncelikle Dizi ismi Sonra Yonetmen Isimleri Baz Alinarak Siralanisi -->");
var isimYonetmenSiralanis = komediDizileri
    .OrderBy(d => d.DiziAdi) // Dizi ismine gore siraliyorum
    .ThenBy(d => d.Yonetmen) // Yonetmen ismine gore siraliyorum
    .ToList(); // Listeye ceviriyorum
foreach (var item in isimYonetmenSiralanis) // siralanmis listeyi ekrana yazdiriyorum
{
    Console.WriteLine($"Dizi Adi: {item.DiziAdi}, Yonetmen: {item.Yonetmen}");
}