// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine($"Kode Pos {kelurahan}: {KodePos.GetKodePos(kelurahan)}");
    }
}
