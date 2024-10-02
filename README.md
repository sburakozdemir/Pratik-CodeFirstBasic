# Pratik Code First Basic

Bu proje, **Entity Framework Core** kullanarak **Code First** yaklaşımıyla bir veritabanı oluşturmayı göstermektedir. Uygulamada iki temel veri tablosu bulunmaktadır: `Movies` ve `Games`. Her iki tablo da çeşitli özelliklerle tanımlanmış ve veritabanı üzerinde migration işlemi ile oluşturulmuştur.

## Özellikler

Bu proje, aşağıdaki iki tabloyu veritabanında oluşturmaktadır:

### Movie Tablosu:
- **Id:** int (Birincil anahtar, otomatik artan)
- **Title:** string (Filmin başlığı)
- **Genre:** string (Filmin türü, örneğin: "Action", "Comedy", "Drama")
- **ReleaseYear:** int (Filmin çıkış yılı)

### Game Tablosu:
- **Id:** int (Birincil anahtar, otomatik artan)
- **Name:** string (Oyunun adı)
- **Platform:** string (Oyunun oynandığı platform, örneğin: "PC", "PlayStation", "Xbox")
- **Rating:** decimal (Oyunun puanı, 0 ile 10 arasında)
