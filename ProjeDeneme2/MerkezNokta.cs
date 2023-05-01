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
        public double _merkezX, _merkezY;
        public double merkezX
        {
            get
            {
                return _merkezX;
            }
            set
            {
                _merkezX = value;
            }
        }
        public double merkezY
        {
            get
            {
                return _merkezY;
            }
            set
            {
                _merkezY = value;
            }
        }
        //x ve y atandı
    }

    internal class Merkez3DNokta:MerkezNokta
    {
        public double _merkezZ;
        public double merkezZ
        {
            get
            {
                return _merkezZ;
            }
            set
            {
                _merkezZ = value;
            }
        }
    }

    internal class Cember : MerkezNokta
    {
        public double _yaricap;
        public double yaricap
        {
            get
            {
                return _yaricap;
            }
            set
            {
                _yaricap = value;
            }
        }
    }
    //r atandı

    internal class Kure : Cember
    {
        public double _merkezZ;
        public double merkezZ
        {
            get
            {
                return _merkezZ;
            }
            set
            {
                _merkezZ = value;
            }
        }
    }
    //Kure tamam

    internal class Silindir : Cember
    {
        public double _merkezZ;
        public double _yukseklik;
        public double merkezZ
        {
            get
            {
                return _merkezZ;
            }
            set
            {
                _merkezZ = value;
            }
        }
        public double yukseklik
        {
            get
            {
                return _yukseklik;
            }
            set
            {
                _yukseklik = value;
            }
        }
    }
    //Silindir tamam

    internal class Dortgen : MerkezNokta
    {
        public double _boy;
        public double _en;
        public double boy
        {
            get
            {
                return _boy;
            }
            set
            {
                _boy = value;
            }
        }
        public double en
        {
            get
            {
                return _en;
            }
            set
            {
                _en = value;
            }
        }
    }
    //Dortgen tamam

    internal class DikdortgenPrizma : Dortgen
    {
        public double _merkezZ;
        public double _derinlik;
        public double merkezZ
        {
            get
            {
                return _merkezZ;
            }
            set
            {
                _merkezZ = value;
            }
        }
        public double derinlik
        {
            get
            {
                return _derinlik;
            }
            set
            {
                _derinlik = value;
            }
        }
    }
    //Dikdörtgen prizma tamam
}
