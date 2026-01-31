using System;
using System.Linq;

namespace projektowanie_obiektowe.Lab2.Zadanie5
{
    public class Sumator
    {
        private int[] _liczby;

        public Sumator(int[] liczby)
        {
            _liczby = liczby;
            Console.WriteLine($"Sumator z {liczby.Length} liczbami gotowy.");
        }

        public int Suma()
        {
            int suma = 0;
            foreach (int liczba in _liczby)
            {
                suma += liczba;
            }
            return suma;
        }

        public int SumaPodziel2()
        {
            int suma = 0;
            foreach (int liczba in _liczby)
            {
                if (liczba % 2 == 0)
                {
                    suma += liczba;
                }
            }
            return suma;
        }

        public int IleElementow()
        {
            return _liczby.Length;
        }

        public void WypiszElementy()
        {
            Console.Write("Liczby: ");
            foreach (int liczba in _liczby)
            {
                Console.Write($"{liczba} ");
            }
            Console.WriteLine();
        }

        public void WypiszElementyZakresu(int lowIndex, int highIndex)
        {
            int start = Math.Max(0, lowIndex);
            int koniec = Math.Min(_liczby.Length - 1, highIndex);

            if (start > koniec || start >= _liczby.Length)
            {
                Console.WriteLine($"Nie ma liczb w zakresie [{lowIndex}, {highIndex}]");
                return;
            }

            Console.Write($"Zakres [{lowIndex}, {highIndex}] (czyli [{start}, {koniec}]): ");
            for (int i = start; i <= koniec; i++)
            {
                Console.Write($"{_liczby[i]} ");
            }
            Console.WriteLine();
        }

        public int Max()
        {
            if (_liczby.Length == 0)
            {
                throw new InvalidOperationException("Tablica jest pusta");
            }
            return _liczby.Max();
        }

        public int Min()
        {
            if (_liczby.Length == 0)
            {
                throw new InvalidOperationException("Tablica jest pusta");
            }
            return _liczby.Min();
        }

        public double Srednia()
        {
            if (_liczby.Length == 0)
            {
                return 0;
            }
            return _liczby.Average();
        }

        public static void Wykonaj()
        {
            Console.WriteLine("\n=== Sumator - sprawdzam co potrafi ===\n");

            int[] tablica1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Sumator sumator1 = new Sumator(tablica1);

            sumator1.WypiszElementy();

            Console.WriteLine($"Suma wszystkich: {sumator1.Suma()}");

            Console.WriteLine($"Suma parzystych: {sumator1.SumaPodziel2()}");

            Console.WriteLine($"Ile liczb: {sumator1.IleElementow()}");

            Console.WriteLine($"Najmniejsza: {sumator1.Min()}");
            Console.WriteLine($"Największa: {sumator1.Max()}");
            Console.WriteLine($"Średnia: {sumator1.Srednia():F2}");

            Console.WriteLine("\n--- Wypisywanie zakresów ---");
            sumator1.WypiszElementyZakresu(2, 7);
            sumator1.WypiszElementyZakresu(0, 4);
            sumator1.WypiszElementyZakresu(5, 9);

            Console.WriteLine("\n--- Dziwne zakresy ---");
            sumator1.WypiszElementyZakresu(-5, 5);
            sumator1.WypiszElementyZakresu(7, 15);
            sumator1.WypiszElementyZakresu(-3, 100);
            sumator1.WypiszElementyZakresu(20, 30);

            Console.WriteLine("\n--- Inny sumator ---");
            int[] tablica2 = { 15, 22, 8, 31, 45, 12, 7, 19 };
            Sumator sumator2 = new Sumator(tablica2);
            sumator2.WypiszElementy();
            Console.WriteLine($"Suma: {sumator2.Suma()}");
            Console.WriteLine($"Parzyste: {sumator2.SumaPodziel2()}");
            Console.WriteLine($"Ile: {sumator2.IleElementow()}");
            sumator2.WypiszElementyZakresu(1, 5);
        }
    }
}

