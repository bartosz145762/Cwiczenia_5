using System;

class Program
{
    static void Main()
    {
        Console.Title = "Zadanie 2";

        Console.WriteLine("Algorytm wypisujący n liczb parzystych z przedziału [-8,8] dwoma metodami");
        Console.WriteLine();

        Console.WriteLine("Podaj liczbę parzystych liczb do wylosowania (n)");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Metoda 1:");
        Random random = new Random();
        int liczbaLosowan1 = 0;
        int iloscLiczb1 = 0;
        while (iloscLiczb1 < n)
        {
            int liczba = random.Next(-8, 9);
            liczbaLosowan1++;
            if (liczba % 2 == 0)
            {
                Console.Write(liczba);
                iloscLiczb1++;
                if (iloscLiczb1 < n)
                {
                    Console.Write(", ");
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Ilość losowań (metoda 1): " + liczbaLosowan1);

        Console.WriteLine();
        Console.WriteLine("Metoda 2:");
        int liczbaLosowan2 = 0;
        int iloscLiczb2 = 0;
        while (iloscLiczb2 < n)
        {
            int liczba = random.Next(-4, 5) * 2;
            liczbaLosowan2++;
            Console.Write(liczba);
            iloscLiczb2++;
            if (iloscLiczb2 < n)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("Ilość losowań (metoda 2): " + liczbaLosowan2);

        Console.ReadLine();
    }
}
