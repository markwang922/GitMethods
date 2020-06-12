using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitMethods
{
    class Program
    {
        internal int i, j;

        public void AccpetDetails()
        {
            //input numbers
            Console.WriteLine("Please enter 1 number:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            j = Convert.ToInt32(Console.ReadLine());
        }

        public void MaxNumber() // Show max number method
        {
            if (i > j)
            {
                Console.WriteLine("Max number is {0}", i);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Max number is {0}", j);
                Console.ReadLine();
            }
        }

        public void MinNumber() // Show min number method
        {
            if (i < j)
            {
                Console.WriteLine("Max number is {0}", i);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Max number is {0}", j);
                Console.ReadLine();
            }
        }
    }

    class Calculator
    {
        private double baseNum;
        internal int orderNum;

        public void AcceptNumber()
        {
            // enter a base number
            Console.WriteLine("Please enter a base number:");
            baseNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter a order number:");
            orderNum = Convert.ToInt32(Console.ReadLine());
        }

        public double GetResult(double x)
        {
            double resultNum = 1;

            while (x > 0)
            {
                resultNum = baseNum * resultNum;
                x = x - 1;
            }

            return resultNum;
        }
    }

    class GetNumber
    { 
        static void Main(string[] args)
        {
            /*
            Program getNumber = new Program();
            getNumber.AccpetDetails();

            // Show the max number
            Console.WriteLine("Please show max number!");
            getNumber.MaxNumber();

            // show the min number
            Console.WriteLine("Please show min number!");
            getNumber.MinNumber();
            */

            Calculator cal = new Calculator();

            cal.AcceptNumber();
            Console.WriteLine("Order number is {0}", cal.orderNum);

            double result;
            result = cal.GetResult(cal.orderNum);
            Console.WriteLine("The result is {0}", result);
            Console.ReadLine();

        }
    }
}
