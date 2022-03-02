using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiletAlma.Models;

namespace BiletAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {


          Console.WriteLine("Uçak Bileti Satış Uygulaması");
          Bilet blt = new Bilet();

            Bilet[] koltuklar = new Bilet[30];

            bool kullanicidinle = true;

            while (kullanicidinle==true)
            {
                Console.WriteLine("Bilet satış için: B" + " Rapor için: R" + " Çıkış için: Exit");
                string komut = Console.ReadLine();
                blt.komutsec(komut,ref koltuklar);


            }











        }
    }
}
