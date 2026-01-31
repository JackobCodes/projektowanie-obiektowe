namespace projektowanie_obiektowe.Lab1.Zadanie3;

public static class LiczbyZWylaczeniami
{
    public static void Wykonaj()
    {
        Console.WriteLine("\n=== ZADANIE 3: Liczby od 20 do 0 z wyłączeniami ===");
        Console.WriteLine("Wyłączone liczby: 2, 6, 9, 15, 19\n");
        
        WyswietlLiczbyZWylaczeniami();
    }
    
    private static void WyswietlLiczbyZWylaczeniami()
    {
        int[] wylaczone = { 2, 6, 9, 15, 19 };
        
        for (int i = 20; i >= 0; i--)
        {
            bool czyWylaczona = false;
            foreach (int liczba in wylaczone)
            {
                if (i == liczba)
                {
                    czyWylaczona = true;
                    break;
                }
            }
            
            if (czyWylaczona)
            {
                continue;
            }
            
            Console.WriteLine(i);
        }
    }
}

