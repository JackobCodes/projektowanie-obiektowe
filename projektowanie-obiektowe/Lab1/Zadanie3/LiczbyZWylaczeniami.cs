namespace projektowanie_obiektowe.Lab1.Zadanie3;

/// <summary>
/// Zadanie 3: Wyświetlanie liczb od 20 do 0 z wyłączeniami
/// </summary>
public static class LiczbyZWylaczeniami
{
    /// <summary>
    /// Główna metoda wykonująca zadanie 3
    /// </summary>
    public static void Wykonaj()
    {
        Console.WriteLine("\n=== ZADANIE 3: Liczby od 20 do 0 z wyłączeniami ===");
        Console.WriteLine("Wyłączone liczby: 2, 6, 9, 15, 19\n");
        
        WyswietlLiczbyZWylaczeniami();
    }
    
    /// <summary>
    /// Wyświetla liczby od 20 do 0, pomijając liczby {2,6,9,15,19} za pomocą instrukcji continue
    /// </summary>
    private static void WyswietlLiczbyZWylaczeniami()
    {
        // Tablica z liczbami do wyłączenia
        int[] wylaczone = { 2, 6, 9, 15, 19 };
        
        // Pętla od 20 do 0
        for (int i = 20; i >= 0; i--)
        {
            // Sprawdzenie czy liczba jest w tablicy wyłączeń
            bool czyWylaczona = false;
            foreach (int liczba in wylaczone)
            {
                if (i == liczba)
                {
                    czyWylaczona = true;
                    break;
                }
            }
            
            // Jeśli liczba jest wyłączona, pomijamy ją (continue)
            if (czyWylaczona)
            {
                continue;
            }
            
            // Wyświetlenie liczby
            Console.WriteLine(i);
        }
    }
}

