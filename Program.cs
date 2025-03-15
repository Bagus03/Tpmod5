using System;
using Tpmod5;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("\nSiapa nama anda? ");
        string? nama = Console.ReadLine()?.ToUpper();

        new HaloGeneric().SapaUser(nama);

        Console.Write("\nBerapa NIM anda? ");
        long nim;

        while (!long.TryParse(Console.ReadLine(), out nim))
        {
            Console.Write("Input tidak valid! Masukkan angka: ");
        }

        new DataGeneric<long>(nim).PrintData();
    }
}
