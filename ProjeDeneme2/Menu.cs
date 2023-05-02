using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDeneme2
{
    internal class Menu
    {
        public void Menuu()
        {
            //En son oluşturulacak 
            /*
             * 
             * BURASI MENÜNÜN BİLGİ KISMI
             * 
             */

            int secenek = 1;
            bool cakismaKontrol;

            do
            {
                switch (secenek)
                {
                    case 1://dortgen nokta çakışması

                        MerkezNokta merkez = new MerkezNokta();
                        Dortgen dortgen = new Dortgen();

                        Console.Write("Nokta için X koordinatı giriniz: ");
                        merkez.merkezX = Double.Parse(Console.ReadLine());

                        Console.Write("Nokta için Y koordinatı giriniz: ");
                        merkez.merkezY = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez X koordinatı giriniz: ");
                        dortgen.merkezX = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez Y koordinatı giriniz: ");
                        dortgen.merkezY = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez EN giriniz: ");
                        dortgen.en = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez BOY giriniz: ");
                        dortgen.boy = Double.Parse(Console.ReadLine());

                        Console.Clear();

                        cakismaKontrol = CakismaKontrol.noktaDortgen(merkez.merkezX, merkez.merkezY, dortgen.merkezX, dortgen.merkezY, dortgen.en, dortgen.boy);

                        if (cakismaKontrol)
                        {
                            Console.WriteLine("({0},{1}) noktası ve ({2},{3}) merkezli, eni {4}, boyu {5} olan dörtgen birbiri ile çakışmaktadır", merkez.merkezX, merkez.merkezY, dortgen.merkezX, dortgen.merkezY, dortgen.en, dortgen.boy);
                        }
                        else
                        {
                            Console.WriteLine("({0},{1}) noktası ve ({2},{3}) merkezli, eni {4}, boyu {5} olan dörtgen birbiri ile çakışmamaktadır", merkez.merkezX, merkez.merkezY, dortgen.merkezX, dortgen.merkezY, dortgen.en, dortgen.boy);
                        }

                        break;
                    case 2://nokta çember çakışması
                        MerkezNokta merkez1 = new MerkezNokta();
                        Cember cember = new Cember();

                        Console.Write("Nokta için X koordinatı giriniz: ");
                        merkez1.merkezX = Double.Parse(Console.ReadLine());

                        Console.Write("Nokta için Y koordinatı giriniz: ");
                        merkez1.merkezY = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez X koordinatı giriniz: ");
                        cember.merkezX = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez Y koordinatı giriniz: ");
                        cember.merkezY = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez EN giriniz: ");
                        cember.yaricap = Double.Parse(Console.ReadLine());

                        cakismaKontrol = CakismaKontrol.noktaCember(merkez1.merkezX, merkez1.merkezY, cember.merkezX, cember.merkezY, cember.yaricap);

                        if (cakismaKontrol)
                        {
                            Console.WriteLine("({0},{1}) noktası ve ({2},{3}) merkezli, yaricapi {4} olan çember birbiri ile çakışmaktadır", merkez1.merkezX, merkez1.merkezY, cember.merkezX, cember.merkezY, cember.yaricap);
                        }
                        else
                        {
                            Console.WriteLine("({0},{1}) noktası ve ({2},{3}) merkezli, yaricapi {4} olan çember birbiri ile çakışmamaktadır", merkez1.merkezX, merkez1.merkezY, cember.merkezX, cember.merkezY, cember.yaricap);
                        }
                        break;
                    case 3://dikdörtgen dikdörtgen çakışması
                        Dortgen dortgen1 = new Dortgen();
                        Dortgen dortgen2 = new Dortgen();

                        Console.Write("Dörtgen için merkez X koordinatı giriniz: ");
                        dortgen1.merkezX = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez Y koordinatı giriniz: ");
                        dortgen1.merkezY = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez EN giriniz: ");
                        dortgen1.en = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez BOY giriniz: ");
                        dortgen1.boy = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez X koordinatı giriniz: ");
                        dortgen2.merkezX = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez Y koordinatı giriniz: ");
                        dortgen2.merkezY = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez EN giriniz: ");
                        dortgen2.en = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez BOY giriniz: ");
                        dortgen2.boy = Double.Parse(Console.ReadLine());

                        cakismaKontrol = CakismaKontrol.dortgenDortgen(dortgen1.merkezX, dortgen1.merkezY, dortgen1.en, dortgen1.boy, dortgen2.merkezX, dortgen2.merkezY, dortgen2.en, dortgen2.boy);

                        if (cakismaKontrol)
                        {
                            Console.WriteLine("({0},{1}) merkezli, eni {2}, boyu {3} olan dikdörtgen ile ({4},{5}) merkezli, eni {6}, boyu {7} olan dikdörtgen birbiri ile çakışmaktadır", dortgen1.merkezX, dortgen1.merkezY, dortgen1.en, dortgen1.boy, dortgen2.merkezX, dortgen2.merkezY, dortgen2.en, dortgen2.boy);
                        }
                        else
                        {
                            Console.WriteLine("({0},{1}) merkezli, eni {2}, boyu {3} olan dikdörtgen ile ({4},{5}) merkezli, eni {6}, boyu {7} olan dikdörtgen birbiri ile çakışmamaktadır", dortgen1.merkezX, dortgen1.merkezY, dortgen1.en, dortgen1.boy, dortgen2.merkezX, dortgen2.merkezY, dortgen2.en, dortgen2.boy);
                        }
                        break;
                    case 4://dörtgen çember çakışması
                        Dortgen dortgen3 = new Dortgen();
                        Cember cember1 = new Cember();

                        Console.Write("Dörtgen için merkez X koordinatı giriniz: ");
                        dortgen3.merkezX = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez Y koordinatı giriniz: ");
                        dortgen3.merkezY = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez EN giriniz: ");
                        dortgen3.en = Double.Parse(Console.ReadLine());

                        Console.Write("Dörtgen için merkez BOY giriniz: ");
                        dortgen3.boy = Double.Parse(Console.ReadLine());

                        Console.Write("Çember için merkez X koordinatı giriniz: ");
                        cember1.merkezX = Double.Parse(Console.ReadLine());

                        Console.Write("Çember için merkez Y koordinatı giriniz: ");
                        cember1.merkezY = Double.Parse(Console.ReadLine());

                        Console.Write("Çember için merkez Y koordinatı giriniz: ");
                        cember1.yaricap = Double.Parse(Console.ReadLine());

                        cakismaKontrol = CakismaKontrol.dortgenCember(dortgen3.merkezX, dortgen3.merkezY, dortgen3.en, dortgen3.boy, cember1.merkezX, cember1.merkezY, cember1.yaricap);
                        break;
                    case 5:
                        Cember cember2 = new Cember();
                        Cember cember3 = new Cember();

                        Console.Write("İlk çember için merkez X koordinatı giriniz: ");
                        cember2.merkezX = Double.Parse(Console.ReadLine());

                        Console.Write("İlk çember için merkez Y koordinatı giriniz: ");
                        cember2.merkezY = Double.Parse(Console.ReadLine());

                        Console.Write("İlk çember için merkez Y koordinatı giriniz: ");
                        cember2.yaricap = Double.Parse(Console.ReadLine());

                        Console.Write("İlk çember için merkez X koordinatı giriniz: ");
                        cember3.merkezX = Double.Parse(Console.ReadLine());

                        Console.Write("İlk çember için merkez Y koordinatı giriniz: ");
                        cember3.merkezY = Double.Parse(Console.ReadLine());

                        Console.Write("İlk çember için merkez Y koordinatı giriniz: ");
                        cember3.yaricap = Double.Parse(Console.ReadLine());

                        cakismaKontrol = CakismaKontrol.cemberCember(cember2.merkezX, cember2.merkezY, cember2.yaricap, cember3.merkezX, cember3.merkezY, cember3.yaricap);

                        if (cakismaKontrol)
                        {
                            Console.WriteLine("({0},{1}) merkezli, yarıçapı {2} olan çember ile ({4},{5}) merkezli, yarıçapı {7} olan çember birbiri ile çakışmaktadır", cember2.merkezX, cember2.merkezY, cember2.yaricap, cember3.merkezX, cember3.merkezY, cember3.yaricap);
                        }
                        else
                        {
                            Console.WriteLine("({0},{1}) merkezli, yarıçapı {2} olan çember ile ({4},{5}) merkezli, yarıçapı {7} olan çember birbiri ile çakışmamaktadır", cember2.merkezX, cember2.merkezY, cember2.yaricap, cember3.merkezX, cember3.merkezY, cember3.yaricap);
                        }
                        break;

                    case 6:
                        Merkez3DNokta nokta1= new Merkez3DNokta();
                        Kure kure1=new Kure();

                        Console.WriteLine("Küre için merkez X noktası giriniz: ");
                        kure1.merkezX=Double.Parse(Console.ReadLine());

                        Console.WriteLine("Küre içim merkez Y noktası giriniz: ");
                        kure1.merkezY=Double.Parse(Console.ReadLine());

                        Console.WriteLine("Küre için merkez Z noktası giriniz: ");
                        kure1.merkezZ=Double.Parse(Console.ReadLine());

                        Console.WriteLine("Küre için yarıçap değeri giriniz: ");
                        kure1.yaricap=Double.Parse(Console.ReadLine());

                        Console.WriteLine("Nokta için X noktası giriniz: ");
                        nokta1.merkezX= Double.Parse(Console.ReadLine());

                        Console.WriteLine("Nokta için Y noktası giriniz: ");
                        nokta1.merkezY = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Nokta için Z noktası giriniz: ");
                        nokta1.merkezZ= Double.Parse(Console.ReadLine());

                        cakismaKontrol = CakismaKontrol.noktaKure(kure1.merkezX, kure1.merkezY, kure1.merkezZ, kure1.yaricap, nokta1.merkezX, nokta1.merkezY, nokta1.merkezZ);

                        if (cakismaKontrol)
                        {
                            Console.WriteLine("({0},{1},{2}) merkezli ,{3} yarıçaplı küre ile ({4},{5},{6}) koordinatlı nokta çakışmaktadır",kure1.merkezX,kure1.merkezY,kure1.merkezZ,kure1.yaricap,nokta1.merkezX,nokta1.merkezY,nokta1.merkezZ);
                        }
                        else
                        {
                            Console.WriteLine("({0},{1},{2}) merkezli ,{3} yarıçaplı küre ile ({4},{5},{6}) koordinatlı nokta çakışmamaktadır", kure1.merkezX, kure1.merkezY, kure1.merkezZ, kure1.yaricap, nokta1.merkezX, nokta1.merkezY, nokta1.merkezZ);
                        }
                        break;

                    case 7://notka dikdörtgen prizma
                        Merkez3DNokta nokta2 = new Merkez3DNokta();
                        DikdortgenPrizma dikdortgenPrizma1=new DikdortgenPrizma();

                        Console.WriteLine("Nokta için X noktası giriniz: ");
                        nokta2.merkezX = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Nokta için Y noktası giriniz: ");
                        nokta2.merkezY = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Nokta için Z noktası giriniz: ");
                        nokta2.merkezZ = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Dikdörtgen prizma için merkez X noktası giriniz: ");
                        dikdortgenPrizma1.merkezX=Double.Parse(Console.ReadLine());

                        Console.WriteLine("Dikdörtgen prizma içim merkez Y noktası giriniz: ");
                        dikdortgenPrizma1.merkezY=Double.Parse(Console.ReadLine());

                        Console.WriteLine("Dikdörtgen prizma içim merkez Z noktası giriniz: ");
                        dikdortgenPrizma1.merkezZ=Double.Parse(Console.ReadLine());

                        Console.WriteLine("Dikdörtgen prizma için en giriniz: ");
                        dikdortgenPrizma1.en=Double.Parse(Console.ReadLine());

                        Console.WriteLine("Dikdörtgen prizma içim boy giriniz: ");
                        dikdortgenPrizma1.boy=Double.Parse(Console.ReadLine());

                        Console.WriteLine("Dikdörtgen prizma için derinlik giriniz: ");
                        dikdortgenPrizma1.derinlik=Double.Parse(Console.ReadLine());

                        cakismaKontrol = CakismaKontrol.noktaDikdortgenPrizma(dikdortgenPrizma1.merkezX, dikdortgenPrizma1.merkezY, dikdortgenPrizma1.merkezZ, dikdortgenPrizma1.en, dikdortgenPrizma1.boy, dikdortgenPrizma1.derinlik, nokta2.merkezX, nokta2.merkezY, nokta2.merkezZ);

                        if (cakismaKontrol)
                        {
                            Console.WriteLine("({0},{1},{2}) merkez noktalı {3} enli, {4} boylu, {5} derinlikli dikdörgen prizma ile ({6},{7},{8}) notası birbiri ile çakışmaktadır.", dikdortgenPrizma1.merkezX, dikdortgenPrizma1.merkezY, dikdortgenPrizma1.merkezZ, dikdortgenPrizma1.en, dikdortgenPrizma1.boy, dikdortgenPrizma1.derinlik, nokta2.merkezX, nokta2.merkezY, nokta2.merkezZ);
                        }
                        else
                        {
                            Console.WriteLine("({0},{1},{2}) merkez noktalı {3} enli, {4} boylu, {5} derinlikli dikdörgen prizma ile ({6},{7},{8}) notası birbiri ile çakışmaktadır.", dikdortgenPrizma1.merkezX, dikdortgenPrizma1.merkezY, dikdortgenPrizma1.merkezZ, dikdortgenPrizma1.en, dikdortgenPrizma1.boy, dikdortgenPrizma1.derinlik, nokta2.merkezX, nokta2.merkezY, nokta2.merkezZ);
                        }
                        break;
                    case 8:

                        break;
                }

            } while (true);

        }
    }
}
