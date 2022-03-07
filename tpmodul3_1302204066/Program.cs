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
            Console.Write("Inputkan nama kelurahan: ");
            string i = Console.ReadLine();
            KodePos kodePos = new KodePos();
            Console.WriteLine("Kode Pos: " + kodePos.getKodePos(i) + "\n");
        }
    }
}