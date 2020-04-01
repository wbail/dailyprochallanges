using System;
using System.Linq;

namespace _20200323_SortingListThreeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {3, 3, 2, 1, 3, 2, 1};

            int[] result = SortNums(arr);

            for(int i = 0; i < result.Count(); i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        static int[] SortNums(int[] arr)
        {
            for(int i = 0; i < arr.Count(); i++)
            {
                for(int j = 0; j < arr.Count(); j++)
                {
                    if(arr[i] < arr[j])
                    {
                        int aux = arr[j];
                        arr[j] = arr[i];
                        arr[i] = aux;
                    }
                }
            }

            return arr;
        }
    }
}
