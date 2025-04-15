using LeetCode;
using System;

namespace InputDataProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter problem: ");
            string problemName = Console.ReadLine();
            switch (problemName)
            {
                case "TwoSum":
                    TwoSomeInputProcessor.ReadInputValuesTwoSum(out int[] values, out int target);
                    int[] result = TwoSomeSolution.TwoSum(values, target);
                    foreach (int i in result)
                    {
                        Console.WriteLine(i);
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
