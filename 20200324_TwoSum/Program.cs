using System;
using System.Linq;

namespace _20200324_TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4, 7, 1, -3, 2};
            int k = 5;

            Console.WriteLine(TwoSum(arr, k));
        }

        static bool TwoSum(int[] arr, int k)
        {
            for(int i = 0; i < arr.Count(); i++)
            {
                for(int j = 0; j < arr.Count(); j++)
                {
                    if((arr[i] + arr[j]) == k)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
