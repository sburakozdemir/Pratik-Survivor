# Survivor Web API

Bu proje, **Survivor** yarışmasına katılan yarışmacılar ve kategoriler arasında CRUD işlemleri gerçekleştiren bir Web API uygulamasıdır. Yarışmacılar ve kategoriler arasında bire-çok (one-to-many) ilişkisi vardır. API, yarışmacılar ve kategoriler üzerinde çeşitli CRUD işlemlerini yapmanızı sağlar.

## Özellikler

- **Yarışmacılar** ve **kategoriler** arasında bire-çok ilişkisi (One-to-Many).
- Soft delete özelliği sayesinde veriler veritabanından tamamen silinmez, sadece "silinmiş" olarak işaretlenir.
- **CRUD** işlemleri:
  - Yarışmacılar (Competitors)
  - Kategoriler (Categories)
- Veritabanı yönetimi ve ilişkilerin tanımlanması **Entity Framework Core** kullanılarak gerçekleştirilmiştir.
- **Swagger** ile API dökümantasyonu ve test arayüzü.

## Kullanılan Teknolojiler

- ASP.NET Core 7
- Entity Framework Core
- SQL Server
- Swagger
- Postman (isteğe bağlı, API testleri için)

## API Endpoint'leri

### Competitors (Yarışmacılar)

- `GET /api/competitors` - Tüm yarışmacıları getir.
- `GET /api/competitors/{id}` - Belirli bir yarışmacıyı getir.
- `GET /api/competitors/categories/{CategoryId}` - Belirli bir kategoriye ait yarışmacıları getir.
- `POST /api/competitors` - Yeni bir yarışmacı ekle.
- `PUT /api/competitors/{id}` - Mevcut bir yarışmacıyı güncelle.
- `DELETE /api/competitors/{id}` - Yarışmacıyı soft delete yaparak sil.

### Categories (Kategoriler)

- `GET /api/categories` - Tüm kategorileri getir.
- `GET /api/categories/{id}` - Belirli bir kategoriyi getir.
- `POST /api/categories` - Yeni bir kategori ekle.
- `PUT /api/categories/{id}` - Mevcut bir kategoriyi güncelle.
- `DELETE /api/categories/{id}` - Kategoriyi soft delete yaparak sil.

## API'yi Test Etme

API endpoint'lerini test etmek için **Postman** ya da **Swagger UI** kullanabilirsiniz.
