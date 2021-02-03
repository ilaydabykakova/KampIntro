using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Burdaki variables da objedir.
            string adi = "Engin";
            int yas = 36;
            //Kurs diye bir değişken tanımlıyabiliriz.
            //Şu şekilde düşün sanki biz kendi veri tipimizi oluşturuyoruz.(DataTYPES)
            // exp : Kurs kurs1;

            //Bir kurs değişkeni tanımlamak için. kurs1'in tipi Kurs ve birden fazla değişken taşıyorç
            //Burda da class var ve içinde birden fazla özelliklerimiz var.
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;


            //kurs1, kurs2 , kurs3 ,kurs 4 

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }


            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        // 3 tane değişkenimiz var.Tip oluşturduk.
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}


