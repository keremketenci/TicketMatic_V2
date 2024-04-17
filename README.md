# TicketMatic_V2

# Biletmatik Uygulaması_V2

Bu, C# ve Visual Studio kullanılarak geliştirilmiş bir windows form uygulamasıdır. Bu uygulama, kullanıcının bir film seansı için bilet satın almasını sağlar.

## Kullanım

Uygulamayı çalıştırmak için aşağıdaki adımları takip edin:

1. Projeyi Visual Studio'da açın.
2. Program.cs dosyasını bulun ve çalıştırın.

Uygulama başladığında, aşağıdaki adımları takip ederek bilet satın alabilirsiniz:

1. İlk olarak, Kayıt olun veya giriş yapın.
2. Başarılı bir şekilde giriş yaptıktan sonra bilet almak istediğiniz filmi seçiniz.
3. Film Seçildikten sonra seçilen filme ait seanslar listelenecektir, bir seans seçin.
4. Seans seçildikten sonra seçilen seansa ait salonun koltukları listelenecektir, satın almak istediğiniz koltuk(ları) seçiniz.
5. Koltuk(lar) seçildikten sonra rezervasyon ekranında seçtiğiniz seansa ait bilgiler ve toplam bilet tutarınız listelenecektir, onayla tuşuna basıp bilet alma işlemini gerçekleştirebilirsiniz. (Kredi kartı giriş ekranı tamamen göstermeliktir girdiğiniz veriler hiçbir şekilde işlenmez veya kaydedilmez).

## Sınıflar

Bu proje aşağıdaki sınıflardan oluşmaktadır:

- Program.cs: Ana uygulama dosyasıdır ve kullanıcıyla etkileşim sağlar.
- Movie.cs: Filmleri temsil eden sınıfı içerir.
- Session.cs: Film seanslarını temsil eden sınıfı içerir.
- Theater.cs: Sinema salonlarını temsil eden sınıfı içerir.
- Reservation.cs: Bilet rezervasyonlarını temsil eden sınıfı içerir.

## Önemli Notlar

- Bu uygulama sadece temsili bir amaç taşımaktadır ve gerçek bir bilet rezervasyon sistemi olarak kullanılamaz.
- Uygulama SQLite veritabanını kullanarak rezervasyonları "Data" klasörünün içindeki "TicketMaticDb.db" dosyasına kaydeder.
- Hatalı girişlerde uygulama çökmez, bunun yerine hata mesajı gösterir ve kullanıcıyı tekrar giriş yapmaya yönlendirir.
- Kullanıcı istediği zaman geri dönüp farklı bir seçim yapabilir ve bilet işlemlerini yeniden başlatabilir.
- Bu değişiklikler, kullanıcı deneyimini iyileştirmek ve hata yönetimini güçlendirmek için yapılmıştır.

## Uygulama içi ekran görüntüleri
Giriş Paneli: 
![Login](https://github.com/keremketenci0/TicketMatic_V2/assets/128905838/d5a91ad9-8082-4b0b-9c64-746c9dc4bb5f)
KayıtOl Paneli: 
![Register](https://github.com/keremketenci0/TicketMatic_V2/assets/128905838/d16e49f6-5dee-4de3-8ba1-34d28bd48d92)
AnaEkran Paneli: 
![Home](https://github.com/keremketenci0/TicketMatic_V2/assets/128905838/f72a802f-5558-4ee4-9d5c-ecb610c3641f)
Film Paneli: 
![Movie](https://github.com/keremketenci0/TicketMatic_V2/assets/128905838/6e63fb54-205c-466b-a835-4fadcad42c83)
Seans Paneli: 
![Session](https://github.com/keremketenci0/TicketMatic_V2/assets/128905838/4edb3c89-a7c0-426e-bdc1-809de19dc263)
Salon Paneli: 
![Theater](https://github.com/keremketenci0/TicketMatic_V2/assets/128905838/5da38443-6ac2-44e7-8c02-ca8e7b60d08b)
Reservasyon Paneli: 
![Reservation](https://github.com/keremketenci0/TicketMatic_V2/assets/128905838/787dff23-cb6b-4af1-b589-70de3b7a683a)

## Modelleme
