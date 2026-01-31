using System;
using projektowanie_obiektowe.Lab1.Zadanie1;
using projektowanie_obiektowe.Lab1.Zadanie2;
using projektowanie_obiektowe.Lab1.Zadanie3;
using projektowanie_obiektowe.Lab1.Zadanie4;
using projektowanie_obiektowe.Lab1.Zadanie5;

namespace projektowanie_obiektowe.Lab1
{
    class ProgramLab1
    {
        public static void Uruchom()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("\n########## Lab 1 - Podstawy C# ##########");
                Console.WriteLine();
                Console.WriteLine("Co chesz uruchomić?");
                Console.WriteLine();
                Console.WriteLine("1. Trójmian kwadratowy (delta i pierwiastki)");
                Console.WriteLine("2. Operacje na tablicy liczb");
                Console.WriteLine("3. Liczby od 20 do 0 (z pominięciami)");
                Console.WriteLine("4. Pętla która się zatrzyma jak wpiszesz liczbę ujemną");
                Console.WriteLine("5. Sortowanie liczb");
                Console.WriteLine("0. Wróć");
                Console.WriteLine();
                Console.Write("Wybierz: ");

                string? wybor = Console.ReadLine();

                try
                {
                    switch (wybor)
                    {
                        case "1":
                            TrojmianKwadratowy.Wykonaj();
                            break;
                        case "2":
                            OperacjeNaTablicy.Wykonaj();
                            break;
                        case "3":
                            LiczbyZWylaczeniami.Wykonaj();
                            break;
                        case "4":
                            PetlaNieskonczona.Wykonaj();
                            break;
                        case "5":
                            SortowanieTablicy.Wykonaj();
                            break;
                        case "0":
                            running = false;
                            Console.WriteLine("\nWracam do menu głównego...");
                            break;
                        default:
                            Console.WriteLine("\nNie ma takiej opcji!");
                            break;
                    }

                    if (running && wybor != "0")
                    {
                        Console.WriteLine("\n" + new string('─', 50));
                        Console.WriteLine("Naciśnij coś żeby kontynuować...");
                        Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nCoś poszło nie tak: {ex.Message}");
                    Console.WriteLine("Naciśnij coś...");
                    Console.ReadKey();
                }
            }
        }
    }
}

