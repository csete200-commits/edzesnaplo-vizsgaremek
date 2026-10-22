# Vizsgaremek – dokumentáció

*Ez a sablon a vizsgaremek-dokumentáció kötelező részeit tartalmazza. A dőlt betűs kitöltési útmutatókat cseréld le a saját
szövegetekre; a fejezetcímeket hagyjátok meg, mert a PaTricks mérföldkő-ellenőrzése ezek alapján keresi a részeket.*

**Projekt neve:** *…*
**Csapattagok:** *…*
**Dátum:** *…*

## A projekt célja

*Írd le, milyen problémát old meg a projekt, és kinek készül (célközönség). 1–2 bekezdés elég: miért hasznos, mit tud a kész rendszer.*

## Komponensek és felépítés

*Sorold fel a rendszer részeit (backend / REST-szerver, adatbázis, asztali, webes és mobil kliens), és írd le, hogyan kapcsolódnak egymáshoz.*

*Ide kerülhet egy egyszerű ábra a komponensekről, pl. `![Felépítés](felepites.png)`.*

| Komponens | Technológia | Feladata |
|---|---|---|
| *Backend* | *pl. ASP.NET Core / Node.js* | *…* |
| *Adatbázis* | *pl. MySQL* | *…* |
| *Kliens* | *pl. WPF / Angular / Android* | *…* |

## Műszaki feltételek

*Írd le a futtatáshoz szükséges hardvert és szoftvert (operációs rendszer, futtatókörnyezet, adatbázis-szerver – verziószámokkal), majd a
telepítés és az indítás lépéseit úgy, hogy egy idegen is el tudja indítani a rendszert.*

1. *Telepítés: …*
2. *Az adatbázis létrehozása: …*
3. *Indítás: …*

## Használati útmutató

*Ez a felhasználói dokumentáció. Írd le a szerepköröket (pl. vendég, felhasználó, adminisztrátor), majd a fő funkciókat lépésenként.*

*Ide kerülnek a képernyőképek, pl. `![Bejelentkezés](kepek/bejelentkezes.png)`.*

## Adatbázis

### Adatbázis-diagram

*Tedd a tárolóba az adatbázis ER-diagramját (pl. `docs/adatbazis.png`), és itt hivatkozz rá: `![Adatbázis-diagram](adatbazis.png)`. Röviden
írd le a táblákat és a kapcsolataikat.*

### Adatbázis-dump

*Add meg az adatbázis-dump (`.sql`) helyét a tárolóban (pl. `database/dump.sql`). A dump tartalmazza a táblák létrehozását
(`CREATE TABLE`) és mintaadatokat (`INSERT INTO`), hogy az adatbázis egy lépésben visszaállítható legyen.*

## Tesztelés és teszteredmények

*Írd le, hol vannak a tesztek a tárolóban, hogyan futtathatók, és mi lett az eredményük. A kézi teszteket is ide írd.*

| Teszt | Elvárt eredmény | Kapott eredmény | ✔/✘ |
|---|---|---|---|
| *…* | *…* | *…* | *…* |

## Csapatmunka

*Írd le, ki mit készített a projektben (a védésen is kérdezhetik), és hogyan osztottátok fel a munkát.*

## Források

*Sorold fel a felhasznált dokumentációkat, könyvtárakat, képeket és egyéb forrásokat.*
