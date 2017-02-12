using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001stPrime
{
    class Program
    {
        public static bool checkIsPrime(int input)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
        static void Main(string[] args)
        {
            int counter = 10002;
            int result = 0;
            int i = 1;
            while(counter > 0)
            {
               
                if (checkIsPrime(i))
                {
                    counter--;
                    result = i;
                }
                //Console.WriteLine(i);
                i = i + 1;
            }
            Console.WriteLine(result);
        }
    }
}
