using System;

namespace Tugas_Pseudocode1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Pilihan Jasa Kirim Anda: 1=TIKI 2=JNE 3=J&T 4=Anteraja");
            string jasa = Console.ReadLine();
            int i = Convert.ToInt16(jasa);

            switch (jasa) {
                case "1":
                    Console.WriteLine("Anda memilih TIKI");
                    break;
                case "2":
                    Console.WriteLine("Anda memilih JNE");
                    break;
                case "3":
                    Console.WriteLine("Anda memilih J&T");
                    break;
                case "4":
                    Console.WriteLine("Anda memilih Anteraja");
                    break;
                default:
                    Console.WriteLine("Pilihan Anda tidak valid. Pilih 1, 2, 3, atau 4.");
                    break;
            }

            Console.WriteLine("============================================================");
            Console.WriteLine("Masukkan Nama Pengirim");
            String pengirim = Console.ReadLine();
            Console.WriteLine("Nama Pengirim       : " + pengirim);
            Console.WriteLine("Masukkan Nama Penerima");
            String penerima = Console.ReadLine();
            Console.WriteLine("Nama Penerima       : " + penerima);
            Console.WriteLine("Masukkan Alamat Penerima");
            String alamat = Console.ReadLine();
            Console.WriteLine("Alamat Penerima     : " + alamat);
            Console.WriteLine("Barang Yang Akan Dikirim");
            String barang = Console.ReadLine();
            Console.WriteLine("Barang Kiriman      : " + barang);
            Console.WriteLine("Kategori Pengiriman (Reguler,Cepat,Kilat)");
            String katpeng = Console.ReadLine();
            Console.WriteLine("Kategori Pengiriman : " + katpeng);

            if (katpeng == "Reguler")
            {
                Console.WriteLine("Masukkan Berat Barang (KG) ");
                int bb = Convert.ToInt32(Console.ReadLine());
                int b = bb * 3000;
                Console.WriteLine("Berat Barang : " + b + "KG");

                Console.WriteLine("Masukkan Jarak Pengiriman (KM) ");
                int jp = Convert.ToInt32(Console.ReadLine());
                int j = jp * 5000;
                Console.WriteLine("Berat Barang : " + j + "KM");

                int t = b + j;
                Console.WriteLine("Maaf Anda Belum Mendapatkan Diskon Untuk Kategori Reguler");
                Console.WriteLine("============================================================");
                Console.WriteLine("Total Biaya Untuk Pengiriman Ini Adalah: Rp" + t);
            }
            else if (katpeng == "Cepat")
            {
                Console.WriteLine("Masukkan Berat Barang (KG) ");
                int bb = Convert.ToInt32(Console.ReadLine());
                int b = bb * 4000;
                Console.WriteLine("Total Biaya Berat : Rp " + b);

                Console.WriteLine("Masukkan Jarak Pengiriman (KM) ");
                int jp = Convert.ToInt32(Console.ReadLine());
                int j = jp * 6000;
                Console.WriteLine("Total Biaya Jarak Tempuh : Rp" + j);
                int harga = b + j;
                Console.WriteLine("Total Biaya Pengiriman Sebelum Diskon : " + harga);

                Console.WriteLine("Masukkan Total Harga Untuk Mengetahui Diskon");
                int disc = Convert.ToInt32(Console.ReadLine());
                if (disc >= 50000)
                {
                    int disck = (disc * 5 / 100);
                    Console.WriteLine("Selamat, Anda Mendapatkan Diskon Dari Jarak Tempuh Pengiriman Sebesar : Rp " + disck);
                    int t = b + j - disck;
                    Console.WriteLine("============================================================");
                    Console.WriteLine("Total Biaya Untuk Pengiriman Ini Adalah: Rp" + t);
                    Console.WriteLine("Masukkan Uang Pembayaran Anda");
                    int uang = Convert.ToInt32(Console.ReadLine());
                    int tk = uang - t;
                    Console.WriteLine("Total Kembalian Anda Adalah : " + tk);
                }
                else
                {
                    Console.WriteLine("Maaf Inputan Anda Tidak Sesuai");
                }

            }
            else if (katpeng == "Kilat")
            {
                Console.WriteLine("Masukkan Berat Barang (KG) ");
                int bb = Convert.ToInt32(Console.ReadLine());
                int b = bb * 5000;
                Console.WriteLine("Total Biaya Berat : Rp " + b);

                Console.WriteLine("Masukkan Jarak Pengiriman (KM) ");
                int jp = Convert.ToInt32(Console.ReadLine());
                int j = jp * 7000;
                Console.WriteLine("Total Biaya Jarak Tempuh : Rp" + j);
                int harga = b + j;
                Console.WriteLine("Total Biaya Pengiriman Sebelum Diskon : " + harga);

                Console.WriteLine("Masukkan Total Harga Untuk Mengetahui Diskon");
                int disc = Convert.ToInt32(Console.ReadLine());
                if (disc >= 40000)
                {
                    int disck = (disc * 15 / 100);
                    Console.WriteLine("Selamat, Anda Mendapatkan Diskon Dari Jarak Tempuh Pengiriman Sebesar : Rp " + disck);
                    int t = b + j - disck;
                    Console.WriteLine("============================================================");
                    Console.WriteLine("Total Biaya Untuk Pengiriman Ini Adalah: Rp" + t);
                    Console.WriteLine("Masukkan Uang Pembayaran Anda");
                    int uang = Convert.ToInt32(Console.ReadLine());
                    int tk = uang - t;
                    Console.WriteLine("Total Kembalian Anda Adalah : " + tk);
                } else
                {
                    Console.WriteLine("Maaf Inputan Anda Tidak Sesuai");
                }

            } 
        }
    }
}
