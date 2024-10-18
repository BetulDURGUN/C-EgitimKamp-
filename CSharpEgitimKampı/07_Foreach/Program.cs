using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            // Foreach(1;2;3;4) 4 adet parametre alır.
            //değişken adı
            // In
            // liste, Koleksiyon, Dizi

            ////string[] cities = {"milano", "roma", "budapeşte", "ankara", "istanbul", "varşova"};

            ////foreach(string x in cities)
            ////{
            ////    Console.WriteLine(x);
            ////}

            ////int[] numbers = { 45,78,985,635,74,11,22,33,41,385,6578,10394 };
            ////foreach(int number in numbers)
            ////{
            ////    Console.WriteLine(number);
            ////}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 385, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {  Console.WriteLine(number); }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 385, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            ////List<int> numbers = new List<int>()
            ////   {
            ////       1,2,3,4,5,8
            ////   };
            ////foreach (int number in numbers)
            ////{
            ////    Console.WriteLine(number);
            ////}
            /////

            //string word = "Merhaba";
            //foreach (char c in word) { Console.WriteLine(c); }



            #endregion
            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("***** C# EĞİTİM KAMPI SINAV UYGULAMASI");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////sınıftaki öğrenci sayısının kullanıcıdan alınması
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("sınıfınızda kaç öğrenci var");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////öğrenci isimleri ve not ortalamalarını saklayacak diziler
            //string[] studentName =new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i=0; i<studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz:");
            //    studentName[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //her öğrenci için 3 sınav notu girişi

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentName[i]} adlı öğrencinin {j+1}. sınav notunu giriniz.");
            //        double value =double.Parse(Console.ReadLine());
            //        totalExamResult += value; //3 sınav notunu burda toplayacağız


            //    }

            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult/3;
            //}

            ////sınav ortalamaları
            //for (int i=0; i<studentCount;i++)
            //{
            //    Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    //öğrencilerin geçip kalma durumu

            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı");
            //    }
            //    Console.WriteLine("--------------") ;
            //}


            #endregion

            Console.Read();

        }
    }
}
