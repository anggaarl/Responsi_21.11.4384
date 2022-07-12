using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Console.Clear();
            int kodeNota;
            string tanggal, nama, tipe1;
            string tipe2 = "error";
            int total;

            Console.WriteLine("Tambah Data Penjualan");
            Console.WriteLine("");
            Console.Write("Nota       : ");
            kodeNota = int.Parse(Console.ReadLine());

            Console.Write("Tanggal    : ");
            tanggal = Console.ReadLine();

            Console.Write("Customer    : ");
            nama = Console.ReadLine();

            Console.Write("Jenis [T/K]: ");
            tipe1 = Console.ReadLine();

            Console.Write("Total Nota : ");
            total = int.Parse(Console.ReadLine());

            if (tipe1 == "Tunai" || tipe1 == "T")
            {
                tipe2 = "Tunai";
            }
            if (tipe1 == "K" || tipe1 == "k")
            {
                tipe2 = "kredit";
            }
            daftarPenjualan.Add(new Penjualan() { Code = kodeNota, Tanggal = tanggal, Nama = nama, Jenis = tipe2, Total = total });

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            Console.Clear();
            Console.WriteLine("Data Penjualan");
            Console.WriteLine("");
            int no = 1;
            foreach (Penjualan daftar in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                no, daftar.Code, daftar.Tanggal, daftar.Nama, daftar.Jenis, daftar.Total);
                no++;
            }

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
