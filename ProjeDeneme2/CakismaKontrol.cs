using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
        
        public static bool noktaCember(double noktaX, double noktaY, double cemberX, double cemberY, double cemberYaricap)
        {
            double pisagor=Math.Sqrt(noktaX-cemberX)+Math.Sqrt(noktaY-cemberY);
            if (pisagor > cemberYaricap * cemberYaricap)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool dortgenDortgen(double noktaX, double noktaY, double dortgenEn, double dortgenBoy, double nokta2X, double nokta2Y, double dortgen2En, double dortgen2Boy)
        {

            if (Math.Abs(noktaX-nokta2X)==(dortgenEn/2+dortgen2En/2)&& Math.Abs(noktaY - nokta2Y) == (dortgenBoy / 2 + dortgen2Boy / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool dortgenCember(double noktaX, double noktaY, double dortgenEn, double dortgenBoy, double nokta2X, double nokta2Y, double cemberYaricap)
        {
            //FORMÜL HATALI SONRADAN TEKRAR BAK
            
            return true;
        }

        public static bool cemberCember(double noktaX, double noktaY, double cember1Yaricap, double nokta2X, double nokta2Y, double cember2Yaricap)
        {
            if (Math.Sqrt(Math.Pow(noktaX - nokta2X, 2) + Math.Pow(noktaY - nokta2Y,2)) == cember1Yaricap+cember2Yaricap)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool noktaKure(double noktaX, double noktaY, double noktaZ, double kureYaricap, double nokta2X, double nokta2Y, double nokta2Z)
        {
            if (Math.Sqrt(Math.Pow(noktaX-nokta2X,2)+Math.Pow(noktaY-nokta2Y,2)+Math.Pow(noktaZ-nokta2Z,2))>=kureYaricap)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool noktaDikdortgenPrizma(double prizmaX, double prizmaY, double prizmaZ, double prizmaEn, double prizmaBoy, double prizmaDerinlik, double noktaX, double noktaY, double noktaZ)
        {
            if (Math.Abs(prizmaX-noktaX)<prizmaBoy/2&&Math.Abs(prizmaY-noktaY)<prizmaEn/2&&Math.Abs(prizmaZ-noktaZ)<prizmaDerinlik/2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool noktaSilindir(double silindirX, double silindirY, double silindirZ, double silindirYukseklik, double silindirYaricap, double noktaX, double noktaY, double noktaZ)
        {
            if (Math.Abs(silindirY - noktaY) < silindirYukseklik / 2 && Math.Sqrt(Math.Pow(silindirX - noktaX, 2) + Math.Pow(silindirZ - noktaZ, 2))<silindirYaricap)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool silindirSilindir(double silindirX, double silindirY, double silindirZ, double silindirYukseklik, double silindirYaricap, double silindir2X, double silindir2Y, double silindir2Z, double silindir2Yukseklik, double silindir2Yaricap)
        {
            if (Math.Abs(silindirY-silindir2Y)<silindir2Yukseklik+silindirYukseklik&&Math.Sqrt(Math.Pow(silindir2X-silindirX,2)+Math.Pow(silindir2Z-silindirZ,2))<silindir2Yaricap+silindirYaricap)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}
