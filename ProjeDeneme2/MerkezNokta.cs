using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDeneme2
{
    internal class MerkezNokta
    {
        public int x
        {
            set
            {
                x = value;
            }
        }
        public int merkezY
        {
            set
            {
                merkezY = value;
            }
        }
        //x ve y atandı
    }

    internal class Cember : MerkezNokta
    {
        public int yaricap
        {
            set
            {
                yaricap = value;
            }
        }
    }
    //r atandı

    internal class Kure : Cember
    {
        public int merkezZ
        {
            set
            {
                merkezZ = value;
            }
        }
    }
    //Kure tamam

    internal class Silindir : Cember
    {
        public int merkezZ
        {
            set
            {
                merkezZ = value;
            }
        }
        public int Yukseklik
        {
            set
            {
                Yukseklik = value;
            }
        }
    }
    //Silindir tamam

    internal class Dortgen : MerkezNokta
    {
        public int boy
        {
            set
            {
                boy = value;
            }
        }
        public int en
        {
            set
            {
                en = value;
            }
        }
    }
    //Dortgen tamam

    internal class DikdortgenPrizma : Dortgen
    {
        public int merkezZ
        {
            set
            {
                merkezZ = value;
            }
        }
        public int derinlik
        {
            set
            {
                derinlik = value;
            }
        }
    }
    //Dikdörtgen prizma tamam
}
