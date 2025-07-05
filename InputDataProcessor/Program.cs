using LeetCode;
using System;
using System.Collections.Generic;

namespace InputDataProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Select Problem : ");
            Console.WriteLine("[1] : Two Sum \t [2] : Palindrome Number \t");
            int problemName = Int32.Parse(Console.ReadLine());
            switch (problemName)
            {
                case 1:
                    TwoSomeInputProcessor.ReadInputValuesTwoSum(out int[] values, out int target);
                    int[] result = TwoSomeSolution.TwoSum(values, target);
                    foreach (int i in result)
                    {
                        Console.WriteLine(i);
                    }
                    break;

                case 2:
                    List<int> listOfNum = new List<int> { 121, 12223, 24788742, 1, 0, -34567 };
                    foreach (int num in listOfNum)
                    {
                        bool isPalindrome = PalindromeNumber.IsPalindrome(num);
                        Console.WriteLine($"Is {num} a palindrome? {isPalindrome}");
                    }
                    break;

                default:
                    Console.WriteLine( "Problem not solved yet");
                    break;
            }
            Console.ReadLine();
        }
    }
}
