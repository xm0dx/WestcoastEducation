# Westcoast Education

Inlämningsuppgift 1 i kursen Programmering med C# (ITHS).

Ett konsolprogram som håller reda på en skolas kurser, studerande, lärare,
utbildningsledare och administratörer.

## Klasser

- `Person` – det alla personer har gemensamt (namn, telefon, personnummer, adress)
- `Student` – ärver från Person
- `Teacher` – ärver från Person, har ett kunskapsområde och en lista med kurser
- `EducationLeader` – ärver från Teacher, har även anställningsdatum
- `Administrator` – ärver från EducationLeader
- `Course` – kursnummer, titel, längd, start- och slutdatum, distans eller klassrum, och en lärare
- `School` – äger listorna och har metoder för att lägga till och lista

## Kontroller

- en kurs med samma kursnummer läggs inte till två gånger
- en kurs med slutdatum före startdatum läggs inte till
- en studerande eller lärare med samma personnummer läggs inte till två gånger

## Köra programmet

```
dotnet run
```
