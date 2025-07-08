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
            Console.WriteLine("[1] : Two Sum \t [2] : Palindrome Number \t [3] : Armstrong Number\t [4] : Longest Substring Without Repeating Characters \t");
            Console.WriteLine("[4] : Longest Substring Without Repeating Characters \t [5] : All Divisors");
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

                case 3:
                    List<int> armstrongNumbers = new List<int> { 153, 370, 371, 9474, 9475 };
                    foreach (int num in armstrongNumbers)
                    {
                        bool isArmstrong = ArmstrongNumber.IsArmstrong(num);
                        Console.WriteLine($"Is {num} an Armstrong number? {isArmstrong}");
                    }
                    break;

                case 4:
                    List<string> strings = new List<string> { "abcabcbb", "bbbbb","pwwkew","racecar", "hello", "level", "world", "radar" };
                    foreach (string str in strings)
                    {
                        int length = LongestNonRepeatingSubstring.LengthOfLongestSubstring(str);
                        Console.WriteLine($"The length of the longest substring without repeating characters in '{str}' is {length}");
                    }
                    break;

                case 5: 
                    List<int> numbers = new List<int> { 10, 15, 28, 30, 50 };
                    foreach (int number in numbers)
                    {
                        Console.WriteLine($"All divisors of {number} are: ");
                        List<int> divisors = AllDivisors.PrintAllDivisors(number);
                        foreach (int divisor in divisors)
                        {
                            Console.WriteLine(divisor);
                        }
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
