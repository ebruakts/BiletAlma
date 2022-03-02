using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletAlma.Models
{
    internal class Bilet
    {

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Telefon { get; set; }

        public string Mail { get; set; }

        public int BiletNo { get; set; }

        public void komutsec(string komutsec, ref Bilet[]koltuklar)
           
        {
            Bilet bilet = new Bilet();
            if (komutsec == "b")
            {
                Console.WriteLine("Lütfen bilet sınıfı seçiniz! " + "Business / B" + " Ekonomi/E");
                string biletsinifi = Console.ReadLine();


                

                switch (biletsinifi)
                    {
                        case "b":
                        for (int i = 0; i < 8; i++)
                        {
                            //Bilet bilet = new Bilet();
                            //koltuklar[i] = bilet;

                            if (koltuklar[i]==null) 
                            { 
                                Console.WriteLine ((i + 1) + " numaralı koltuk boştur!");
                                
                            }
                            else if (koltuklar[i] != null)
                            {
                                Console.WriteLine("Bu sınıfa ait bütün koltuklar doludur!");
                            }

                        }

                        Console.WriteLine("Lütfen koltuk numarası seçiniz!");
                        int koltukNo = int.Parse(Console.ReadLine());

                        if (koltukNo <=8)           
                        {
                            
                                if (koltuklar[koltukNo - 1] == null)
                                {

                                    

                                    Console.WriteLine("Müşteri kaydı oluşturabilirsiniz! ");
                                    Console.WriteLine("Müşteri Adı: ");
                                    bilet.Ad = Console.ReadLine();
                                    Console.WriteLine("Müşteri soyadı: ");
                                    bilet.Soyad = Console.ReadLine();
                                    Console.WriteLine("Müşteri Telefon: ");
                                    bilet.Telefon = Console.ReadLine();
                                    Console.WriteLine("Müşteri Mail: ");
                                    bilet.Mail = Console.ReadLine();
                                    bilet.BiletNo = koltukNo;

                                    koltuklar[koltukNo - 1] = bilet;

                                   
                                }


                        }
                        else if (koltukNo >8 && koltukNo < 30)
                        {
                            Console.WriteLine("Lütfen doğru koltuk numarası giriniz!");

                        }
                        else
                        {
                            Console.WriteLine("Hatalı komut girdiniz!");
                        }

                        break;

                        case "e":
                        for (int i = 8; i <30 ; i++)
                        {
                           

                            if (koltuklar[i] == null)
                            {
                                Console.WriteLine((i + 1) + " numaralı koltuk boştur!");

                            }
                            else if (koltuklar[i] != null)
                            {
                                Console.WriteLine("Bu sınıfa ait bütün koltuklar doludur!");
                            }

                        }

                        Console.WriteLine("Lütfen koltuk numarası seçiniz!");
                        int ekoltukNo = int.Parse(Console.ReadLine());
                        if(ekoltukNo>=9 && ekoltukNo < 30)
                        {
                            if (koltuklar[ekoltukNo - 1] == null)
                            {

                                

                                Console.WriteLine("Müşteri kaydı oluşturabilirsiniz! ");
                                Console.WriteLine("Müşteri Adı: ");
                                bilet.Ad = Console.ReadLine();
                                Console.WriteLine("Müşteri soyadı: ");
                                bilet.Soyad = Console.ReadLine();
                                Console.WriteLine("Müşteri Telefon: ");
                                bilet.Telefon = Console.ReadLine();
                                Console.WriteLine("Müşteri Mail: ");
                                bilet.Mail = Console.ReadLine();
                                bilet.BiletNo = ekoltukNo;

                                koltuklar[ekoltukNo - 1] = bilet;


                            }
                        }
                        else if (ekoltukNo <9)
                        {
                            Console.WriteLine("Lütfen doğru koltuk numarası giriniz!");

                        }
                        else
                        {
                            Console.WriteLine("Hatalı komut girdiniz!");
                        }


                        break;

                } // switch kapandı




            }
            else if (komutsec == "r")
            {
                for (int i = 0; i < koltuklar.Length; i++)
                {
                   
                    string BE = ((i < 8) ? "B" : "E");
                    if (koltuklar[i]==null)
                    { 
                        Console.WriteLine((i + 1) + "-" + BE + "-BOŞ ");
                    }
                    else
                    {
                        Console.WriteLine((i + 1) + "-" + BE + "-DOLU " + Ad + Soyad );
                    }


                }
            }
            else if (komutsec == "exit")
            {
                //bool kullanicidinle = false;
            }
            else
            {
                Console.WriteLine("Hatalı komut girdiniz!");
            }

            }
        }





        
























    }

