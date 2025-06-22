![patikaflix1](https://github.com/user-attachments/assets/b32826dd-74ff-4775-b904-de3fbe0327f4)
![patikaflix2](https://github.com/user-attachments/assets/fc0373e3-2ac1-4909-aed4-f5ad54aeb63b)


# PatikafliX Diziler Platformu

Bu proje, kullanıcıdan konsol ekranı aracılığıyla dizi bilgileri alarak bunları yöneten ve belirli kriterlere göre sorgulayan basit bir C# konsol uygulamasıdır. Uygulama, nesne tabanlı programlama prensiplerini ve özellikle .NET'in güçlü LINQ (Language Integrated Query) özelliklerini kullanarak veri işleme yeteneklerini sergiler.

## Özellikler

Bu uygulama aşağıdaki temel özellikleri ve işlevleri sunar:

-   **Dizi Verisi Girişi**: Kullanıcıdan konsol üzerinden interaktif olarak dizi bilgileri (Dizi Adı, Yapım Yılı, Türü, Yayınlanmaya Başlama Yılı, Yönetmenler, Yayınlandığı İlk Platform) alınır ve `List<Dizi>` koleksiyonunda saklanır. Geçersiz sayısal girişler için kullanıcıdan tekrar giriş yapması istenir.
-   **Özelleştirilmiş Veri Modelleri**:
    -   `Dizi` sınıfı: Her bir dizinin tüm detaylı bilgilerini (tablodaki tüm sütunları) tutar.
    -   `YeniDizi` sınıfı: Sadece belirli sorgu ihtiyaçları için (Dizi Adı, Türü, Yönetmenler) minimalist bir veri modeli sunar.
-   **Veri Formatlama**: Albüm satışları gibi sayısal verileri daha okunaklı "Yaklaşık X milyon" formatına dönüştürebilen yardımcı bir metot (`GetFormattedAlbumSales`) içerir (Şarkıcı projesinden aktarılan bir özellik, bu projede doğrudan kullanılmasa da sınıf yapısında mevcuttur).
-   **LINQ Destekli Sorgulamalar**: Uygulama, `System.Linq` namespace'i altındaki metotları kullanarak aşağıdaki karmaşık veri filtreleme, dönüştürme ve sıralama işlemlerini gerçekleştirir:
    -   **Komedi Dizilerinin Dönüştürülmesi ve Sıralanması**: Komedi türündeki dizileri filtreler, yalnızca Dizi Adı, Türü ve Yönetmen bilgilerini içeren `YeniDizi` nesnelerine dönüştürür. Ardından bu yeni listeyi **öncelikle Dizi Adına, sonra Yönetmen adına göre alfabetik** olarak sıralar (`OrderBy` ve `ThenBy` kullanımı).
    -   **Giriş Kontrolü**: Listelerin boş olması durumunda (kullanıcı hiç dizi girmemişse veya filtreleme sonucu boş dönmüşse) uygun mesajlar görüntüler.
