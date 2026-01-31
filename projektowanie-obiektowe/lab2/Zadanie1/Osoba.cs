using System;

namespace projektowanie_obiektowe.Lab2.Zadanie1
{
    public class Osoba
    {
        private string _imie = string.Empty;
        private string _nazwisko = string.Empty;
        private int _wiek;

        public string Imie
        {
            get => _imie;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentException("Imię musi mieć co najmniej 2 znaki.");
                }
                _imie = value;
            }
        }

        public string Nazwisko
        {
            get => _nazwisko;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentException("Nazwisko musi mieć co najmniej 2 znaki.");
                }
                _nazwisko = value;
            }
        }

        public int Wiek
        {
            get => _wiek;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Wiek musi być liczbą dodatnią.");
                }
                _wiek = value;
            }
        }

        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Osoba: {Imie} {Nazwisko}, Wiek: {Wiek} lat");
        }

        public static void Wykonaj()
        {
            Console.WriteLine("\n=== Klasa Osoba - sprawdzam jak działa ===\n");

            try
            {
                Osoba osoba1 = new Osoba("Jan", "Kowalski", 30);
                osoba1.WyswietlInformacje();

                Osoba osoba2 = new Osoba("Anna", "Nowak", 25);
                osoba2.WyswietlInformacje();

                Console.WriteLine("\nZmieniam wiek osoby 1:");
                osoba1.Wiek = 31;
                osoba1.WyswietlInformacje();

                Console.WriteLine("\nTeraz spróbuję wpisać głupi wiek:");
                try
                {
                    Osoba osoba3 = new Osoba("Test", "Testowy", -5);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"O nie! {ex.Message}");
                }

                Console.WriteLine("\nA teraz za krótkie imię:");
                try
                {
                    Osoba osoba4 = new Osoba("A", "Testowy", 20);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Nie przeszło: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Coś się wysypało: {ex.Message}");
            }
        }
    }
}

