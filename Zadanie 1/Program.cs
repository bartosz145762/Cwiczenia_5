﻿using System;

class Program
{
    static void Main()
    {
        Console.Title = "Zadanie 1";

        Console.WriteLine("Algorytm do wypisywania n liczb pierwszych");
        Console.WriteLine();

        Console.WriteLine("Podaj liczbę n:");
        int n = int.Parse(Console.ReadLine());

        int licznik = 0;
        int liczba = 2;

        Console.WriteLine();
        Console.WriteLine($"Pierwsze {n} liczb pierwszych:");
        while (licznik < n)
        {
            if (CzyPierwsza(liczba))
            {
                Console.WriteLine(liczba);
                licznik++;
            }

            liczba++;
        }

        Console.ReadLine();
    }

    static bool CzyPierwsza(int liczba)
    {
        if (liczba < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
                return false;
        }

        return true;
    }
}