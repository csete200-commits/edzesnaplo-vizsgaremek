# Sportegyesületi edzésnapló

Vizsgaremek – KódKovácsok (Kertész Bence, Fodor Lili, Halász Dominik)

Edzések, résztvevők és jelenlét nyilvántartása egy sportegyesületnek.


## Futtatás

`dotnet run --project backend` – a REST-szerver a 5000-es porton indul.

## Fejlesztői környezet

Először a db/edzesnaplo.sql-t futtasd SQLite-tal, utána indítsd a REST-szervert.

## Tesztek

`dotnet test tests` – az edzés-validáció egységtesztjei.

## Tesztek

`dotnet test tests` – az edzés-validáció egységtesztjei.

## Mentés

Az edzesnaplo.db fájlt hetente másold a közös meghajtóra.

Visszaállításhoz állítsd le a szervert, és másold vissza az edzesnaplo.db fájlt.