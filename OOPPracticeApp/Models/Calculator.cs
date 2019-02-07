using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticeApp.Models
{
    public class Calculator
    {
        //method overloading technique
        public int Add(int a, int b) //same method dif type of two parameters
        {
            return (a + b);
        }
        public float Add(float a, float b, float c) //same method dif type of three parameters
        {
            return (a + b + c);
        }
        public double Add(double a, double b, double c, double d) //same method dif type of four parameters
        {
            return (a + b + c + d);
        }
    }
}
