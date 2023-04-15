using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDeneme2
{
    public static class CakismaKontrol
    {
        //Nokta Dörtgen Çakışma Kontrolü
        public static bool noktaDortgen(int noktaX, int noktaY, int dortgenX, int dortgenY, int dortgenEn, int dortgenBoy)
        {
            int dogruY, pisagorBir, pisagorIki,dogruX;
            int egim = (noktaY - dortgenY) / (noktaX - dortgenX);
            bool noktaXbuyuk, noktaYBuyuk;

            if (Math.Abs(noktaX - dortgenX) > dortgenEn / 2)
            {
                if (noktaX > dortgenX)
                {
                    dogruY = ((dortgenX + dortgenEn / 2) - dortgenX) * egim + dortgenY;
                }
                else
                {
                    dogruY = ((dortgenX - dortgenEn / 2) - dortgenX) * egim + dortgenY;
                }
            }
            else if((noktaY - dortgenY) > dortgenBoy / 2)
            {//HATALI nokta büyükse öbür yden alacağımız x koordinatını bulmaılıyız y değil
                if (noktaY > dortgenY)
                {
                    dogruX = ((dortgenY + dortgenBoy / 2) - dortgenY) / egim + dortgenX;
                }
                else
                {
                    dogruX = ((dortgenY - dortgenBoy / 2) - dortgenY) / egim + dortgenX;
                }
            }
            else
            {
                Console.WriteLine("Çakışma Vardır");
            }


            return true;
        }
    }
}
