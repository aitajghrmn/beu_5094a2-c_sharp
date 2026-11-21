# UniversityEventsAPI

Universitet tədbirlərinin idarə edilməsi üçün ASP.NET Core Web API (.NET 9, C#).
Məlumatlar hələlik verilənlər bazasında deyil, yaddaşdakı `List<Event>` daxilində saxlanılır
(tətbiq yenidən başladıqda məlumatlar silinir).

## İşə salmaq

```bash
cd UniversityEventsAPI
dotnet run
```

Və ya `UniversityEventsAPI.sln` faylını Visual Studio-da açıb **F5** basın.

- Swagger UI: `https://localhost:7120/swagger`
- OpenAPI sənədi: `https://localhost:7120/openapi/v1.json`

> Port fərqli olarsa, `Properties/launchSettings.json` faylına və ya konsol çıxışına baxın.

## Endpoint-lər

| Metod  | Endpoint            | Əməliyyat                 | Uğurlu cavab |
|--------|---------------------|---------------------------|--------------|
| GET    | `/api/events`       | Bütün tədbirləri göstərmək | 200 OK |
| GET    | `/api/events/{id}`  | ID-yə görə tədbiri tapmaq  | 200 OK / 404 |
| POST   | `/api/events`       | Yeni tədbir yaratmaq       | 201 Created / 400 |
| PUT    | `/api/events/{id}`  | Tədbiri yeniləmək          | 200 OK / 400 / 404 |
| DELETE | `/api/events/{id}`  | Tədbiri silmək             | 204 No Content / 404 |
| GET    | `/api/events/export`| Tədbirləri JSON faylı kimi ixrac etmək | 200 OK |

## Biznes qaydaları

1. Tədbirin adı boş ola bilməz.
2. Tədbirin tarixi keçmiş tarix ola bilməz.
3. İştirakçı sayı 1-dən az ola bilməz.
4. Mövcud olmayan ID üçün `404 Not Found`.
5. Uğurlu yaradılmada `201 Created`.
6. Uğurlu silinmədə `204 No Content`.
7. Yanlış məlumatda `400 Bad Request` (xətaların siyahısı ilə).

## Əlavə funksiyalar (query parametrləri)

`GET /api/events` və `GET /api/events/export` aşağıdakı parametrləri qəbul edir, hamısı birlikdə işləyir:

| Parametr | Nümunə | Təsvir |
|----------|--------|--------|
| `search` | `?search=ai` | Adına görə axtarış |
| `sortBy=date` + `desc` | `?sortBy=date&desc=true` | Tarixə görə sıralama |
| `upcoming` | `?upcoming=true` | Yalnız gələcək tədbirlər |
| `city` | `?city=Baku` | Şəhərə (location) görə filtr |
| `large` | `?large=true` | İştirakçı sayı 100-dən çox olanlar |

Nümunə: `GET /api/events?city=Baku&upcoming=true&sortBy=date`

## Postman ilə test

1. Postman-də **Import** → `UniversityEventsAPI.postman_collection.json` faylını seçin.
2. Collection-un `baseUrl` dəyişənini öz HTTPS portunuza uyğunlaşdırın (məs. `https://localhost:7120`).
3. Əvvəl **POST** sorğusunu göndərin, sonra GET / PUT / DELETE sorğularını yoxlayın.

Visual Studio-dakı `UniversityEventsAPI.http` faylı ilə də eyni sorğuları birbaşa IDE-dən göndərə bilərsiniz.

## Layihə strukturu

```
UniversityEventsAPI/
├── UniversityEventsAPI.sln
├── UniversityEventsAPI.postman_collection.json
├── README.md
├── .gitignore
└── UniversityEventsAPI/
    ├── UniversityEventsAPI.csproj
    ├── Program.cs
    ├── appsettings.json
    ├── UniversityEventsAPI.http
    ├── Properties/launchSettings.json
    ├── Models/Event.cs
    └── Controllers/EventsController.cs
```
