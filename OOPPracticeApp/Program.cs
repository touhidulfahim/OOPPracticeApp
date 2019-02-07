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
            Product product = new Product();
            product.ProductName = "Nokia 3310";
            product.Price = 5000;
            var abc = "Product is :"+product.ProductName+" & its price is :"+product.Price+"Tk";
            Console.WriteLine(abc);
            Console.ReadKey();
        }
    }
}
