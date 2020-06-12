using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitMethods
{
    class Program
    {
        int i, j;

        private void AccpetDetails()
        {
            //input numbers
            Console.WriteLine("Please enter 2 number:");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
        }

        private void MaxNumber()
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

        private void MinNumber()
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
        static void Main(string[] args)
        {

        }
    }
}
