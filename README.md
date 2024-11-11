E-Ticaret Mikroservis Projesi


Bu proje, ASP.NET Core 8.0 ve güncel mikroservis teknolojilerini kullanarak geliştirilmiş bir e-ticaret uygulamasıdır. Proje, Docker ile taşınabilirliği sağlanmış, güvenli, ölçeklenebilir ve bulut tabanlı bir altyapı sunmaktadır.

Proje Hakkında
Bu proje, Murat Yücedağ hocamın Udemy'deki ASP.NET Core MultiShop Mikroservis E-Ticaret kursuna dayanarak geliştirilmiştir. Proje, N-Katmanlı Mimarî ve Onion mimarisi ile yapılandırılmış, SOLID prensiplerine uygun olarak tasarlanmıştır.

Özellikler
Mikroservis Mimarisi: Projede bağımsız olarak yönetilebilen mikroservisler bulunmaktadır.


Kimlik Doğrulama ve Yetkilendirme: Identity Server ve JWT tabanlı güvenlik sağlanmaktadır.


Veri Yönetimi: MSSQL, MongoDB, Redis ve PostgreSQL gibi SQL ve NoSQL veritabanları kullanılmıştır.


API Yönetimi: API dökümantasyonu hazırlanmış, Postman ile test süreçleri yürütülmüştür.


İletişim ve Mesajlaşma: Servisler arası iletişim için RabbitMQ kullanılmıştır.


Gerçek Zamanlı Güncellemeler: SignalR entegrasyonu ile gerçek zamanlı bildirim desteği sağlanmıştır.


Proje Görselleri
Proje içindeki bazı sayfaların ekran görüntülerine aşağıdan ulaşabilirsiniz:


<!-- Buraya ekran görüntülerigelecek  -->


Kullanılan Teknolojiler


ASP.NET Core 8.0


Docker - Konteyner yönetimi


DBeaver - Veritabanı yönetimi


Swagger - API dökümantasyonu


RabbitMQ - Mesajlaşma altyapısı


Google Cloud Storage - Depolama


IdentityServer4 ve JWT - Kimlik doğrulama


CQRS ve Mediator Design Pattern - Veri yönetimi ve iş mantığı


Kurulum


Docker'ı yükleyin ve docker-compose.yml dosyasını çalıştırarak gerekli konteynerleri başlatın.


DBeaver veya tercih ettiğiniz başka bir araç ile veritabanı bağlantısını yapın.


Swagger veya Postman kullanarak API endpointlerini test edebilirsiniz.



Gereksinimler


Docker ve Docker Compose


.NET 8 SDK


Postman veya Swagger kurulu olmalıdır.
