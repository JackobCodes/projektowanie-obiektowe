using System;

namespace projektowanie_obiektowe.Lab2.Zadanie4
{
    public class Licz
    {
        private double _value;

        public Licz(double wartosc)
        {
            _value = wartosc;
            Console.WriteLine($"Liczba startowa: {_value}");
        }

        public void Dodaj(double liczba)
        {
            _value += liczba;
            Console.WriteLine($"Dodałem {liczba}, teraz: {_value}");
        }

        public void Odejmij(double liczba)
        {
            _value -= liczba;
            Console.WriteLine($"Odjąłem {liczba}, teraz: {_value}");
        }

        public void Pomnoz(double liczba)
        {
            _value *= liczba;
            Console.WriteLine($"Pomnożyłem przez {liczba}, teraz: {_value}");
        }

        public void Podziel(double liczba)
        {
            if (liczba == 0)
            {
                Console.WriteLine("Nie mogę dzielić przez zero!");
                return;
            }
            _value /= liczba;
            Console.WriteLine($"Podzieliłem przez {liczba}, teraz: {_value}");
        }

        public void WypiszStan()
        {
            Console.WriteLine($"Wartość: {_value}");
        }

        public double PobierzWartosc()
        {
            return _value;
        }

        public void Reset()
        {
            _value = 0;
            Console.WriteLine("Zresetowałem do zera");
        }

        public static void Wykonaj()
        {
            Console.WriteLine("\n=== Kalkulator - testuje ===\n");

            Console.WriteLine("--- Test 1 ---");
            Licz liczba1 = new Licz(10);
            liczba1.WypiszStan();
            liczba1.Dodaj(5);
            liczba1.Odejmij(3);
            liczba1.WypiszStan();

            Console.WriteLine("\n--- Test 2 ---");
            Licz liczba2 = new Licz(100);
            liczba2.WypiszStan();
            liczba2.Pomnoz(2);
            liczba2.Podziel(4);
            liczba2.WypiszStan();

            Console.WriteLine("\n--- Test 3 ---");
            Licz liczba3 = new Licz(50);
            liczba3.Dodaj(25);
            liczba3.Dodaj(25);
            liczba3.Odejmij(50);
            liczba3.Pomnoz(3);
            liczba3.WypiszStan();

            Console.WriteLine("\n--- Dzielenie przez zero ---");
            Licz liczba4 = new Licz(20);
            liczba4.Podziel(0);
            liczba4.WypiszStan();

            Console.WriteLine("\n--- Różne operacje ---");
            Licz liczba5 = new Licz(5);
            liczba5.Dodaj(10);
            liczba5.Pomnoz(2);
            liczba5.Odejmij(10);
            liczba5.Podziel(4);
            liczba5.WypiszStan();

            Console.WriteLine("\n--- Reset ---");
            liczba5.Reset();
            liczba5.WypiszStan();
        }
    }
}

