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
            int[] values = new int[10000];
            int arrN = Convert.ToInt32(Console.ReadLine());
            for(int i = 0;i<arrN; i++)
            {
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            int target = Convert.ToInt32(Console.ReadLine());

            Solutions sol = new Solutions();
            int[] result = sol.TwoSum(values, target);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        
    }
}
