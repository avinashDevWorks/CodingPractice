using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AllDivisors
    {

        public static List<int> PrintAllDivisors(int n)
        {
            List<int> divisors = new List<int>();   
            for (int i= 1; i<= n/2; i++)
            {
                if(n % i == 0)
                {
                    divisors.Add(i);
                }
            }
            divisors.Add(n); // Adding the number itself as a divisor
            return divisors;
        }
    }
}
