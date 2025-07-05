using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PalindromeNumber
    {
        //Given an integer x, return true if x is a palindrome, and false otherwise.

        public static bool IsPalindrome(int x)
        {
           if(x < 0 ) return false;
           return x == ReversingNumber(x);
        }

        private static int ReversingNumber(int n)
        {
            int revN = 0;
            int lastDigit = 0;
            while (n > 0)
            {
                lastDigit = n % 10;
                n /= 10;
                revN = (revN * 10) + lastDigit;
            }
            return revN;
        }
    }
}
