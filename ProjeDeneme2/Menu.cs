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
            double yuzeySayisi;
            string yuzey;

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
                    case 8://nokta silidir
                        Silindir silindir = new Silindir();
                        Merkez3DNokta nokta3 = new Merkez3DNokta();

                        Console.WriteLine("Silindir için merkez X noktası giriniz: ");
                        silindir.merkezX = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Silindir için merkez Y noktası giriniz: ");
                        silindir.merkezY = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Silindir için merkez Z noktası giriniz: ");
                        silindir.merkezZ = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Silindir için boy değeri giriniz: ");
                        silindir.yukseklik = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Silindir için yarıçarp değeri giriniz: ");
                        silindir.yaricap=Double.Parse(Console.ReadLine());

                        Console.WriteLine("Nokta için X noktası giriniz: ");
                        nokta3.merkezX = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Nokta için Y noktası giriniz: ");
                        nokta3.merkezY = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Nokta için Z noktası giriniz: ");
                        nokta3.merkezZ = Double.Parse(Console.ReadLine());

                        cakismaKontrol = CakismaKontrol.noktaSilindir(silindir.merkezX, silindir.merkezY, silindir.merkezZ, silindir.yukseklik, silindir.yaricap, nokta3.merkezX, nokta3.merkezY, nokta3.merkezZ);

                        if (cakismaKontrol)
                        {
                            Console.WriteLine("({0},{1},{2}) merkez noktalı {3} boylu, {4} yarıçaplı silindir ile ({6},{7},{8}) notası birbiri ile çakışmaktadır.", silindir.merkezX, silindir.merkezY, silindir.merkezZ, silindir.yukseklik, silindir.yaricap, nokta3.merkezX, nokta3.merkezY, nokta3.merkezZ);
                        }
                        else
                        {
                            Console.WriteLine("({0},{1},{2}) merkez noktalı {3} boylu, {4} yarıçaplı silindir ile ({6},{7},{8}) notası birbiri ile çakışmamaktadır.", silindir.merkezX, silindir.merkezY, silindir.merkezZ, silindir.yukseklik, silindir.yaricap, nokta3.merkezX, nokta3.merkezY, nokta3.merkezZ);
                        }
                        break;
                    case 9://silindir silindir
                        Silindir silindir1 = new Silindir();
                        Silindir silindir2 = new Silindir();

                        Console.WriteLine("İlk silindir için merkez X noktası giriniz: ");
                        silindir1.merkezX = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İlk silindir için merkez Y noktası giriniz: ");
                        silindir1.merkezY = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İlk silindir için merkez Z noktası giriniz: ");
                        silindir1.merkezZ = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İlk silindir için boy değeri giriniz: ");
                        silindir1.yukseklik = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İlk silindir için yarıçarp değeri giriniz: ");
                        silindir1.yaricap = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci silindir için merkez X noktası giriniz: ");
                        silindir2.merkezX = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci silindir için merkez Y noktası giriniz: ");
                        silindir2.merkezY = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci silindir için merkez Z noktası giriniz: ");
                        silindir2.merkezZ = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci silindir için boy değeri giriniz: ");
                        silindir2.yukseklik = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci silindir için yarıçarp değeri giriniz: ");
                        silindir2.yaricap = Double.Parse(Console.ReadLine());

                        cakismaKontrol = CakismaKontrol.silindirSilindir(silindir1.merkezX, silindir1.merkezY, silindir1.merkezZ, silindir1.yukseklik, silindir1.yaricap, silindir2.merkezX, silindir2.merkezY, silindir2.merkezZ, silindir2.yukseklik, silindir2.yaricap);

                        if (cakismaKontrol)
                        {
                            Console.WriteLine("({0},{1},{2}) merkez noktalı {3} boylu, {4} yarıçaplı silindir ile ({6},{7},{8}) noktalı {9} boylu, {10} yarıçaplı silindir birbiri ile çakışmaktadır.",silindir1.merkezX, silindir1.merkezY, silindir1.merkezZ, silindir1.yukseklik, silindir1.yaricap, silindir2.merkezX, silindir2.merkezY, silindir2.merkezZ, silindir2.yukseklik, silindir2.yaricap);
                        }
                        else
                        {
                            Console.WriteLine("({0},{1},{2}) merkez noktalı {3} boylu, {4} yarıçaplı silindir ile ({6},{7},{8}) noktalı {9} boylu, {10} yarıçaplı silindir birbiri ile çakışmamaktadır.", silindir1.merkezX, silindir1.merkezY, silindir1.merkezZ, silindir1.yukseklik, silindir1.yaricap, silindir2.merkezX, silindir2.merkezY, silindir2.merkezZ, silindir2.yukseklik, silindir2.yaricap);
                        }
                        break;
                    case 10://küre küre
                        Kure kure2 = new Kure();
                        Kure kure3 = new Kure();

                        Console.WriteLine("İlk küre için merkez X noktası giriniz: ");
                        kure2.merkezX = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İlk küre içim merkez Y noktası giriniz: ");
                        kure2.merkezY = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İlk küre için merkez Z noktası giriniz: ");
                        kure2.merkezZ = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İlk küre için yarıçap değeri giriniz: ");
                        kure2.yaricap = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci küre için merkez X noktası giriniz: ");
                        kure3.merkezX = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci küre içim merkez Y noktası giriniz: ");
                        kure3.merkezY = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci küre için merkez Z noktası giriniz: ");
                        kure3.merkezZ = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci küre için yarıçap değeri giriniz: ");
                        kure3.yaricap = Double.Parse(Console.ReadLine());

                        cakismaKontrol = CakismaKontrol.kureKure(kure2.merkezX, kure2.merkezY, kure2.merkezZ, kure2.yaricap, kure3.merkezX, kure3.merkezY, kure3.merkezZ, kure3.yaricap);

                        if (cakismaKontrol)
                        {
                            Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yarıçaplı küre ile ({4},{5},{6}) merkez noktalı, {7} yarıçaplı küre çakışmaktadır.", kure2.merkezX, kure2.merkezY, kure2.merkezZ, kure2.yaricap, kure3.merkezX, kure3.merkezY, kure3.merkezZ, kure3.yaricap);
                        }
                        else
                        {
                            Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yarıçaplı küre ile ({4},{5},{6}) merkez noktalı, {7} yarıçaplı küre çakışmamaktadır.", kure2.merkezX, kure2.merkezY, kure2.merkezZ, kure2.yaricap, kure3.merkezX, kure3.merkezY, kure3.merkezZ, kure3.yaricap);
                        }
                        break;
                    case 11://Küre silindir SONRA DENE

                        break;
                    case 12://küre yüzey
                        Kure kure4 = new Kure();

                        Console.WriteLine("Küre için merkez X noktası giriniz: ");
                        kure4.merkezX = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Küre içim merkez Y noktası giriniz: ");
                        kure4.merkezY = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Küre için merkez Z noktası giriniz: ");
                        kure4.merkezZ = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Küre için yarıçap değeri giriniz: ");
                        kure4.yaricap = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Yüzey hangi eksende olacaktır: ");
                        yuzey = Console.ReadLine();

                        
                        switch (yuzey)
                        {
                            case "x":
                                Console.WriteLine("Yüzey hangi değerde oluşturulacaktır: ");
                                yuzeySayisi = Double.Parse(Console.ReadLine());

                                if (kure4.merkezX+kure4.yaricap<=yuzeySayisi&& kure4.merkezX - kure4.yaricap >= yuzeySayisi)
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yarıçaplı küre ile x eksenli {4} değerli yüzey çakışmaktadır.", kure4.merkezX, kure4.merkezY, kure4.merkezZ, kure4.yaricap,yuzeySayisi);
                                }
                                else
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yarıçaplı küre ile x eksenli {4} değerli yüzey çakışmamaktadır.", kure4.merkezX, kure4.merkezY, kure4.merkezZ, kure4.yaricap, yuzeySayisi);
                                }
                                break;
                            case "y":
                                Console.WriteLine("Yüzey hangi değerde oluşturulacaktır: ");
                                yuzeySayisi = Double.Parse(Console.ReadLine());

                                if (kure4.merkezY + kure4.yaricap  <= yuzeySayisi && kure4.merkezY - kure4.yaricap >= yuzeySayisi)
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yarıçaplı küre ile y eksenli {4} değerli yüzey çakışmaktadır.", kure4.merkezX, kure4.merkezY, kure4.merkezZ, kure4.yaricap, yuzeySayisi);
                                }
                                else
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yarıçaplı küre ile y eksenli {4} değerli yüzey çakışmamaktadır.", kure4.merkezX, kure4.merkezY, kure4.merkezZ, kure4.yaricap, yuzeySayisi);
                                }
                                break;
                            case "z":
                                Console.WriteLine("Yüzey hangi değerde oluşturulacaktır: ");
                                yuzeySayisi = Double.Parse(Console.ReadLine());

                                if (kure4.merkezY + kure4.yaricap <= yuzeySayisi && kure4.merkezY - kure4.yaricap >= yuzeySayisi)
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yarıçaplı küre ile z eksenli {4} değerli yüzey çakışmaktadır.", kure4.merkezX, kure4.merkezY, kure4.merkezZ, kure4.yaricap, yuzeySayisi);
                                }
                                else
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yarıçaplı küre ile z eksenli {4} değerli yüzey çakışmamaktadır.", kure4.merkezX, kure4.merkezY, kure4.merkezZ, kure4.yaricap, yuzeySayisi);
                                }
                                break;
                            default:
                                Console.WriteLine("Geçersiz bir yüzey girdiniz!");
                                break;
                        }                        
                        break;
                    case 13://yüzey dikdörtgen prizma
                        DikdortgenPrizma dikdortgenPrizma2= new DikdortgenPrizma();
                        

                        Console.WriteLine("Küre için merkez X noktası giriniz: ");
                        dikdortgenPrizma2.merkezX = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Küre içim merkez Y noktası giriniz: ");
                        dikdortgenPrizma2.merkezY = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Küre için merkez Z noktası giriniz: ");
                        dikdortgenPrizma2.merkezZ = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Dikdörtgen prizma için en değeri giriniz: ");
                        dikdortgenPrizma2.en = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Dikdörtgen prizma için boy değeri giriniz: ");
                        dikdortgenPrizma2.boy = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Dikdörtgen prizma için derinlik değeri giriniz: ");
                        dikdortgenPrizma2.derinlik= Double.Parse(Console.ReadLine());

                        Console.WriteLine("Yüzey hangi eksende olacaktır: ");
                        yuzey = Console.ReadLine();

                        
                        switch (yuzey)
                        {
                            case "x":
                                Console.WriteLine("Yüzey hangi değerde oluşturulacaktır: ");
                                yuzeySayisi = Double.Parse(Console.ReadLine());

                                if (dikdortgenPrizma2.merkezX + dikdortgenPrizma2.en/2 <= yuzeySayisi && dikdortgenPrizma2.merkezX - dikdortgenPrizma2.en/2 >= yuzeySayisi)
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} enli dikdögen prizma ile x eksenli {4} değerli yüzey çakışmaktadır.", dikdortgenPrizma2.merkezX, dikdortgenPrizma2.merkezY, dikdortgenPrizma2.merkezZ, dikdortgenPrizma2.en, yuzeySayisi);
                                }
                                else
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} enli dikdögen prizma ile x eksenli {4} değerli yüzey çakışmamaktadır.", dikdortgenPrizma2.merkezX, dikdortgenPrizma2.merkezY, dikdortgenPrizma2.merkezZ, dikdortgenPrizma2.en, yuzeySayisi);
                                }
                                break;
                            case "y":
                                Console.WriteLine("Yüzey hangi değerde oluşturulacaktır: ");
                                yuzeySayisi = Double.Parse(Console.ReadLine());

                                if (dikdortgenPrizma2.merkezY + dikdortgenPrizma2.boy / 2 <= yuzeySayisi && dikdortgenPrizma2.merkezY - dikdortgenPrizma2.boy / 2 >= yuzeySayisi)
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} boylu dikdögen prizma ile y eksenli {4} değerli yüzey çakışmaktadır.", dikdortgenPrizma2.merkezX, dikdortgenPrizma2.merkezY, dikdortgenPrizma2.merkezZ, dikdortgenPrizma2.boy, yuzeySayisi);
                                }
                                else
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} boylu dikdögen prizma ile y eksenli {4} değerli yüzey çakışmamaktadır.", dikdortgenPrizma2.merkezX, dikdortgenPrizma2.merkezY, dikdortgenPrizma2.merkezZ, dikdortgenPrizma2.boy, yuzeySayisi);
                                }
                                break;
                            case "z":
                                Console.WriteLine("Yüzey hangi değerde oluşturulacaktır: ");
                                yuzeySayisi = Double.Parse(Console.ReadLine());

                                if (dikdortgenPrizma2.merkezZ + dikdortgenPrizma2.derinlik / 2 <= yuzeySayisi && dikdortgenPrizma2.merkezZ - dikdortgenPrizma2.derinlik / 2 >= yuzeySayisi)
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} derinlikli dikdögen prizma ile z eksenli {4} değerli yüzey çakışmaktadır.", dikdortgenPrizma2.merkezX, dikdortgenPrizma2.merkezY, dikdortgenPrizma2.merkezZ, dikdortgenPrizma2.derinlik, yuzeySayisi);
                                }
                                else
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} derinlikli dikdögen prizma ile z eksenli {4} değerli yüzey çakışmaktadır.", dikdortgenPrizma2.merkezX, dikdortgenPrizma2.merkezY, dikdortgenPrizma2.merkezZ, dikdortgenPrizma2.derinlik, yuzeySayisi);
                                }
                                break;
                            default:
                                Console.WriteLine("Geçersiz bir yüzey girdiniz!");
                                break;
                        }
                        break;
                    case 14:
                        Silindir silindir3 = new Silindir();

                        Console.WriteLine("Küre için merkez X noktası giriniz: ");
                        silindir3.merkezX = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Küre içim merkez Y noktası giriniz: ");
                        silindir3.merkezY = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Küre için merkez Z noktası giriniz: ");
                        silindir3.merkezZ = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Küre için yarıçap değeri giriniz: ");
                        silindir3.yaricap = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Silindir için yükseklik giriniz: ");
                        silindir3.yukseklik = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Yüzey hangi eksende olacaktır: ");
                        yuzey = Console.ReadLine();


                        switch (yuzey)
                        {
                            case "x":
                                Console.WriteLine("Yüzey hangi değerde oluşturulacaktır: ");
                                yuzeySayisi = Double.Parse(Console.ReadLine());

                                if (silindir3.merkezX + silindir3.yaricap <= yuzeySayisi && silindir3.merkezX - silindir3.yaricap >= yuzeySayisi)
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yarıçaplı silindir ile x eksenli {4} değerli yüzey çakışmaktadır.", silindir3.merkezX, silindir3.merkezY, silindir3.merkezZ, silindir3.yaricap, yuzeySayisi);
                                }
                                else
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yarıçaplı silindir ile x eksenli {4} değerli yüzey çakışmamaktadır.", silindir3.merkezX, silindir3.merkezY, silindir3.merkezZ, silindir3.yaricap, yuzeySayisi);
                                }   
                                break;
                            case "y":
                                Console.WriteLine("Yüzey hangi değerde oluşturulacaktır: ");
                                yuzeySayisi = Double.Parse(Console.ReadLine());

                                if (silindir3.merkezY + silindir3.yukseklik/2 <= yuzeySayisi && silindir3.merkezY - silindir3.yukseklik/2 >= yuzeySayisi)
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yükseklikli silindir ile y eksenli {4} değerli yüzey çakışmaktadır.", silindir3.merkezX, silindir3.merkezY, silindir3.merkezZ, silindir3.yukseklik, yuzeySayisi);
                                }
                                else
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yükseklikli silindir ile y eksenli {4} değerli yüzey çakışmamaktadır.", silindir3.merkezX, silindir3.merkezY, silindir3.merkezZ, silindir3.yukseklik, yuzeySayisi);
                                }
                                break;
                            case "z":
                                Console.WriteLine("Yüzey hangi değerde oluşturulacaktır: ");
                                yuzeySayisi = Double.Parse(Console.ReadLine());

                                if (silindir3.merkezY + silindir3.yaricap <= yuzeySayisi && silindir3.merkezY - silindir3.yaricap >= yuzeySayisi)
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yarıçaplı silindir ile z eksenli {4} değerli yüzey çakışmaktadır.", silindir3.merkezX, silindir3.merkezY, silindir3.merkezZ, silindir3.yaricap, yuzeySayisi);
                                }
                                else
                                {
                                    Console.WriteLine("({0},{1},{2}) merkez noktalı, {3} yarıçaplı silindir ile z eksenli {4} değerli yüzey çakışmamaktadır.", silindir3.merkezX, silindir3.merkezY, silindir3.merkezZ, silindir3.yaricap, yuzeySayisi);
                                }
                                break;
                            default:
                                Console.WriteLine("Geçersiz bir yüzey girdiniz!");
                                break;
                        }
                        break;
                    case 15://küre dikdörtgen prizma
                        break;
                    case 16://dikdötgen prizma dikdörtgen prizma
                        DikdortgenPrizma dikdortgenPrizma3 = new DikdortgenPrizma();
                        DikdortgenPrizma dikdortgenPrizma4 = new DikdortgenPrizma();

                        Console.WriteLine("İlk dikdörtgenler prizması için merkez X noktası giriniz: ");
                        dikdortgenPrizma3.merkezX = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İlk dikdörtgenler prizması için merkez Y noktası giriniz: ");
                        dikdortgenPrizma3.merkezY = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İlk dikdörtgenler prizması için merkez Z noktası giriniz: ");
                        dikdortgenPrizma3.merkezZ = Double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("İlk dikdörtgenler prizması için en değeri giriniz: ");
                        dikdortgenPrizma3.en = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İlk dikdörtgenler prizması için boy değeri giriniz: ");
                        dikdortgenPrizma3.boy = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İlk dikdörtgenler prizması için derinlik değerini giriniz: ");
                        dikdortgenPrizma3.derinlik = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci dikdörtgenler prizması için merkez X noktası giriniz: ");
                        dikdortgenPrizma4.merkezX = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci dikdörtgenler prizması için merkez Y noktası giriniz: ");
                        dikdortgenPrizma4.merkezY = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci dikdörtgenler prizması için merkez Z noktası giriniz: ");
                        dikdortgenPrizma4.merkezZ = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci dikdörtgenler prizması için en değeri giriniz: ");
                        dikdortgenPrizma4.en = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci dikdörtgenler prizması için boy değeri giriniz: ");
                        dikdortgenPrizma4.boy = Double.Parse(Console.ReadLine());

                        Console.WriteLine("İkinci dikdörtgenler prizması için derinlik değerini giriniz: ");
                        dikdortgenPrizma4.derinlik = Double.Parse(Console.ReadLine());

                        cakismaKontrol=CakismaKontrol.dikdortgePrizmaDikdortgenPrizma(dikdortgenPrizma3.merkezX, dikdortgenPrizma3.merkezY, dikdortgenPrizma3.merkezZ, dikdortgenPrizma3.en, dikdortgenPrizma3.boy, dikdortgenPrizma3.derinlik, dikdortgenPrizma4.merkezX, dikdortgenPrizma4.merkezY, dikdortgenPrizma4.merkezZ, dikdortgenPrizma4.en, dikdortgenPrizma4.boy, dikdortgenPrizma4.derinlik)

                        break;
                }

            } while (true);

        }
    }
}
