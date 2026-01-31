namespace projektowanie_obiektowe.Lab1.Zadanie5;

/// <summary>
/// Zadanie 5: Sortowanie tablicy n liczb
/// </summary>
public static class SortowanieTablicy
{
    /// <summary>
    /// Główna metoda wykonująca zadanie 5
    /// </summary>
    public static void Wykonaj()
    {
        Console.WriteLine("\n=== ZADANIE 5: Sortowanie tablicy ===");
        
        // Pobranie rozmiaru tablicy
        Console.Write("Podaj liczbę elementów tablicy (n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (n <= 0)
        {
            Console.WriteLine("Liczba elementów musi być większa od 0.");
            return;
        }
        
        double[] tablica;
        
        // Wybór sposobu wypełnienia tablicy
        Console.Write("Czy chcesz wprowadzić liczby ręcznie? (t/n): ");
        string? odpowiedz = Console.ReadLine();
        
        if (odpowiedz?.ToLower() == "t")
        {
            // Ręczne wprowadzanie
            tablica = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                tablica[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        else
        {
            // Losowanie liczb
            Console.Write("Podaj dolną granicę przedziału (min): ");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj górną granicę przedziału (max): ");
            double max = Convert.ToDouble(Console.ReadLine());
            
            tablica = LosujTabliceDouble(n, min, max);
        }
        
        // Wyświetlenie tablicy przed sortowaniem
        Console.WriteLine("\n--- Tablica przed sortowaniem ---");
        WyswietlTablice(tablica);
        
        // Wybór metody sortowania
        Console.WriteLine("\nWybierz metodę sortowania:");
        Console.WriteLine("1. Sortowanie bąbelkowe");
        Console.WriteLine("2. Sortowanie przez wstawianie");
        Console.Write("Wybór (1/2): ");
        string? wyborMetody = Console.ReadLine();
        
        if (wyborMetody == "2")
        {
            SortowaniePrzezWstawianie(tablica);
        }
        else
        {
            SortowanieBabelkowe(tablica);
        }
        
        // Wyświetlenie tablicy po sortowaniu
        Console.WriteLine("\n--- Tablica po sortowaniu ---");
        WyswietlTablice(tablica);
    }
    
    /// <summary>
    /// Sortuje tablicę metodą bąbelkową (Bubble Sort)
    /// </summary>
    private static void SortowanieBabelkowe(double[] tablica)
    {
        int n = tablica.Length;
        
        // Pętla zewnętrzna - przejścia przez tablicę
        for (int i = 0; i < n - 1; i++)
        {
            // Flaga sprawdzająca czy nastąpiła zamiana
            bool czyZamiana = false;
            
            // Pętla wewnętrzna - porównywanie sąsiednich elementów
            for (int j = 0; j < n - i - 1; j++)
            {
                // Jeśli element jest większy od następnego, zamieniamy
                if (tablica[j] > tablica[j + 1])
                {
                    // Zamiana elementów
                    double temp = tablica[j];
                    tablica[j] = tablica[j + 1];
                    tablica[j + 1] = temp;
                    czyZamiana = true;
                }
            }
            
            // Jeśli nie było zamiany, tablica jest posortowana
            if (!czyZamiana)
            {
                break;
            }
        }
        
        Console.WriteLine("Zastosowano sortowanie bąbelkowe.");
    }
    
    /// <summary>
    /// Sortuje tablicę metodą przez wstawianie (Insertion Sort)
    /// </summary>
    private static void SortowaniePrzezWstawianie(double[] tablica)
    {
        int n = tablica.Length;
        
        // Pętla od drugiego elementu
        for (int i = 1; i < n; i++)
        {
            // Zapamiętanie bieżącego elementu
            double klucz = tablica[i];
            int j = i - 1;
            
            // Przesuwanie elementów większych od klucza o jedną pozycję w prawo
            while (j >= 0 && tablica[j] > klucz)
            {
                tablica[j + 1] = tablica[j];
                j--;
            }
            
            // Wstawienie klucza na właściwe miejsce
            tablica[j + 1] = klucz;
        }
        
        Console.WriteLine("Zastosowano sortowanie przez wstawianie.");
    }
    
    /// <summary>
    /// Losuje tablicę n liczb double z przedziału [min, max]
    /// </summary>
    private static double[] LosujTabliceDouble(int n, double min, double max)
    {
        // Zamiana granic jeśli min > max
        if (min > max)
        {
            double temp = min;
            min = max;
            max = temp;
            Console.WriteLine($"Zamieniono granice. Nowy przedział: [{min}, {max}]");
        }
        
        var rng = new Random();
        double[] arr = new double[n];
        double zakres = max - min;
        
        for (int i = 0; i < n; i++)
        {
            // NextDouble() -> [0,1), skalujemy do [min, max]
            arr[i] = min + rng.NextDouble() * zakres;
        }
        
        return arr;
    }
    
    /// <summary>
    /// Wyświetla wszystkie elementy tablicy
    /// </summary>
    private static void WyswietlTablice(double[] tablica)
    {
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.WriteLine($"[{i}] = {tablica[i]:F2}");
        }
    }
}

