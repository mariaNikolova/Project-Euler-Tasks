using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeProduct
{
    class Program
    {
        public static bool isPalindrome(string myString)
        {
            int length = myString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (myString[i] != myString[length - i - 1])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int currentProduct = 1;
            int maxProduct = 1;
            string result;
            for(int i=100; i< 1000; i++)
            {
                for(int j=100; j < 1000; j++)
                {
                    currentProduct = i * j;
                    result = currentProduct.ToString();
                    if (isPalindrome(result) && currentProduct > maxProduct)
                    {
                        maxProduct = currentProduct;
                    }
                }

            }
            result = maxProduct.ToString();
            Console.WriteLine(result);
        }
    }
}
