using System;
using System.Collections.Generic;
using System.Linq;

namespace projektowanie_obiektowe.Lab2.Zadanie3
{
    public class Student
    {
        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        private List<int> _oceny;

        public double SredniaOcen
        {
            get
            {
                if (_oceny.Count == 0)
                {
                    return 0;
                }
                return _oceny.Average();
            }
        }

        public Student(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            _oceny = new List<int>();
        }

        public void DodajOcene(int ocena)
        {
            if (ocena < 1 || ocena > 6)
            {
                Console.WriteLine("Ocena musi być między 1 a 6!");
                return;
            }

            _oceny.Add(ocena);
            Console.WriteLine($"Wpisałem ocenę: {ocena}");
        }

        public void WyswietlOceny()
        {
            if (_oceny.Count == 0)
            {
                Console.WriteLine("Jeszcze nie ma żadnych ocen.");
                return;
            }

            Console.Write("Oceny: ");
            foreach (var ocena in _oceny)
            {
                Console.Write($"{ocena} ");
            }
            Console.WriteLine();
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"\nStudent: {Imie} {Nazwisko}");
            WyswietlOceny();
            Console.WriteLine($"Średnia: {SredniaOcen:F2}");
        }

        public static void Wykonaj()
        {
            Console.WriteLine("\n=== Student z ocenami ===\n");

            Student student1 = new Student("Jan", "Kowalski");
            
            Console.WriteLine("Dodaję kilka ocen:");
            student1.DodajOcene(5);
            student1.DodajOcene(4);
            student1.DodajOcene(5);
            student1.DodajOcene(3);
            student1.DodajOcene(4);

            student1.WyswietlInformacje();

            Console.WriteLine("\nSpróbuję dać złą ocenę:");
            student1.DodajOcene(7);
            student1.DodajOcene(0);

            Console.WriteLine("\n--- Drugi student ---");
            Student student2 = new Student("Anna", "Nowak");
            student2.DodajOcene(6);
            student2.DodajOcene(6);
            student2.DodajOcene(5);
            student2.DodajOcene(6);
            student2.WyswietlInformacje();

            Console.WriteLine("\n--- Student bez ocen ---");
            Student student3 = new Student("Piotr", "Wiśniewski");
            student3.WyswietlInformacje();
        }
    }
}

