namespace projektowanie_obiektowe.Lab1.Zadanie4;

public static class PetlaNieskonczona
{
    public static void Wykonaj()
    {
        Console.WriteLine("\n=== ZADANIE 4: Pętla nieskończona ===");
        Console.WriteLine("Wprowadzaj liczby całkowite. Aby zakończyć, wprowadź liczbę ujemną.\n");
        
        PobierajLiczbyDoUjemnej();
    }
    
    private static void PobierajLiczbyDoUjemnej()
    {
        int licznik = 0;
        
        while (true)
        {
            Console.Write($"Podaj liczbę całkowitą #{licznik + 1}: ");
            
            try
            {
                int liczba = Convert.ToInt32(Console.ReadLine());
                
                if (liczba < 0)
                {
                    Console.WriteLine($"\nWprowadzono liczbę ujemną ({liczba}). Koniec programu.");
                    Console.WriteLine($"Łącznie wprowadzono {licznik} liczb nieujemnych.");
                    break; 
                }
                
                Console.WriteLine($"Wprowadzono: {liczba}");
                licznik++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Nieprawidłowy format. Wprowadź liczbę całkowitą.");
            }
        }
    }
}

