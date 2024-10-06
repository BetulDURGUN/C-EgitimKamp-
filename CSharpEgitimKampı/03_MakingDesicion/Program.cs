using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03_MakingDesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else Örnekler


            //Console.Write("Lütfen şifreyi giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "1234")
            //{
            //    Console.WriteLine("Şifre Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            ////karar yapılarında birden fazla şart verilebilir.
            //string capital, country;
            //Console.WriteLine("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            ////& bu c#da ve anlamına gelir.
            //if(capital=="ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");

            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if(number==5) 
            //{
            //Console.WriteLine("SAYI DOĞRU");           
            //}
            //else
            //{
            //    Console.WriteLine("HATALI SAYI GİRDİNİZ.");
            //}

            //double exam1, exam2, exam3, average;
            //string result = "HATA";

            //Console.WriteLine("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların Ortalaması:" + average);

            //if (average > 0 & average <= 50)

            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç  İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yaparız.");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "trabzon")
            //{

            //    Console.Write("şehir mevcut");
            //}
            //else
            //{
            //    Console.Write("Şehir mevcut değil");
            //}

            //Console.WriteLine("Lütfen kullanıcı adı giriniz:");
            //string username =Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.Write("hoş geldiniz");
            //}








            //Console.Read();
            #endregion

            #region MOD İŞLEMLERİ
            // mod alma işlemi (yüzde)% sembolü ile gösterilir.
            //<--
            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine("sonuc:" +result);
            //--->


            //<--
            //Console.Write("Lütfen 1. sayıyı giriniz:");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. Sayının 2. sayıya bölümünden kalan:" + result);

            //-->

            //<--
            //Console.Write("Lütfen sayıyı giriniz:");
            //int  number =int.Parse(Console.ReadLine());

            //if (number %2== 0) 
            //{ 
            //Console.Write("Sayı Çifttir");

            //}

            //else
            //{
            //    Console.Write("Sayı tektir.");
            //}
            //-->
            #endregion

            #region CHAR Değişkenler ile Karar Yapıları
            // <--
            //char team;

            //Console.Write("Lütfen takım sembolünü giriniz.");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("GALATASARAY");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş"); ;
            //}

            //-->
            #endregion


            #region Örnek Proje Uygulaması
          //  Console.WriteLine("****** C# Eğitim Kampı Restoran ****** ");
          //  Console.WriteLine();
          //  Console.WriteLine("-----------------");
          //  Console.WriteLine("1-Ana Yemekler");
          //  Console.WriteLine("2-Çorbalar");
          //  Console.WriteLine("3-Pizzalar");
          //  Console.WriteLine("4-İçecekler");
          //  Console.WriteLine("5-İçecekler");
          //  Console.WriteLine("-----------------");

          //  string menuItem;
          //  Console.Write("Detayını Görmek İstediğiniz menü seçimi: ");
          //  menuItem = Console.ReadLine();
          //  if (menuItem == "1")
          //  {
          //      Console.WriteLine();
          //      Console.WriteLine("------------Ana Yemekler------------");
          //      Console.WriteLine();
          //      Console.WriteLine("1-Köri soslu tavuk");
          //      Console.WriteLine("2-Kızartma Tabağı");
          //      Console.WriteLine("3-Fasulye Pilav");
          //      Console.WriteLine("4-Fırında Somon");
          //      Console.WriteLine("5-Patlıcan Musakka");
          //      Console.WriteLine("------------Ana Yemekler------------");
          //      Console.WriteLine();

          //  }
          //  if (menuItem == "2")
          //  {
          //      Console.WriteLine();
          //      Console.WriteLine("------------Çorbalar------------");
          //      Console.WriteLine();
          //      Console.WriteLine("1-Mercimek çorbası");
          //      Console.WriteLine("2-ezogelin çorbası");
          //      Console.WriteLine("------------Çorbalar------------");

          //      Console.WriteLine();

          //  }
          //  if(menuItem == "3") 
          //  {
          //      Console.WriteLine();
          //      Console.WriteLine("------------Pizzalar------------");
          //      Console.WriteLine();
          //      Console.WriteLine("1-Akdeniz Pizzası");
          //      Console.WriteLine("2-Margaritha");
          //      Console.WriteLine("3-Tavuklu Pizza");
          //      Console.WriteLine("------------Pizzalar------------");

          //      Console.WriteLine();

          //  }
          //if(menuItem == "4")
          //  {
          //      Console.WriteLine();
          //      Console.WriteLine("------------İçecekler------------");
          //      Console.WriteLine();
          //      Console.WriteLine("1-Kola");
          //      Console.WriteLine("2-Ayran");
          //      Console.WriteLine("3-Su");
          //      Console.WriteLine("------------İçecekler------------");

          //      Console.WriteLine();

          //  }

          //  if (menuItem == "5")
          //  {
          //      Console.WriteLine();
          //      Console.WriteLine("------------Tatlılar------------");
          //      Console.WriteLine();
          //      Console.WriteLine("1-Triliçe");
          //      Console.WriteLine("2-KAZANDİBİ");
          //      Console.WriteLine("3-SÜTLAÇ");
          //      Console.WriteLine("------------Tatlılar------------");

          //      Console.WriteLine();

          //  }

          //  Console.ReadLine();
            #endregion

            #region SWİTCH CASE(KARAR YAPILARINDA FAZLA ŞARTLAR

            //SWİTCH KOD BLOĞUNUN ANAHTAR KSIMIDIR CASE İSE ANAHTARIN DURUMLARIDIR.
            //<---
            //Console.Write("Lütfen ay girişini yapınız:");
            //int monthNumber=int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.Write("OCAK"); break;
            //    case 2:Console.Write("ŞUBAT"); break;
            //    case 3: Console.Write("MART"); break;
            //    case 4: Console.Write("NİSAN"); break;
            //    case 5: Console.Write("MAYIS"); break;
            //    case 6: Console.Write("HAZİRAN"); break;
            //    case 7: Console.Write("TEMMUZ"); break;
            //    case 8: Console.Write("AĞUSTOS"); break;
            //    case 9: Console.Write("EYLÜL"); break;
            //    case 10: Console.Write("EKİM"); break;
            //    case 11: Console.Write("KASIM"); break;
            //    case 12: Console.Write("ARALIK"); break;
            //    default:Console.Write("HATALI VERİ GİRİŞİ"); break;
            //}

            //--->

            #endregion

            #region HESAP MAKİNESİ ÖRNEĞİ

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1. sayıyı giriniz:"); 
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz:");
            //number2=int.Parse(Console.ReadLine());

            //Console.Write("lÜTFEN YAPMAK İSTEDİĞİNİZ İŞLEMİ GİRİNİZ.");
            //symbol=char.Parse(Console.ReadLine());

            

            //switch (symbol)
            //{
            //    case '+':
            //        result =number1+number2;
            //        Console.WriteLine("toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("bölüm: " + result);
            //        break;


            //}

            #endregion 

<<<<<<< HEAD
            
=======

>>>>>>> 1ef29cd64e93e3c0304f5f309d4350cb3038703f
            Console.ReadLine();
        }
    }
}