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
            Console.WriteLine("------------ MENCARI KODEPOS KELURAHAN ------------" + "\n");
            Console.WriteLine("Daftar kelurahan yang terssedia: ");
            Console.WriteLine("1. Batununggal   " + " 7. Margasari");
            Console.WriteLine("2. Kujangsari    " + " 8. Sekejati");
            Console.WriteLine("3. Mengger       " + " 9. Kebonwaru");
            Console.WriteLine("4. Wates         " + " 10. Maleer");
            Console.WriteLine("5. Cijaura       " + " 11. Samoja");
            Console.WriteLine("6. Jatisari" + "\n");
            Console.Write("Inputkan nama kelurahan: ");
            string masukan = Console.ReadLine();
            KodePos kodePos = new KodePos();
            Console.WriteLine("Kode Pos: " + kodePos.getKodePos(masukan));
        }
    }
}