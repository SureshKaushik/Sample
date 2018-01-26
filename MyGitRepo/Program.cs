using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGitRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayExample();
            Console.ReadLine();
        }

        private static void ArrayExample()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
