# SimpleFakeStoreApp
SimpleFakeStoreApp uygulaması, Fake Store API kullanarak ürünleri ve kategorileri görüntüleyen basit bir ASP.NET Core uygulamasıdır. Uygulama, ürünlerin ve kategorilerin listelenmesini sağlar ve kullanıcılara ürünleri belirli kategorilere göre filtreleme imkanı sunar.
```
SimpleFakeStoreApp/
├── Models/
│   └── Product.cs           # Ürün model sınıfı
├── Pages/
│   ├── Index.cshtml          # Ürünleri ve kategorileri listeleyen HTML
│   └── Index.cshtml.cs       # Sayfa model sınıfı
├── Services/
│   └── ProductService.cs     # Fake Store API ile etkileşimde bulunan servis
├── Program.cs                # Uygulamanın giriş noktası
├── SimpleFakeStoreApp.csproj # Proje dosyası
└── README.md                 # Bu dosya
```
### Teknolojiler ###

1. *ASP.NET Core: Web uygulama geliştirmek için kullanılan açık kaynaklı bir framework.*
2. *Bootstrap 5: CSS framework'ü, web sayfasının görünümünü iyileştirmek için kullanıldı.*
3. *Fake Store API: Ürün verilerini sağlamak için kullanılan üçüncü taraf API.*
