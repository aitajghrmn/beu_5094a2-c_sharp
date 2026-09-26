import os
import requests
from dotenv import load_dotenv
from datetime import datetime

load_dotenv()

API_KEY = os.getenv("OPENWEATHER_API_KEY")

if not API_KEY:
    raise ValueError("OPENWEATHER_API_KEY tapılmadı!")


# Azərbaycan şəhərləri
CITIES = {
    "baki": "Baku,AZ",
    "bakı": "Baku,AZ",
    "gence": "Ganja,AZ",
    "gəncə": "Ganja,AZ",
    "sumqayit": "Sumqayit,AZ",
    "sumqayıt": "Sumqayit,AZ",
    "mingecevir": "Mingachevir,AZ",
    "mingəçevir": "Mingachevir,AZ",
    "lenkeran": "Lankaran,AZ",
    "lənkəran": "Lankaran,AZ",
    "quba": "Quba,AZ",
    "quba": "Quba,AZ",
    "saki": "Shaki,AZ",
    "şəki": "Shaki,AZ",
    "şəki": "Shaki,AZ",
    "şirvan": "Shirvan,AZ",
    "naftalan": "Naftalan,AZ",
    "şamaxı": "Shamakhi,AZ",
    "salyan": "Salyan,AZ",
    "agcabedi": "Agjabadi,AZ",
    "ağcabədi": "Agjabadi,AZ",
}


def hava_proqnozu(seher):
    seher = seher.lower().strip()

    if seher not in CITIES:
        return (
            f"'{seher}' şəhəri siyahıda yoxdur.\n"
            f"Mövcud şəhərlər: {', '.join(sorted(set(CITIES.keys())))}"
        )

    city = CITIES[seher]

    url = "https://api.openweathermap.org/data/2.5/forecast"

    params = {
        "q": city,
        "appid": API_KEY,
        "units": "metric",
        "lang": "az"
    }

    try:
        response = requests.get(url, params=params, timeout=10)
        response.raise_for_status()

        data = response.json()

        city_name = data["city"]["name"]

        result = f"\n🌤️ {city_name} üçün hava proqnozu\n"
        result += "=" * 40 + "\n"

        # İlk 8 məlumatı göstəririk = təxminən 24 saat
        for item in data["list"][:8]:

            tarix = datetime.fromtimestamp(item["dt"])

            temperatur = item["main"]["temp"]
            hiss_olunan = item["main"]["feels_like"]
            humidity = item["main"]["humidity"]

            hava = item["weather"][0]["description"]

            wind_speed = item["wind"]["speed"]

            result += (
                f"\n📅 {tarix.strftime('%d.%m.%Y %H:%M')}\n"
                f"🌡️ Temperatur: {temperatur:.1f}°C\n"
                f"🤔 Hiss olunan: {hiss_olunan:.1f}°C\n"
                f"☁️ Hava: {hava}\n"
                f"💧 Rütubət: {humidity}%\n"
                f"💨 Külək: {wind_speed} m/s\n"
            )

        return result

    except requests.exceptions.HTTPError as e:
        return f"API xətası: {e}"

    except requests.exceptions.RequestException as e:
        return f"İnternet/API bağlantı xətası: {e}"

    except Exception as e:
        return f"Gözlənilməz xəta: {e}"


# Proqram
while True:

    seher = input("\nŞəhərin adını yazın (çıxmaq üçün 'exit'): ")

    if seher.lower() == "exit":
        print("Proqram dayandırıldı.")
        break

    print(hava_proqnozu(seher))
