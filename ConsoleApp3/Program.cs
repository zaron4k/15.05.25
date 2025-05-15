using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        public static double MinNumber(double a, double b)
        {
            return a < b ? a : b;
        }
        public static double MaxNumber(double a, double b)
        {
            return a > b ? a : b;
        }
        delegate double CompareNumbers(double a, double b);
        static void Main(string[] args)
        {
            CompareNumbers minNumber = new CompareNumbers(MinNumber);

            CompareNumbers maxNumber = new CompareNumbers(MaxNumber);

            double num1 = 3.7;
            double num2 = 5.6;
            Console.WriteLine("Наименьшое число :" + minNumber(num1,num2));
            Console.WriteLine("Наибольшее число :" + maxNumber(num1,num2));
            Console.Read();
        }
    }
}
