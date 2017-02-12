using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int currentSum = 0;
            //int n = int.Parse(Console.ReadLine());
            //if (n == 1) Console.WriteLine(0);
            //else
            //{
            int first = 0;
            int second = 1;
            //Console.Write(first + " ");
            //Console.Write(second + " ");
            int third = 1;
            while (currentSum < 4000000)
            {
                sum = currentSum;
                third = first + second;
                Console.Write(third + " ");
                first = second;
                second = third;
                if (third % 2 == 0)
                {
                    currentSum += third;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Result: {0}", sum);

        }
    }
}
