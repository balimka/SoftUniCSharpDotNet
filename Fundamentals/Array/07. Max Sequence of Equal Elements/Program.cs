using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

/*          int bestSequenceSize = 0;
            int bestSequenceNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                int currentNumber = numbers[i];
                int sequenceSize = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int rightNumber = numbers[j];
                    
                    if (currentNumber == rightNumber)
                    {
                        sequenceSize += 1;
                    }
                    else
                    {
                        i = j - 1;
                        break;
                    }
                }

                if (sequenceSize > bestSequenceNumber)
                {
                    bestSequenceSize = sequenceSize;
                    bestSequenceNumber = currentNumber;
                }
            }

            for (int i = 0; i < bestSequenceSize; i++)
            {
                Console.Write($"{bestSequenceNumber} ");
            }

            Console.WriteLine();*/
            int counter = 1;
            int streak = 0;
            int indexNum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                    else
                    {
                        if (counter > 0 && counter > streak)
                        {
                            streak = counter;
                            indexNum = i;  
                        }
                        counter = 1;
                        break;
                    }
                    if (streak == 0 && j+1 == numbers.Length)
                    {
                        streak = counter;
                        indexNum = i;
                    }
                    
                }

            }
            
            for (int k = indexNum; k < indexNum + streak; k++)
            {
                Console.Write($"{numbers[k]} ");
            }
            Console.WriteLine();
        }
    }
}
