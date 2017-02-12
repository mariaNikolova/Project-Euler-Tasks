using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class Program
    {
        public static bool checkIsPrime( int input)
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
           // numberToCheck
                int numberToCheck = int.Parse(Console.ReadLine());

            //int factorCount = 0;
            int sqrt = (int)Math.Ceiling(Math.Sqrt(numberToCheck));

            // Start from 1 as we want our method to also work when numberToCheck is 0 or 1.
            for (int i = 2; i < sqrt; i++)
            {
                if(checkIsPrime(i))
                {
                    if (numberToCheck % i == 0)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
                
            }
            
        }
    }
}
