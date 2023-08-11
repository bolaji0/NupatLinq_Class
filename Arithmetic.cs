using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NupatLinq_Class
{
    public class Arithmetic
    {
        public int Add(int num1  , int num2) 
        {
            return num1 + num2; ; 
        }

        public void TodaysDate()
        {
            Console.WriteLine($"Todays date is {DateTime.Now}");
        }

        public static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        public int Subtraction(int num1, int num2) 
        {
            Console.WriteLine(Input(56, 38));
            return num1 - num2;
        }

        private int Input(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
