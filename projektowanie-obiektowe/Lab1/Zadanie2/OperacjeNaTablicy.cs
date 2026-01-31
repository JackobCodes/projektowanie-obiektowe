namespace projektowanie_obiektowe.Lab1.Zadanie2;

/// <summary>
/// Zadanie 2: Operacje na tablicy 10 liczb
/// </summary>
public static class OperacjeNaTablicy
{
    /// <summary>
    /// Główna metoda wykonująca zadanie 2
    /// </summary>
    public static void Wykonaj()
    {
        Console.WriteLine("\n=== ZADANIE 2: Operacje na tablicy 10 liczb ===");
        Console.Write("Czy chcesz wprowadzić liczby ręcznie? (t/n): ");
        string? odpowiedz = Console.ReadLine();
        
        double[] tablica = new double[10];
        
        if (odpowiedz?.ToLower() == "t")
        {
            // Ręczne wprowadzanie liczb
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                tablica[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        else
        {
            // Losowanie liczb z przedziału
            Console.Write("Podaj dolną granicę przedziału (min): ");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj górną granicę przedziału (max): ");
            double max = Convert.ToDouble(Console.ReadLine());
            
            tablica = LosujTabliceDouble(10, min, max);
            
            Console.WriteLine("\nWylosowane liczby:");
            WyswietlTablice(tablica);
        }
        
        // Wywołanie metod obliczających różne wartości
        Console.WriteLine("\n--- Wyniki operacji ---");
        Console.WriteLine($"Suma elementów: {ObliczSume(tablica):F2}");
        Console.WriteLine($"Iloczyn elementów: {ObliczIloczyn(tablica):F2}");
        Console.WriteLine($"Wartość średnia: {ObliczSrednia(tablica):F2}");
        Console.WriteLine($"Wartość minimalna: {ZnajdzMin(tablica):F2}");
        Console.WriteLine($"Wartość maksymalna: {ZnajdzMax(tablica):F2}");
    }
    
    /// <summary>
    /// Oblicza sumę wszystkich elementów tablicy
    /// </summary>
    private static double ObliczSume(double[] tablica)
    {
        double suma = 0;
        foreach (double liczba in tablica)
        {
            suma += liczba;
        }
        return suma;
    }
    
    /// <summary>
    /// Oblicza iloczyn wszystkich elementów tablicy
    /// </summary>
    private static double ObliczIloczyn(double[] tablica)
    {
        double iloczyn = 1;
        foreach (double liczba in tablica)
        {
            iloczyn *= liczba;
        }
        return iloczyn;
    }
    
    /// <summary>
    /// Oblicza wartość średnią elementów tablicy
    /// </summary>
    private static double ObliczSrednia(double[] tablica)
    {
        return ObliczSume(tablica) / tablica.Length;
    }
    
    /// <summary>
    /// Znajduje wartość minimalną w tablicy
    /// </summary>
    private static double ZnajdzMin(double[] tablica)
    {
        double min = tablica[0];
        foreach (double liczba in tablica)
        {
            if (liczba < min)
            {
                min = liczba;
            }
        }
        return min;
    }
    
    /// <summary>
    /// Znajduje wartość maksymalną w tablicy
    /// </summary>
    private static double ZnajdzMax(double[] tablica)
    {
        double max = tablica[0];
        foreach (double liczba in tablica)
        {
            if (liczba > max)
            {
                max = liczba;
            }
        }
        return max;
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

