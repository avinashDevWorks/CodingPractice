using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputDataProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LeetCode_Easy_TwoSomeProblem();
            Console.ReadLine();
        }

        private static void LeetCode_Easy_TwoSomeProblem()
        {
            int[] values;
            int target;
            ReadInputValuesTwoSum(out values, out target);
            LeetCode_Easy_TwoSome(values, target);
        }

        private static void LeetCode_Easy_TwoSome(int[] values, int target)
        {
            int[] result = Solutions.TwoSum(values, target);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        private static void ReadInputValuesTwoSum(out int[] values, out int target)
        {
            values = new int[10000];
            int arrN = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arrN; i++)
            {
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            target = Convert.ToInt32(Console.ReadLine());
        }

    }
}
