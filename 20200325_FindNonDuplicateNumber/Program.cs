using System;
using System.Linq;

namespace FindNonDuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = {9, 5, 4, 7, 5, 9, 4, 7, 1};

            Console.WriteLine(FindUniqueNumber(a));
        }

        static int FindUniqueNumber(int[] arr)
        {
            int count = 1, result = 0, n = arr.Count();

            for(int i = 0; i < n; i++)
            {
                int ind = i % n;
                for(int j = 0; j < n; j++)
                {
                    if(arr[ind] == arr[j])
                    {
                        count++;
                    }
                }

                if(count < 2) {
                    result = arr[ind];
                }

                count = 0;
            }

            return result;
        }
    }
}
