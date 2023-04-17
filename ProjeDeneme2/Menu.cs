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
            do
            {
                switch (secenek)
                {
                    case 1:
                        bool cakismaKontrol;

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

                        break;
                }
            } while (true);

        }
    }
}
