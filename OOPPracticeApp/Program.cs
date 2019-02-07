using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPPracticeApp.Models;

namespace OOPPracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product();
            //product.ProductName = "Nokia 3310";
            //product.Price = 5000;
            //var abc = "Product is :"+product.ProductName+" & its price is :"+product.Price+"Tk";

            //*****************Method Overloading**********************//
            //It's Compile-time polymorphism, Static Polymorphism, Early to Bind
            //Number of parameters, Order Of Parameters, Dif data type of parameters

            Calculator c = new Calculator();
            int A=c.Add(10 , 15);
            float B=c.Add(10, 15, 20);
            double C=c.Add(10.1, 15.2, 20.3, 25.4);
            var result="the int total is: "+A+"\n the float total is: "+B+"\n the double total is: "+C;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
