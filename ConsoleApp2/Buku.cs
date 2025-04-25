using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TampilanAwal
    {
        public void Tampilan()
        {
            Console.WriteLine("Selamat Datang di Manajemen Perpustakaan");
            Console.WriteLine("Silahkan Pilih Menu Untuk Melanjutkan");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(" 1. Tambahkan Buku ");
            Console.WriteLine(" 2. Ubah Data Buku ");
            Console.WriteLine(" 3. Lihat Info Buku ");
            Console.WriteLine(" 4. Simpan Data Buku ");
            Console.WriteLine(" 5. Peminjaman Buku ");
            Console.WriteLine(" 6. Pengembalian Buku ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(" Masukkan Nomor = ");
            Console.ReadLine();
        }
    }

    //class Menu
    //{
    //    public void read()
    //    {
           
    //    }
    //        string (Num) = Console.ReadLine();

    //        switch (Num)
    //        case 1 = Tambahkan Buku
    //        case 2 = Ubah Data Buku
    //        case 3 = Lihat Info Buku
    //        case 4 = Simpan Data Buku
    //        case 5 = Peminjaman Buku
    //        case 6 = Pengembalian Buku
    //        case 7 = END
    //        default = apa coba
    //} 
    
}   

    class BukuFiksi
        {
            private string Penulis = "Andi Irawan";
            private string Kategori = "Fiksi";
        }
 
        class BukuNonfiksi
        {
            private string Penulis = "Aya Vanessa";
            private string Kategori = "Non Fiksi";
        }

        class Buku1 : BukuFiksi
        {
            public string Judul = "Hidup Seekor Kucing Rumah";
            public string TahunTerbit = "2019";
        }

        class Buku2 : BukuFiksi
        {
            public string Judul = "Laut itu Indah";
            public string TahunTerbit = "2020";
        }

// saya menyerah
    