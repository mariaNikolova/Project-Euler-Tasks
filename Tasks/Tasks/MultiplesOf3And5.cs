using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class MultiplesOf3And5
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=0; i<1000; i++)
            {
                if(i%3 == 0 || i%5 == 0)
                {
                    //Console.WriteLine("The numbers: {0}", i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("The sum is: {0}",sum);
        }
    }
}
