using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverseArrayTask
{
    internal class Program
    {
        static List<int> InversePermutation(int[] arr)
        {
            int n = arr.Length;
            List<int> inverse = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                inverse.Add(0);
            }

            for (int i = 0; i < n; i++)
            {
                inverse[arr[i] - 1] = i + 1;
            }

            return inverse;
        }

        static void Main()
        {
            int[] arr1 = { 1, 4, 3, 2 };
            List<int> result1 = InversePermutation(arr1);

            Console.Write("Example 1 Output: ");
            Console.WriteLine(string.Join(" ", result1));

            int[] arr2 = { 2, 3, 4, 5, 1 };
            List<int> result2 = InversePermutation(arr2);

            Console.Write("Example 2 Output: ");
            Console.WriteLine(string.Join(" ", result2));
        }
    }
}
