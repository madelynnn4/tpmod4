using System;

class Program
{
    static void Main()
    {
        // Tampilkan daftar kode pos
        KodePos.TampilkanDaftarKodePos();

        // Bagian KodePos
        Console.WriteLine("===== Pencarian Kode Pos =====");
        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine($"Kode Pos {kelurahan}: {KodePos.GetKodePos(kelurahan)}\n");

        // Bagian DoorMachine
        Console.WriteLine("===== Mesin Pintu =====");
        DoorMachine door = new DoorMachine();
        while (true)
        {
            Console.WriteLine("\nKetik 'buka' untuk membuka pintu atau 'kunci' untuk mengunci pintu (ketik 'exit' untuk keluar): ");
            string command = Console.ReadLine()?.ToLower();

            if (command == "buka")
                door.BukaPintu();
            else if (command == "kunci")
                door.KunciPintu();
            else if (command == "exit")
                break;
            else
                Console.WriteLine("Perintah tidak dikenali.");
        }
    }
}