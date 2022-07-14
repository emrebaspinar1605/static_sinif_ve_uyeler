using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı :{0}",Worker.WorkersCount);
            Worker worker= new Worker("Emre","Başpınar","Back-End");
            Console.WriteLine("Çalışan Sayısı :{0}",Worker.WorkersCount);
            Worker worker2= new Worker("Enes","Başpınar","Front-End");
            Worker worker3= new Worker("Osman","Başpınar","CIO");
            Console.WriteLine("Çalışan Sayısı :{0}",Worker.WorkersCount);

            Console.WriteLine("Toplama işleminin Sonucu: {0}"+Calculates.Subs(100,200));
            Console.WriteLine("Çıkarma işleminin Sonucu: {0}"+Calculates.Subs(400,50));

        }
    }
    class Worker
    {
        private static int workersCount;

        public static int WorkersCount { get => workersCount; set => workersCount = value; }
        private string Name;
        private string Surname;
        private string Depart;
        static Worker()
        {
            workersCount=0;
        }
        public Worker(string name, string surname, string depart)
        {
            this.Name=name;
            this.Depart=depart;
            this.Surname=surname;
            workersCount ++;
        }

    }
    static class Calculates
    {
        public static long Subs(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Subtraction(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }      
    }
}