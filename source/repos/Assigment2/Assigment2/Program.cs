using System;

namespace Assigment2
{
    class Program
    {
        static void Main(string[] args)
        {
         
           List<String>list = new List<string>();
            list.add('1');
           Product produc1 = new Product(1,"IphoneX",123232,2,"image1","Day la iphoneX","Test",list,1);
            //ADd spam
            Cart cart = new Cart();
            //
            cart.AddProduct(produc1);
                cart.removeProduct(1);


        }
    }
}
