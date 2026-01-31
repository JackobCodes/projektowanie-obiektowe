# Szybki Start - Lab 2

## Jak uruchomić program?

### Metoda 1: Z IDE (Rider)
1. Otwórz projekt w Rider
2. Kliknij zielony przycisk ▶️ (Run) lub naciśnij `Ctrl+R` (Windows/Linux) / `Cmd+R` (macOS)
3. Program uruchomi się i pokaże menu główne

### Metoda 2: Z terminala
```bash
cd /Users/jakublewicki/RiderProjects/projektowanie-obiektowe/projektowanie-obiektowe
dotnet run
```

## Nawigacja po programie

Po uruchomieniu zobaczysz:

```
╔════════════════════════════════════════════════╗
║     PROGRAMOWANIE OBIEKTOWE - C#               ║
║           MENU GŁÓWNE                          ║
╚════════════════════════════════════════════════╝

Wybierz laboratorium:

1. Laboratorium 1 - Podstawy C#
2. Laboratorium 2 - Programowanie obiektowe
0. Wyjście

Twój wybór:
```

### Wybierz "2" dla Lab 2

Zobaczysz menu Lab 2:

```
╔════════════════════════════════════════════════╗
║        MENU GŁÓWNE - LAB 2                     ║
║     Programowanie Obiektowe w C#               ║
╚════════════════════════════════════════════════╝

1. Zadanie 1 - Klasa Osoba
2. Zadanie 2 - Klasa BankAccount
3. Zadanie 3 - Klasa Student
4. Zadanie 4 - Klasa Licz
5. Zadanie 5 - Klasa Sumator
0. Powrót do menu głównego

Wybierz zadanie (0-5):
```

## Co robi każde zadanie?

### Zadanie 1 - Klasa Osoba
- Tworzy osoby z walidacją danych
- Sprawdza czy imię/nazwisko mają min. 2 znaki
- Sprawdza czy wiek jest dodatni

**Przykładowe wyjście:**
```
Osoba: Jan Kowalski, Wiek: 30 lat
Osoba: Anna Nowak, Wiek: 25 lat
```

### Zadanie 2 - Klasa BankAccount
- Symuluje konto bankowe
- Pozwala na wpłaty i wypłaty
- Sprawdza dostępność środków

**Przykładowe wyjście:**
```
Utworzono konto dla: Jan Kowalski z saldem początkowym: 1 000,00 zł
Wpłacono: 500,00 zł. Aktualne saldo: 1 500,00 zł
Wypłacono: 200,00 zł. Aktualne saldo: 1 300,00 zł
```

### Zadanie 3 - Klasa Student
- Zarządza ocenami studenta
- Automatycznie oblicza średnią
- Dodaje oceny z walidacją (1-6)

**Przykładowe wyjście:**
```
Student: Jan Kowalski
Oceny: 5 4 5 3 4
Średnia ocen: 4,20
```

### Zadanie 4 - Klasa Licz
- Wykonuje operacje arytmetyczne
- Metody: Dodaj, Odejmij, Pomnóż, Podziel
- Pokazuje aktualną wartość

**Przykładowe wyjście:**
```
Utworzono obiekt Licz z wartością: 10
Dodano 5. Nowa wartość: 15
Pomnożono przez 2. Nowa wartość: 30
```

### Zadanie 5 - Klasa Sumator
- Analizuje tablicę liczb
- Oblicza sumę, średnią, min, max
- Wyświetla elementy w zakresach

**Przykładowe wyjście:**
```
Elementy tablicy: 1 2 3 4 5 6 7 8 9 10
Suma wszystkich elementów: 55
Suma liczb podzielnych przez 2: 30
```

## Wyjście z programu

- Naciśnij "0" aby wrócić do poprzedniego menu
- Naciśnij "0" w menu głównym aby zakończyć program
- Lub użyj Ctrl+C w terminalu

## Rozwiązywanie problemów

### Program się nie uruchamia?
```bash
# Sprawdź czy masz zainstalowany .NET
dotnet --version

# Zbuduj projekt ponownie
dotnet build
```

### Błędy kompilacji?
```bash
# Wyczyść i zbuduj ponownie
dotnet clean
dotnet build
```

### Błędna ścieżka?
Upewnij się, że jesteś w katalogu projektu:
```bash
cd /Users/jakublewicki/RiderProjects/projektowanie-obiektowe/projektowanie-obiektowe
```

## Dodatkowe informacje

- Każde zadanie można uruchomić wiele razy
- Po każdym zadaniu pojawi się komunikat "Naciśnij dowolny klawisz..."
- Wszystkie testy są automatyczne - nie musisz nic wpisywać
- Możesz przechodzić między zadaniami swobodnie

## Przydatne skróty w Rider

- `Ctrl+R` / `Cmd+R` - Uruchom program
- `Shift+F10` - Uruchom ostatnią konfigurację
- `Ctrl+C` - Zatrzymaj program
- `Alt+F12` - Otwórz terminal w IDE

Miłej nauki! 🎓

