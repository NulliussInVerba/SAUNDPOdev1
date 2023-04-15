using System;
using System.ComponentModel.Design;

namespace ProjeDeneme2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool dongu=false;
            Menu menu= new Menu();
            do
            {
                menu.Menuu();

                Console.Write("Tekrardan işlem yapmak istiyor musunuz?(evet/hayır dışında yazdığınız kelimeler hayır olarak algılanacaktır): ");
                string donguKontrol=(Console.ReadLine()).ToLower();

                if (donguKontrol=="evet")
                {
                    dongu = true;
                }
                else
                {
                    dongu = false;
                }
            } while (dongu);
        }

        
    }

}
