using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                int rem = number % 10;
                sum += rem;
                number /= 10;
            }
            Console.WriteLine("Sum=" + sum);
            Console.Read();
        }
    }
}
