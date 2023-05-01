using System;
using System.Collections.Generic;
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
                            Console.WriteLine("({0},{1}) merkezli, eni {2}, boyu {3} olan dikdörtgen ile ({4},{5}) merkezli, eni {6}, boyu {7} olan dikdörtgen birbiri ile çakışmaktadır", dortgen1.merkezX, dortgen1.merkezY, dortgen1.en, dortgen1.boy, dortgen2.merkezX, dortgen2.merkezY,dortgen2.en,dortgen2.boy);
                        }
                        else
                        {
                            Console.WriteLine("({0},{1}) merkezli, eni {2}, boyu {3} olan dikdörtgen ile ({4},{5}) merkezli, eni {6}, boyu {7} olan dikdörtgen birbiri ile çakışmamaktadır", dortgen1.merkezX, dortgen1.merkezY, dortgen1.en, dortgen1.boy, dortgen2.merkezX, dortgen2.merkezY, dortgen2.en, dortgen2.boy);
                        }
                        break;
                    case 4://dörtgen çember çakışması
                        break;
                }
            } while (true);

        }
    }
}
