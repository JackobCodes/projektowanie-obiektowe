namespace projektowanie_obiektowe.Lab1.Zadanie4;

/// <summary>
/// Zadanie 4: Pętla nieskończona przerywana instrukcją break
/// </summary>
public static class PetlaNieskonczona
{
    /// <summary>
    /// Główna metoda wykonująca zadanie 4
    /// </summary>
    public static void Wykonaj()
    {
        Console.WriteLine("\n=== ZADANIE 4: Pętla nieskończona ===");
        Console.WriteLine("Wprowadzaj liczby całkowite. Aby zakończyć, wprowadź liczbę ujemną.\n");
        
        PobierajLiczbyDoUjemnej();
    }
    
    /// <summary>
    /// W pętli nieskończonej pobiera liczby od użytkownika, kończy działanie gdy liczba < 0
    /// </summary>
    private static void PobierajLiczbyDoUjemnej()
    {
        int licznik = 0;
        
        // Pętla nieskończona - while(true)
        while (true)
        {
            Console.Write($"Podaj liczbę całkowitą #{licznik + 1}: ");
            
            // Obsługa błędów przy konwersji
            try
            {
                int liczba = Convert.ToInt32(Console.ReadLine());
                
                // Warunek przerwania pętli - liczba ujemna
                if (liczba < 0)
                {
                    Console.WriteLine($"\nWprowadzono liczbę ujemną ({liczba}). Koniec programu.");
                    Console.WriteLine($"Łącznie wprowadzono {licznik} liczb nieujemnych.");
                    break; // Wyjście z pętli nieskończonej
                }
                
                // Informacja o wprowadzonej liczbie
                Console.WriteLine($"Wprowadzono: {liczba}");
                licznik++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Nieprawidłowy format. Wprowadź liczbę całkowitą.");
            }
        }
        
        /* Alternatywna implementacja z pętlą for(;;)
        int licznik = 0;
        for (;;) // Pętla nieskończona - for(;;)
        {
            Console.Write($"Podaj liczbę całkowitą #{licznik + 1}: ");
            int liczba = Convert.ToInt32(Console.ReadLine());
            
            if (liczba < 0)
            {
                Console.WriteLine($"\nWprowadzono liczbę ujemną ({liczba}). Koniec programu.");
                break;
            }
            
            Console.WriteLine($"Wprowadzono: {liczba}");
            licznik++;
        }
        */
    }
}

