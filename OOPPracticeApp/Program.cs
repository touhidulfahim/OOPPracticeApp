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

            //*****************Start Method Overloading**********************//
            //It's Compile-time polymorphism, Static Polymorphism, Early to Bind
            //Number of parameters, Order Of Parameters, Dif data type of parameters

            //Calculator c = new Calculator();
            //var A=c.Add(10 , 15);
            //var B=c.Add(10, 15, 20);
            //var C=c.Add(10.1, 15.2, 20.3, 25.4);
            //var result="the total is: "+C;

            //**********************************End Method Overloading*******************************//


            //**********************************Start Method Overriding*******************************//
            Amount am = new Amount();
            double depo = 2000;
            am.Deposit(depo);
            double draw = 4000;
            var b=am.Withdraw(draw);

            ChkAccount chk = new ChkAccount();
            chk.AccountNo = "120-121";
            double dep = 5000;
            chk.Deposit(dep);
            double witd = 50000;
            var result=chk.Withdraw(witd);
            Console.WriteLine(result);
            //**********************************End Method Overriding***********************************//
           
            Console.ReadKey();
        }
    }
}
