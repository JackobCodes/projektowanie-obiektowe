namespace projektowanie_obiektowe.Lab1.Zadanie5;

public static class SortowanieTablicy
{

    public static void Wykonaj()
    {
        Console.WriteLine("\n=== ZADANIE 5: Sortowanie tablicy ===");
        
        Console.Write("Podaj liczbę elementów tablicy (n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (n <= 0)
        {
            Console.WriteLine("Liczba elementów musi być większa od 0.");
            return;
        }
        
        double[] tablica;
        
        Console.Write("Czy chcesz wprowadzić liczby ręcznie? (t/n): ");
        string? odpowiedz = Console.ReadLine();
        
        if (odpowiedz?.ToLower() == "t")
        {
            tablica = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                tablica[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        else
        {
            Console.Write("Podaj dolną granicę przedziału (min): ");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj górną granicę przedziału (max): ");
            double max = Convert.ToDouble(Console.ReadLine());
            
            tablica = LosujTabliceDouble(n, min, max);
        }
        
        Console.WriteLine("\n--- Tablica przed sortowaniem ---");
        WyswietlTablice(tablica);
        
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
        
        Console.WriteLine("\n--- Tablica po sortowaniu ---");
        WyswietlTablice(tablica);
    }
    
    private static void SortowanieBabelkowe(double[] tablica)
    {
        int n = tablica.Length;
        
        for (int i = 0; i < n - 1; i++)
        {
            bool czyZamiana = false;
            
            for (int j = 0; j < n - i - 1; j++)
            {
                if (tablica[j] > tablica[j + 1])
                {
                    double temp = tablica[j];
                    tablica[j] = tablica[j + 1];
                    tablica[j + 1] = temp;
                    czyZamiana = true;
                }
            }
            
            if (!czyZamiana)
            {
                break;
            }
        }
        
        Console.WriteLine("Zastosowano sortowanie bąbelkowe.");
    }
    
    private static void SortowaniePrzezWstawianie(double[] tablica)
    {
        int n = tablica.Length;

        for (int i = 1; i < n; i++)
        {
            double klucz = tablica[i];
            int j = i - 1;
            
            while (j >= 0 && tablica[j] > klucz)
            {
                tablica[j + 1] = tablica[j];
                j--;
            }
            
            tablica[j + 1] = klucz;
        }
        
        Console.WriteLine("Zastosowano sortowanie przez wstawianie.");
    }
    
    private static double[] LosujTabliceDouble(int n, double min, double max)
    {
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
            arr[i] = min + rng.NextDouble() * zakres;
        }
        
        return arr;
    }
    
    private static void WyswietlTablice(double[] tablica)
    {
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.WriteLine($"[{i}] = {tablica[i]:F2}");
        }
    }
}

