using System;

class Program
{
    static void Main()
    {
        Console.Title = "Zadanie 3";

        Console.WriteLine("Program do rysowania trójkąta z plusów o wysokości podanej przez użytkownika");
        Console.WriteLine();

        Console.WriteLine("Podaj wysokość trójkąta: ");
        int wysokosc = Convert.ToInt32(Console.ReadLine());

        int szerokosc = wysokosc * 2 - 1;
        int poczatkowaPozycja = (Console.WindowWidth - szerokosc) / 2;

        for (int i = 0; i < wysokosc; i++)
        {
            int iloscZnakow = i * 2 + 1;
            int pozycja = poczatkowaPozycja + (szerokosc - iloscZnakow) / 2;

            Console.SetCursorPosition(pozycja, Console.CursorTop);
            string linia = new string('+', iloscZnakow);
            Console.WriteLine(linia);
        }

        Console.ReadLine();
    }
}