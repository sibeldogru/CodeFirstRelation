# CodeFirstRelation_Pratik

Bu proje, **Entity Framework Core** kullanarak **Code First** yaklaşımını temel alan basit bir kullanıcı ve gönderi (post) ilişkisini modellemektedir.

## 📌 Proje Özeti

Bu uygulama, aşağıdaki gibi iki tabloyu temsil eden `UserEntity` ve `PostEntity` sınıflarını içerir:

- **Users**: Sisteme kayıtlı kullanıcıları temsil eder.
- **Posts**: Kullanıcılar tarafından oluşturulan gönderileri içerir.

Bir kullanıcı birden fazla gönderiye sahip olabilir; ancak her gönderi yalnızca bir kullanıcıya aittir (one-to-many ilişki).

## 🧱 Kullanılan Teknolojiler

- .NET 7 / .NET 8 (uygulamanın versiyonuna göre)
- Entity Framework Core
- SQL Server (LocalDB veya MSSQL Server)
- ASP.NET Core Minimal API yapısı

## 🗃️ Veritabanı Yapısı

### Tablolar

#### `Users`

| Alan        | Tip     | Açıklama               |
|-------------|---------|------------------------|
| Id          | int     | Otomatik artan PK      |
| Username    | string  | Kullanıcı adı          |
| Email       | string  | E-posta adresi         |
| CreatedDate | DateTime | Oluşturulma zamanı    |
| ModifiedDate| DateTime | Güncellenme zamanı    |
| IsDeleted   | bool    | Silinme durumu         |

#### `Posts`

| Alan        | Tip     | Açıklama                |
|-------------|---------|-------------------------|
| Id          | int     | Otomatik artan PK       |
| Title       | string  | Gönderi başlığı         |
| Content     | string  | Gönderi içeriği         |
| UserId      | int     | İlişkili kullanıcı FK    |
| CreatedDate | DateTime | Oluşturulma zamanı     |
| ModifiedDate| DateTime | Güncellenme zamanı     |
| IsDeleted   | bool    | Silinme durumu          |

## 🔗 Bağlantı Dizesi

Aşağıdaki bağlantı dizesi `appsettings.json` dosyasında tanımlanmıştır:

```json
"ConnectionStrings": {
  "DefaultConnection": "server=localhost; database=PatikaCodeFirstDb2; Trusted_Connection=true; TrustServerCertificate=true"
}



