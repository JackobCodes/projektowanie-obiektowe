namespace projektowanie_obiektowe.Lab1.Zadanie1;

public static class TrojmianKwadratowy
{
    public static void Wykonaj()
    {
        Console.WriteLine("\n=== ZADANIE 1: Trójmian kwadratowy ===");
        Console.WriteLine("Rozwiązywanie równania: ax² + bx + c = 0");
        
        Console.Write("Podaj współczynnik a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Podaj współczynnik b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Podaj współczynnik c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        
        ObliczPierwiastkiTrojmianu(a, b, c);
    }
    
    private static void ObliczPierwiastkiTrojmianu(double a, double b, double c)
    {
        if (a == 0)
        {
            Console.WriteLine("To nie jest równanie kwadratowe (a = 0)");
            return;
        }
        
        double delta = b * b - 4 * a * c;
        Console.WriteLine($"\nWyróżnik delta = {delta:F2}");
        
        if (delta > 0)
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Delta > 0 - równanie ma dwa różne pierwiastki rzeczywiste:");
            Console.WriteLine($"x1 = {x1:F2}");
            Console.WriteLine($"x2 = {x2:F2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Delta = 0 - równanie ma jeden pierwiastek podwójny:");
            Console.WriteLine($"x = {x:F2}");
        }
        else
        {
            Console.WriteLine("Delta < 0 - równanie nie ma pierwiastków rzeczywistych");
            double czeScRzeczywista = -b / (2 * a);
            double czeScUrojona = Math.Sqrt(-delta) / (2 * a);
            Console.WriteLine($"Pierwiastki zespolone:");
            Console.WriteLine($"x1 = {czeScRzeczywista:F2} - {czeScUrojona:F2}i");
            Console.WriteLine($"x2 = {czeScRzeczywista:F2} + {czeScUrojona:F2}i");
        }
    }
}

