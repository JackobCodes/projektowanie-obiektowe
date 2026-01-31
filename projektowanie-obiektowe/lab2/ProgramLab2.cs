using System;
using projektowanie_obiektowe.Lab2.Zadanie1;
using projektowanie_obiektowe.Lab2.Zadanie2;
using projektowanie_obiektowe.Lab2.Zadanie3;
using projektowanie_obiektowe.Lab2.Zadanie4;
using projektowanie_obiektowe.Lab2.Zadanie5;

namespace projektowanie_obiektowe.Lab2
{
    class ProgramLab2
    {
        public static void Uruchom()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n########## Lab 2 - Klasy i obiekty ##########");
                Console.WriteLine();
                Console.WriteLine("Która klasa?");
                Console.WriteLine();
                Console.WriteLine("1. Osoba (z walidacją danych)");
                Console.WriteLine("2. Konto bankowe");
                Console.WriteLine("3. Student (z ocenami)");
                Console.WriteLine("4. Kalkulator liczb");
                Console.WriteLine("5. Sumator (operacje na tablicy)");
                Console.WriteLine("0. Wróć");
                Console.WriteLine();
                Console.Write("Wybierz: ");

                string? wybor = Console.ReadLine();

                try
                {
                    switch (wybor)
                    {
                        case "1":
                            Osoba.Wykonaj();
                            break;
                        case "2":
                            BankAccount.Wykonaj();
                            break;
                        case "3":
                            Student.Wykonaj();
                            break;
                        case "4":
                            Licz.Wykonaj();
                            break;
                        case "5":
                            Sumator.Wykonaj();
                            break;
                        case "0":
                            running = false;
                            Console.WriteLine("\nWracam...");
                            break;
                        default:
                            Console.WriteLine("\nEee, nie ma takiej opcji.");
                            break;
                    }

                    if (running && wybor != "0")
                    {
                        Console.WriteLine("\n" + new string('─', 50));
                        Console.WriteLine("Kliknij coś...");
                        Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nUps, coś nie pykło: {ex.Message}");
                    Console.WriteLine("Kliknij coś...");
                    Console.ReadKey();
                }
            }
        }
    }
}

