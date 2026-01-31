using projektowanie_obiektowe.Lab1.Zadanie1;
using projektowanie_obiektowe.Lab1.Zadanie2;
using projektowanie_obiektowe.Lab1.Zadanie3;
using projektowanie_obiektowe.Lab1.Zadanie4;
using projektowanie_obiektowe.Lab1.Zadanie5;

namespace projektowanie_obiektowe;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        
        while (running)
        {
            Console.WriteLine("\n=== MENU GŁÓWNE - LAB 1 ===");
            Console.WriteLine("1. Obliczanie wyróżnika delta i pierwiastków trójmianu kwadratowego");
            Console.WriteLine("2. Operacje na tablicy 10 liczb");
            Console.WriteLine("3. Wyświetlanie liczb od 20 do 0 z wyłączeniami");
            Console.WriteLine("4. Wprowadzanie liczb w pętli nieskończonej");
            Console.WriteLine("5. Sortowanie tablicy n liczb");
            Console.WriteLine("0. Wyjście");
            Console.Write("\nWybierz zadanie (0-5): ");
            
            string? wybor = Console.ReadLine();
            
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
                    Console.WriteLine("Do widzenia!");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                    break;
            }
        }
    }
}
