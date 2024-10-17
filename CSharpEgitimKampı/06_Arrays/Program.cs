using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri
            //Dizi : Aynı veri tipindeki çok sayıda veriyi tutmaya çalışan yapılardır.
            //Değişken Türü [] DiziAdı = new DeğişkenTürü[ElemanSayısı] şeklide tanımlanır.

            ////string[] colors = new string[4];
            ////colors[0] = "Kırmızı";
            ////colors[1] = "Sarı";
            ////colors[2] = "Beyaz";
            ////colors[3] = "Mavi";

            ////Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "MİLAN";
            //cities[1] = "BUDAPEŞTE";
            //cities[2] = "LYON";
            //cities[3] = "KAHİRE";
            //cities[4] = "ÜSKÜP";
            //Console.WriteLine(cities[3]);
            ////Console.WriteLine(cities[5]); //5 NOLU yazdıramazsın çünkü sayım 0 dan başlar toplamda beş elemanlıysa en fazla 4 noluyu çıktı alabilrsin

            ////int[] numbers = new int[10];
            ////numbers[0] = 50;
            ////numbers[1] = 48;
            ////numbers[2] = 698;
            ////numbers[3] = 24;
            ////numbers[7] = 748;
            ////Console.WriteLine(numbers[7]);
            //eğer bir indeks değerine atama yapmazsan ve onu çağırırsan default değeriolarak
            //0 gelir yani şuan number[9] çağırırsan değer girmediğin için 0 gelir değer olarak.

            //string[] cities = { "prag", "roma", "atina", "ankara", "bursa" };//Burada bir diğer dizi
            //                                                                 //oluşturma yöntemini kullandık.
            //Console.WriteLine(cities[0]);

            #endregion
            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            ////int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            ////for (int i = 0; i < numbers.Length; i++)
            ////{
            ////    if (numbers[i] % 3 == 0) { Console.WriteLine(numbers[i]); }
            ////}
            ///
            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++) 
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //diizideki en büyük elemanı bulma
            ////int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            ////int maxNumber = myArray[0];

            ////for(int i = 0;  i < myArray.Length; i++) 
            ////{
            ////    if (myArray[i] > maxNumber) 
            ////    { maxNumber = myArray[i];  }
            ////}
            ////Console.WriteLine(maxNumber);

            ////DİZİNİN UZUNLUĞUNU LENGHT METOTU İLE BULURUZ
            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            ////DİZİNİN ELEMANLARINI KÜÇÜKTEN BÜYÜĞE SIRALAR SORT METODU
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35, };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            ////reverse metodu diziyi komple tersten sıralıyo
            //int[] numberss = { 45, 85, 52, 41, 86, 10, 22, 35, };
            //Array.Reverse(numberss);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[ i]);
            //}

            #endregion
            #region Dizi Metodları
            ////aranılan merve kelimesinin hangi index numarasında yer aldığını verir indexof
            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("dizinin en büyük elemanı " + numbers.Max() + " diziinin en küçük değeri" +numbers.Min());

            #endregion
            #region Kullanıcıdan Değer Alma
            //$ işareti çift tırnak içerisinde parametreler kullanmamıza ıolanak sağlayan bir semboldur.
            //string[] cities = new string[5]; 
            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i+1}. Şehri Giriniz:");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------");

            //for (int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            ////int[] numbers = { 10, 20, 30, 40, 50 };
            ////int sum = 0;
            ////for (int i = 0; i < numbers.Length; i++)
            ////{
            ////    sum += numbers[i];
            ////}
            ////Console.WriteLine(sum);
            ///

            //dizideki tek ve çift sayıları sıralayalım
            ////int[] numbers = { 21, 42, 33, 54, 55, 66, 897,758, 39, 220};
            ////Console.WriteLine("Çift sayılar");
            ////Console.WriteLine();
            ////for (int i = 0; i<numbers.Length; i++)
            ////{
            ////    if (numbers[i] % 2 ==0)
            ////    {
            ////        Console.WriteLine(numbers[i]);
            ////    }


            ////}
            ////Console.WriteLine("--------------");
            ////Console.WriteLine("Tek sayılar");
            ////Console.WriteLine();
            ////for (int i = 0; i < numbers.Length; i++)
            ////{
            ////    if (numbers[i] % 2 == 1)
            ////    {
            ////        Console.WriteLine(numbers[i]);
            ////    }


            ////}


            #endregion

            Console.Read();
        }
    }
}
