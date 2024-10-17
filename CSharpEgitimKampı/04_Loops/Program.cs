using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler

            // for(x(başlangıç);y(bitiş);z(artış-azalış))
            //fordan sonra iki kere taba basarsan otomatik yazar döngüyü
            ////int i;

            ////for ( i = 1; i <= 5; i++)
            ////{
            ////    Console.WriteLine("selam" + i);
            ////}

            //for (int i = 0; i <20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////for (int i = 3; i < 50; i += 3)
            ////{
            ////    Console.WriteLine(i);
            ////}

            //Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz adedi giriniz:");
            //int FinishValue = int.Parse(Console.ReadLine());
            //for (int i = 0; i < FinishValue; i++) { Console.WriteLine("YAŞASIN CUMHURİYET"); }

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////int totalvalue = 0;
            ////for (int i = 1; i <=10; i++)
            ////{
            ////    totalvalue += i;
            ////    Console.WriteLine(totalvalue);
            ////}
            ///

            //int totalvalue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i %2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            // }
            //Console.WriteLine("----------");
            //Console.WriteLine(totalvalue);

            ////int count = 0;
            ////for (int i = 1; i <=50; i++)
            ////{
            ////    if (i % 7 == 0)
            ////    {
            ////        count++;
            ////    }

            ////}
            ////Console.WriteLine(count); //burada 1den 50 ye kadar olan sayılar
            ////                          //içinden 7 ye tam bölünenlerin toplamını
            ////                          //yazdırır.

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda:" + bacterium);

            //}


            #endregion

            #region While Döngüsü


            //while(şart)
            //{
            //    işlemler
            //}

            ////int i = 1;
            ////    while (i <= 10)
            ////{
            ////    Console.WriteLine("Merhaba Döngüler");
            ////    i++;
            ////}

            //int i = 1;
            //while (i <= 10)
            //{ 
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            ////int i = 1;
            ////int sum = 0;
            ////    while (i <= 10)
            ////{
            ////    sum += i;
            ////    i++;
            ////}
            ////    Console.WriteLine(sum);


            #endregion

            #region Örnek Sınav Sorusu
            //klavyeden girilen 3 basamaklı sayının basamakları toplamanı hesapplayan kodu yazınız

            //465

            //Console.Write("Sayıyı Giriniz");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hunderes;
            //int sum;

            //hunderes = number % 100; //100 bölümünden kalan ile yüzler basamağını  buluruz
            //ones = number / 10; // sayının 10 a bölümünden kalan ile birler basamağını buluruz
            //tens = (number % 100) / 10; //onlar basamağını bulduk;

            //Console.WriteLine(ones + "-" + tens + "-" + hunderes);
            //sum = ones + tens + hunderes;
            //Console.WriteLine(sum);

              
            #endregion
            Console.Read();
        }
    }
}
