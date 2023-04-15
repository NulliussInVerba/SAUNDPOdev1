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
        public static bool noktaDortgen(double noktaX, double noktaY, double dortgenX, double dortgenY, double dortgenEn, double dortgenBoy)
        {
            double dogruY=0, dogruX=0,caseIcin=0;
            double pisagorBir, pisagorIki,egim;
            if ((noktaX - dortgenX)!=0)
            {
                egim = (noktaY - dortgenY) / (noktaX - dortgenX);
            }
            else
            {
                return true;
            }

            pisagorIki =Math.Sqrt((Math.Pow(noktaX - dortgenX,2)+ Math.Pow(noktaY - dortgenY, 2)));

            if (Math.Abs(noktaX - dortgenX) > dortgenEn / 2)
            {
                if (noktaX > dortgenX)
                {
                    dogruY = ((dortgenX + dortgenEn / 2) - dortgenX) * egim + dortgenY;
                    caseIcin=1;
                }
                else
                {
                    dogruY = ((dortgenX - dortgenEn / 2) - dortgenX) * egim + dortgenY;
                    caseIcin = 2;
                }
            }
            else if((noktaY - dortgenY) > dortgenBoy / 2)
            {//HATALI nokta büyükse öbür yden alacağımız x koordinatını bulmaılıyız y değil
                if (noktaY > dortgenY)
                {
                    dogruX = ((dortgenY + dortgenBoy / 2) - dortgenY) / egim + dortgenX;
                    caseIcin = 3;
                }
                else
                {
                    dogruX = ((dortgenY - dortgenBoy / 2) - dortgenY) / egim + dortgenX;
                    caseIcin = 4;
                }
            }

            switch (caseIcin)
            {
                case 1:
                    pisagorBir = Math.Sqrt((Math.Pow(dortgenEn/2, 2) + Math.Pow(dogruY - dortgenY, 2)));
                    if (pisagorIki>pisagorBir)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                    break;
                case 2:
                    pisagorBir = Math.Sqrt((Math.Pow(dortgenEn / 2, 2) + Math.Pow(dogruY - dortgenY, 2)));
                    if (pisagorIki > pisagorBir)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                    break;
                case 3:
                    pisagorBir = Math.Sqrt((Math.Pow(dogruX-dortgenX, 2) + Math.Pow(dortgenBoy/2, 2)));
                    if (pisagorIki > pisagorBir)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                    break;
                case 4:
                    pisagorBir = Math.Sqrt((Math.Pow(dogruX-dortgenX, 2) + Math.Pow(dortgenBoy/2, 2)));
                    if (pisagorIki > pisagorBir)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                    break;
                default:
                    return false;
                    break;
            }
        }
        




        
    }

    
}
