using System;
using System.Collections.Generic;
using System.Linq;

namespace _20200321_FirstAndLastIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 2, 2, 2, 3, 4, 7, 8, 8};
            int target = 2;
            
            int[] result = FirstLast(arr, target);
            
            for(int i = 0; i < result.Count(); i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        static int[] FirstLast(int[] arr, int target)
        {
            List<int> result = new List<int>(2);
            List<int> indexes = new List<int>();

            for(int i = 0; i < arr.Count(); i++)
            {
                if(arr[i] == target)
                {
                    indexes.Add(i);
                }
            }

            if(indexes.Count() == 0)
            {
                result.Add(-1);
                result.Add(-1);
            }
            else
            {
                result.Add(indexes.Min());
                result.Add(indexes.Max());
            }

            return result.ToArray();
        }
    }
}
