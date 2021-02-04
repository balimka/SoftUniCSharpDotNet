using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string[] arr1 = input1.Split(" ");

            string input2 = Console.ReadLine();
            string[] arr2 = input2.Split(" ");

            
            for (int j = 0; j < arr2.Length; j++)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.Write($"{arr1[i]} ");
                    }
                }
                
                
            }

        }
    }
}
