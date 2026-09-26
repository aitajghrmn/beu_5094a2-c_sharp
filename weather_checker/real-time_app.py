"""
Hava haqqında məlumat proqramı (əlavə quraşdırma tələb etmir)
----------------------------------------------------------------
Bu versiya Python-un öz daxili "urllib" modulundan istifadə edir,
ona görə "pip install" etməyə ehtiyac yoxdur. Şəhər adını daxil
edən kimi temperaturu və digər hava məlumatlarını göstərir.
"""

import urllib.request
import json


def hava_melumati_al(seher: str) -> None:
    """Verilən şəhər üçün hava məlumatını çəkib ekrana çıxarır."""
    url = f"https://wttr.in/{seher}?format=j1"

    try:
        sorgu = urllib.request.Request(url, headers={"User-Agent": "Mozilla/5.0"})
        with urllib.request.urlopen(sorgu, timeout=10) as cavab:
            data = json.loads(cavab.read().decode("utf-8"))
    except Exception as xeta:
        print(f"Xəta baş verdi: {xeta}")
        return

    try:
        indiki = data["current_condition"][0]
        temperatur = indiki["temp_C"]
        hiss_olunan = indiki["FeelsLikeC"]
        neml = indiki["humidity"]
        kuleyin_sureti = indiki["windspeedKmph"]
        tesvir = indiki["weatherDesc"][0]["value"]

        print("\n" + "=" * 40)
        print(f"  Şəhər: {seher.title()}")
        print("=" * 40)
        print(f"  Hava vəziyyəti : {tesvir}")
        print(f"  Temperatur     : {temperatur}°C")
        print(f"  Hiss olunan    : {hiss_olunan}°C")
        print(f"  Nəmlik         : {neml}%")
        print(f"  Külək sürəti   : {kuleyin_sureti} km/saat")
        print("=" * 40 + "\n")

    except (KeyError, IndexError):
        print("Məlumatlar oxunarkən xəta baş verdi. Şəhər adını yoxlayın.")


def main():
    print("HAVA HAQQINDA MƏLUMAT PROQRAMI")
    print("Çıxmaq üçün 'exit' yazın.\n")

    while True:
        seher = input("Şəhərin adını daxil edin: ").strip()

        if seher.lower() == "exit":
            print("Proqramdan çıxılır. Sağ olun!")
            break

        if not seher:
            print("Zəhmət olmasa, şəhər adı daxil edin.\n")
            continue

        hava_melumati_al(seher)


if __name__ == "__main__":
    main()
