using Business.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.FirstName = "tugce";
            person1.LastName = "dogan";
            person1.DateOfBirthYear = 1996;
            person1.NationalIdentity = 1;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
           

            //// Degiskenler();
            //Vatandas vatandas= new Vatandas();

            //Console.ReadLine();



        }

        //    private static void Degiskenler()
        //    {
        //        string mesaj = "merhaba";
        //        double tutar = 100000;
        //        int sayi = 100;
        //        bool girisyapmısmi = false;


        //        string ad = "tugce";
        //        string soyad = "dogan";
        //        int dogumyili = 1996;
        //        long tcNo = 12345678910;




        //        Console.WriteLine("tutar*1.8");
        //    }
        //}
        //public class Vatandas
        //{
        //    public string Ad { get; set; }
        //    public string  Soyad { get; set; }
        //    public int DogumYili { get; set; }
        //    public long TcNo { get; set; }
        //}







    }
}