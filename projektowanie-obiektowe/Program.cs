using projektowanie_obiektowe.Lab1;
using projektowanie_obiektowe.Lab2;

namespace projektowanie_obiektowe;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        
        while (running)
        {
            Console.Clear();
            Console.WriteLine("\n########## Programowanie w C# ##########");
            Console.WriteLine();
            Console.WriteLine("Którą pracę chcesz zobaczyć?");
            Console.WriteLine();
            Console.WriteLine("1. Lab 1 - podstawowe rzeczy w C#");
            Console.WriteLine("2. Lab 2 - klasy i obiekty");
            Console.WriteLine("0. Wyjdź");
            Console.WriteLine();
            Console.Write("Wybierz: ");
            
            string? wybor = Console.ReadLine();
            
            switch (wybor)
            {
                case "1":
                    ProgramLab1.Uruchom();
                    break;
                case "2":
                    ProgramLab2.Uruchom();
                    break;
                case "0":
                    running = false;
                    Console.WriteLine("\nPa!");
                    break;
                default:
                    Console.WriteLine("\nHm, nie ma takiej opcji. Spróbuj jeszcze raz.");
                    Console.WriteLine("Naciśnij coś...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
