using System;

namespace projektowanie_obiektowe.Lab2.Zadanie2
{
    public class BankAccount
    {
        private decimal _saldo;

        public decimal Saldo
        {
            get => _saldo;
        }

        public string Wlasciciel { get; set; }

        public BankAccount(string wlasciciel, decimal saldoPoczatkowe = 0)
        {
            Wlasciciel = wlasciciel;
            _saldo = saldoPoczatkowe;
            Console.WriteLine($"Stworzyłem konto dla {Wlasciciel}, na start masz {_saldo:C}");
        }

        public void Wplata(decimal kwota)
        {
            if (kwota <= 0)
            {
                Console.WriteLine("Nie można wpłacić zera albo liczby ujemnej...");
                return;
            }

            _saldo += kwota;
            Console.WriteLine($"Wpłaciłeś {kwota:C}. Teraz masz: {_saldo:C}");
        }

        public void Wyplata(decimal kwota)
        {
            if (kwota <= 0)
            {
                Console.WriteLine("Nie da się wypłacić ujemnej kwoty!");
                return;
            }

            if (_saldo >= kwota)
            {
                _saldo -= kwota;
                Console.WriteLine($"Wypłaciłeś {kwota:C}. Zostało: {_saldo:C}");
            }
            else
            {
                Console.WriteLine($"Za mało kasy! Masz tylko {_saldo:C}, a próbujesz wypłacić {kwota:C}");
            }
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Konto: {Wlasciciel}, Stan konta: {_saldo:C}");
        }

        public static void Wykonaj()
        {
            Console.WriteLine("\n=== Konto bankowe - testuje ===\n");

            BankAccount konto = new BankAccount("Jan Kowalski", 1000);
            konto.Wplata(500);
            konto.Wyplata(200);
            Console.WriteLine($"Aktualny stan: {konto.Saldo:C}");

            Console.WriteLine("\n--- Próbuję różne rzeczy ---\n");

            konto.Wyplata(2000);

            konto.Wyplata(-100);

            konto.Wplata(-50);

            Console.WriteLine("\nInfo o koncie:");
            konto.WyswietlInformacje();

            Console.WriteLine("\n--- Drugie konto ---\n");
            BankAccount konto2 = new BankAccount("Anna Nowak", 500);
            konto2.Wplata(1000);
            konto2.Wyplata(300);
            konto2.WyswietlInformacje();
        }
    }
}

