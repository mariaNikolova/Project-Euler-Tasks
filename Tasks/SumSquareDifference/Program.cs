using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifference
{
    class Program
    {
        public static int SumOfSquare(int firstNnumbers)
        {
            int result = (firstNnumbers * (firstNnumbers + 1)*(2 * firstNnumbers + 1)) / 6;
            return result;
        }
        static void Main(string[] args)
        {
            int N = 100;
            int sumOfSquare = SumOfSquare(N);

            int sum = 0;
            for(int i=1; i<=N; i++)
            {
                sum = sum + i;
            }

            int result = sum*sum - sumOfSquare ;
            Console.WriteLine(result);

        }
    }
}
