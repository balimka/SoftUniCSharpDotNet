using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isOutput = false;
            for (int i = 0; i < array.Length; i++)
            {
                int sumRight = 0;
                int sumLeft = 0;

                for (int j = i+1; j < array.Length; j++)
                {
                    sumRight += array[j];
                }
                for (int k = 0; k < i; k ++)
                {
                    sumLeft += array[k];
                }
                if (sumRight == sumLeft)
                {
                    isOutput = true;
                    Console.WriteLine(i);
                    break;
                }

            }
            if (isOutput == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
