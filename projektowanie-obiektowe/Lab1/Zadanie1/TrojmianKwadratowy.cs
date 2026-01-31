namespace projektowanie_obiektowe.Lab1.Zadanie1;

/// <summary>
/// Zadanie 1: Obliczanie wyróżnika delta i pierwiastków trójmianu kwadratowego
/// </summary>
public static class TrojmianKwadratowy
{
    /// <summary>
    /// Główna metoda wykonująca zadanie 1
    /// </summary>
    public static void Wykonaj()
    {
        Console.WriteLine("\n=== ZADANIE 1: Trójmian kwadratowy ===");
        Console.WriteLine("Rozwiązywanie równania: ax² + bx + c = 0");
        
        // Pobieranie współczynników od użytkownika
        Console.Write("Podaj współczynnik a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Podaj współczynnik b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Podaj współczynnik c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        
        // Wywołanie metody obliczającej deltę i pierwiastki
        ObliczPierwiastkiTrojmianu(a, b, c);
    }
    
    /// <summary>
    /// Oblicza wyróżnik delta i pierwiastki trójmianu kwadratowego
    /// </summary>
    /// <param name="a">Współczynnik przy x²</param>
    /// <param name="b">Współczynnik przy x</param>
    /// <param name="c">Wyraz wolny</param>
    private static void ObliczPierwiastkiTrojmianu(double a, double b, double c)
    {
        // Sprawdzenie czy a != 0 (czy to jest równanie kwadratowe)
        if (a == 0)
        {
            Console.WriteLine("To nie jest równanie kwadratowe (a = 0)");
            return;
        }
        
        // Obliczenie wyróżnika delta = b² - 4ac
        double delta = b * b - 4 * a * c;
        Console.WriteLine($"\nWyróżnik delta = {delta:F2}");
        
        // Analiza rozwiązań w zależności od delty
        if (delta > 0)
        {
            // Dwa różne pierwiastki rzeczywiste
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Delta > 0 - równanie ma dwa różne pierwiastki rzeczywiste:");
            Console.WriteLine($"x1 = {x1:F2}");
            Console.WriteLine($"x2 = {x2:F2}");
        }
        else if (delta == 0)
        {
            // Jeden pierwiastek podwójny
            double x = -b / (2 * a);
            Console.WriteLine($"Delta = 0 - równanie ma jeden pierwiastek podwójny:");
            Console.WriteLine($"x = {x:F2}");
        }
        else
        {
            // Brak pierwiastków rzeczywistych
            Console.WriteLine("Delta < 0 - równanie nie ma pierwiastków rzeczywistych");
            // Opcjonalnie można obliczyć pierwiastki zespolone
            double czeScRzeczywista = -b / (2 * a);
            double czeScUrojona = Math.Sqrt(-delta) / (2 * a);
            Console.WriteLine($"Pierwiastki zespolone:");
            Console.WriteLine($"x1 = {czeScRzeczywista:F2} - {czeScUrojona:F2}i");
            Console.WriteLine($"x2 = {czeScRzeczywista:F2} + {czeScUrojona:F2}i");
        }
    }
}

