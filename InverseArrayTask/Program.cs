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
           
        }
    }
}
