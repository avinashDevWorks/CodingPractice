using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ArmstrongNumber
    {
        /* Given an integer N, return true it is an Armstrong number otherwise return false.
An Amrstrong number is a number that is equal to the sum of its own digits each raised to the power of the number of digits.*/
        public static bool IsArmstrong(int N)
        {
            int x = N;
            List<int> listOfDigits = new List<int>();
            while (N > 0)
            {
                int digit = N % 10;
                listOfDigits.Add(digit);
                N /= 10;
            }
            int numberOfDigits = listOfDigits.Count;
            int sum = 0;
            foreach(int digit in listOfDigits)
            {
                sum += (int)Math.Pow(digit, numberOfDigits);
            }
            return sum == x;
        }
    }
}
