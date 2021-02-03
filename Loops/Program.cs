using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);

            //Array - dizi 

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya başlangıç temel kurs" ,"Java","Python"};
           
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            //Dizi temelli yapıları tek tek dönmeye yarıyor.
            //Foreach dizilere uygulanır !
            //Foreach dizileri tek tek dolaşmaya yarıyor. item(alians)
            //Foreach dizileri kolay dolaşmak için kullanırız.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
     
        
        }
    }
}
