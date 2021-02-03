using System;

namespace LoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.CategoryId = 1;
            product1.CategoryName = "Kadın";
            product1.ProductId = 1;
            product1.ProductName = "Elbise";
            product1.ucret = 29.99;
            product1.stoksayisi = 120;


            Product product2 = new Product();
            product2.CategoryId = 2;
            product2.CategoryName = "Erkek";
            product2.ProductId = 1;
            product2.ProductName = "Ceket";
            product2.ucret = 59.99;
            product2.stoksayisi = 60;

            Product product3 = new Product();
            product3.CategoryId = 2;
            product3.CategoryName = "Erkek";
            product3.ProductId = 3;
            product3.ProductName = "Ayakkabı";
            product3.ucret = 70.00;
            product3.stoksayisi = 40;

            Product[] products = new Product[] { product1, product2 ,product3 };
            //FOR LOOP 
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].CategoryName + " : \n" + products[i].ProductName +
                    "(Kalan ürün : " + products[i].stoksayisi + ")" + "= " + products[i].ucret + " tl");
            }
            //WHİLE LOOP
            /* int i = 0;
            while (products != null )
            {
                Console.WriteLine(products[i].CategoryName + " : \n" + products[i].ProductName +
                    "(Kalan ürün : " + products[i].stoksayisi + ")" + "= " + products[i].ucret + " tl");
                i++;
            }*/
             
            //FOREACH LOOP 
            /*foreach (var urun in products)
            {
                Console.WriteLine(urun.CategoryName + " : \n" +urun.ProductName+
                    "(Kalan ürün : "+urun.stoksayisi+")"+ "= "+urun.ucret+" tl");
            }
  */
        }
    }


    class Product
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ucret { get; set; }
        public int stoksayisi { get; set; }
    }
}
