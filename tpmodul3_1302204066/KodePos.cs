using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204066
{
    internal class KodePos
    {
        public string getKodePos(string kelurahan)
        {
            if (kelurahan == "Batununggal")
            {
                return "40266";
            }
            else if (kelurahan == "Kujangsari")
            {
                return "40287";
            }
            else if (kelurahan == "Mengger")
            {
                return "40267";
            }
            else if (kelurahan == "Wates")
            {
                return "40256";
            }
            else if (kelurahan == "Cijaura")
            {
                return "40287";
            }
            else if (kelurahan == "Jatisari")
            {
                return "40286";
            }
            else if (kelurahan == "Margasari")
            {
                return "40286";
            }
            else if (kelurahan == "Sekejati")
            {
                return "40286";
            }
            else if (kelurahan == "Kebonwaru")
            {
                return "40272";
            }
            else if (kelurahan == "Maleer")
            {
                return "40274";
            }
            else if (kelurahan == "Samoja")
            {
                return "40273";
            }
            else
            {
                return "Tidak tersedia";
            }
        }
    }
}
