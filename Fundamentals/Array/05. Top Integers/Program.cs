using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length ; i++)
            {
                int currNum = arr[i];
                bool topNumber = true;
                for (int j = i+1; j < arr.Length; j++)
                {
                    int rightNum = arr[j];
                    if (rightNum >= currNum)
                    {
                        topNumber = false;
                        break;
                    }
                }
                if (topNumber)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.WriteLine();



            /*string bigger = "";

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        break;
                    }
                    if (j == arr.Length - 1)
                    {
                        bigger += arr[i];
                        bigger += ' ';
                    }
                }

            }
            bigger += arr[arr.Length - 1];
            Console.WriteLine(string.Join(' ', bigger));*/
        }
    }
}
