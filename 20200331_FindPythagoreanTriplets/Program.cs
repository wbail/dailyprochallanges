using System;
using System.Linq;

namespace _20200331_FindPythagoreanTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {3, 5, 12, 5, 13};

            bool result = FindPythagoreanTriplets(arr.Distinct().ToArray());
            Console.WriteLine(result);
        }

        static bool FindPythagoreanTriplets(int[] arr)
        {
            for(int i = 0; i < arr.Count(); i++)
            {
                for(int j = 0; j < arr.Count(); j++)
                {
                    int aux = (arr[i] * arr[i]) + (arr[j] * arr[j]);
                    for(int k = 0; k < arr.Count(); k++)
                    {
                        if(aux == (arr[k] * arr[k]))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
