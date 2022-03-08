/*
Nama        : Mohamad Lutfi
NIM         : 1302204066
Kelas       : SE-44-02
 */

using System;

namespace tpmodul3_1302204066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ MENCARI KODEPOS KELURAHAN ------------");
            Console.WriteLine("Daftar kelurahan yang terssedia: ");
            Console.WriteLine("1. Batununggal   " + " 7. Margasari");
            Console.WriteLine("2. Kujangsari    " + " 8. Sekejati");
            Console.WriteLine("3. Mengger       " + " 9. Kebonwaru");
            Console.WriteLine("4. Wates         " + " 10. Maleer");
            Console.WriteLine("5. Cijaura       " + " 11. Samoja");
            Console.WriteLine("6. Jatisari");

            Console.Write("Masukkan nama kelurahan: ");
            string masukan = Console.ReadLine();
            if (masukan == "")
            {
                Console.Write("*Anda tidak memasukkan nama kelurahan" + "\n");
            }

            KodePos kodePos = new KodePos();
            Console.WriteLine("Kode Pos: " + kodePos.getKodePos(masukan) + "\n");

            Console.WriteLine("------------------ MESIN PINTU ------------------");
            Console.Write("Kondisi saat ini: ");
            DoorMachine pintu = new DoorMachine();

            Console.Write("Masukkan aksi (Buka/Kunci): ");
            String masukan2 = Console.ReadLine();
            if (masukan2 == "Buka")
            {
                Console.Write("Kondisi saat ini: ");
                pintu.BukaPintu();
            }
            else if (masukan2 == "Kunci")
            {
                Console.Write("Kondisi saat ini: ");
                pintu.KunciPintu();
            }
            else
            {
                Console.Write("*Aksi yang anda masukkan salah" + "\n");
            }
        }
    }
}