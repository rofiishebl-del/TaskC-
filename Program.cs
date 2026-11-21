using System;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please , Enter your full name : ");
            string full_name = Console.ReadLine();

            Console.Write("Please , Enter product name : ");
            string product_name = Console.ReadLine();

            Console.Write("Please , Enter Unit price: ");
            double UnitPrice=double.Parse( Console.ReadLine());

            Console.Write("Please , Enter Quantity: ");
            int Quantity = int.Parse(Console.ReadLine());

            full_name = full_name.Trim();
            Console.WriteLine($"Customer :  {full_name}");

            Console.WriteLine($"Product : {product_name.ToUpper()} ");

            Console.WriteLine($"Quantity : {Quantity}");

            double subtotal = Quantity * UnitPrice;
            Console.WriteLine($"SubTotal : {subtotal} EGP");

            double tax = subtotal * 0.14;
            Console.WriteLine($"Tax (  14% ) : {tax} EGP");

            double finaltotal = tax + subtotal;
            Console.WriteLine($"Final Total : {finaltotal} EGP");
            if(finaltotal>=500) Console.WriteLine("Free Shipping : True");
            else Console.WriteLine("Free Shipping : False");
           if(full_name.Length>=3) Console.WriteLine($"Promo Code : {full_name.Substring(0,3)+Quantity}");


        }
    }
}
